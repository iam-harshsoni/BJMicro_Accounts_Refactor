using System;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers
{
    public static class LedgerDetailMapper
    {
        public static LedgerDetailDto ToDto(this TblLedgerDetail entity)
        {
            return new LedgerDetailDto
            (
                entity.Id,
                entity.LedgerId,
                entity.Address,
                entity.Contact,
                entity.CreatedDate,
                entity.UpdateDate
            );
        }

        public static TblLedgerDetail FromCreateDto(this CreateLedgerDetailDto dto)
        {
            return new TblLedgerDetail
            {
                LedgerId = dto.LedgerId,
                Address = dto.Address,
                Contact = dto.Contact,
                CreatedDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow
            };
        }

        public static TblLedgerDetail FromUpdateDto(this UpdateLedgerDetailDto dto, TblLedgerDetail existingEntity = null)
        {
            var entity = existingEntity ?? new TblLedgerDetail();

            entity.LedgerId = dto.LedgerId;
            entity.Address = dto.Address;
            entity.Contact = dto.Contact;

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