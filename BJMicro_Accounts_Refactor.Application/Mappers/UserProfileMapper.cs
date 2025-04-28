using System;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers
{
    public static class UserProfileMapper
    {
        public static UserProfileDto ToDto(this TblUserProfile entity)
        {
            return new UserProfileDto
            (
                entity.UserId,
                entity.Email,
                entity.FirstName,
                entity.LastName,
                entity.Mobile,
                entity.CreatedDate,
                entity.UpdateDate
            );
        }

        public static TblUserProfile FromCreateDto(this CreateUserProfileDto dto)
        {
            return new TblUserProfile
            {
                Email = dto.Email,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Mobile = dto.Mobile,
                CreatedDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow
            };
        }

        public static TblUserProfile FromUpdateDto(this UpdateUserProfileDto dto, TblUserProfile existingEntity = null)
        {
            var entity = existingEntity ?? new TblUserProfile();

            entity.Email = dto.Email;
            entity.FirstName = dto.FirstName;
            entity.LastName = dto.LastName;
            entity.Mobile = dto.Mobile;

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