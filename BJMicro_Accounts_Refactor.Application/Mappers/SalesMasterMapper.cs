using System;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers
{
    public static class SalesMasterMapper
    {
        public static SalesMasterDto ToDto(this TblSalesMaster entity)
        {
            return new SalesMasterDto
            (
                entity.SId,
                entity.BillNo,
                entity.LedgerId,
                entity.Date,
                entity.TotalWeight,
                entity.Unit,
                entity.TotalKarat,
                entity.TotalMaking,
                entity.TotalAmt,
                entity.Remarks,
                entity.CreatedDate,
                entity.UpdateDate
            );
        }

        public static TblSalesMaster FromCreateDto(this CreateSalesMasterDto dto)
        {
            return new TblSalesMaster
            {
                BillNo = dto.BillNo,
                LedgerId = dto.LedgerId,
                Date = dto.Date,
                TotalWeight = dto.TotalWeight,
                Unit = dto.Unit,
                TotalKarat = dto.TotalKarat,
                TotalMaking = dto.TotalMaking,
                TotalAmt = dto.TotalAmt,
                Remarks = dto.Remarks,
                CreatedDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow
            };
        }

        public static TblSalesMaster FromUpdateDto(this UpdateSalesMasterDto dto, TblSalesMaster existingEntity = null)
        {
            var entity = existingEntity ?? new TblSalesMaster();

            entity.BillNo = dto.BillNo;
            entity.LedgerId = dto.LedgerId;
            entity.Date = dto.Date;
            entity.TotalWeight = dto.TotalWeight;
            entity.Unit = dto.Unit;
            entity.TotalKarat = dto.TotalKarat;
            entity.TotalMaking = dto.TotalMaking;
            entity.TotalAmt = dto.TotalAmt;
            entity.Remarks = dto.Remarks;

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