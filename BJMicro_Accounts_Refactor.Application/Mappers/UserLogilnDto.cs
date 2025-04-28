using System;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers
{
    public static class UserLogilnMapper
    {
        public static UserLoginDto ToDto(this TblUserLogiln entity)
        {
            return new UserLoginDto
            (
                entity.Id,
                entity.UserId,
                entity.LoginId,
                entity.LastLogin,
                entity.CreatedDate,
                entity.UpdateDate
            );
        }

        public static TblUserLogiln FromCreateDto(this CreateUserLoginDto dto)
        {
            return new TblUserLogiln
            {
                UserId = dto.UserId,
                LoginId = dto.LoginId,
                Password = dto.Password,
                LastLogin = dto.LastLogin,
                CreatedDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow
            };
        }

        public static TblUserLogiln FromUpdateDto(this UpdateUserLoginDto dto, TblUserLogiln existingEntity = null)
        {
            var entity = existingEntity ?? new TblUserLogiln();

            entity.UserId = dto.UserId;
            entity.LoginId = dto.LoginId;
            entity.Password = dto.Password;
            entity.LastLogin = dto.LastLogin;

            // Preserve the original CreatedDate if updating an existing entity.
            if (existingEntity == null)
            {
                entity.CreatedDate = DateTime.UtcNow;
            }
            entity.UpdateDate = DateTime.UtcNow;

            return entity;
        }
    }
}