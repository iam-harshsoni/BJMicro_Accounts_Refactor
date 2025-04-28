using System;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers
{
    public static class EntryMapper
    {
        public static EntryDto ToDto(this TblEntry entity)
        {
            return new EntryDto
            (
                entity.VoucherRefNo,
                entity.EntryType,
                entity.CrId,
                entity.DrId,
                entity.Amt,
                entity.Date,
                entity.StringDate,
                entity.Remarks,
                entity.CreatedDate,
                entity.UpdatedDate
            );
        }

        public static TblEntry FromCreateDto(this CreateEntryDto dto)
        {
            return new TblEntry
            {
                EntryType = dto.EntryType,
                CrId = dto.CrId,
                DrId = dto.DrId,
                Amt = dto.Amt,
                Date = dto.Date,
                StringDate = dto.StringDate,
                Remarks = dto.Remarks,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            };
        }

        public static TblEntry FromUpdateDto(this UpdateEntryDto dto, TblEntry existingEntity = null)
        {
            var entity = existingEntity ?? new TblEntry();

            entity.EntryType = dto.EntryType;
            entity.CrId = dto.CrId;
            entity.DrId = dto.DrId;
            entity.Amt = dto.Amt;
            entity.Date = dto.Date;
            entity.StringDate = dto.StringDate;
            entity.Remarks = dto.Remarks;

            if (existingEntity == null)
            {
                entity.CreatedDate = DateTime.UtcNow;
            }
            entity.UpdatedDate = DateTime.UtcNow;

            return entity;
        }
    }
}