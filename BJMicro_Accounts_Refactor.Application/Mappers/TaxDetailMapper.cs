using System;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers
{
    public static class TaxDetailMapper
    {
        public static TaxDetailDto ToDto(this TblTaxDetail entity)
        {
            return new TaxDetailDto
            (
                entity.TaxDetailsId,
                entity.TId,
                entity.CgstPer,
                entity.CgstRate,
                entity.SgstPer,
                entity.SgstRate,
                entity.IgstPer,
                entity.IgstRate,
                entity.CDate,
                entity.UDate
            );
        }

        public static TblTaxDetail FromCreateDto(this CreateTaxDetailDto dto)
        {
            return new TblTaxDetail
            {
                TId = dto.TId,
                CgstPer = dto.CgstPer,
                CgstRate = dto.CgstRate,
                SgstPer = dto.SgstPer,
                SgstRate = dto.SgstRate,
                IgstPer = dto.IgstPer,
                IgstRate = dto.IgstRate,
                CDate = DateTime.UtcNow,
                UDate = DateTime.UtcNow
            };
        }

        public static TblTaxDetail FromUpdateDto(this UpdateTaxDetailDto dto, TblTaxDetail existingEntity = null)
        {
            var entity = existingEntity ?? new TblTaxDetail();

            entity.TId = dto.TId;
            entity.CgstPer = dto.CgstPer;
            entity.CgstRate = dto.CgstRate;
            entity.SgstPer = dto.SgstPer;
            entity.SgstRate = dto.SgstRate;
            entity.IgstPer = dto.IgstPer;
            entity.IgstRate = dto.IgstRate;

            // Preserve the original creation date if the entity already exists.
            if (existingEntity == null)
            {
                entity.CDate = DateTime.UtcNow;
            }
            entity.UDate = DateTime.UtcNow;

            return entity;
        }
    }
}