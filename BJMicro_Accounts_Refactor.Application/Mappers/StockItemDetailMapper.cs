using System;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers
{
    public static class StockItemDetailMapper
    {
        public static StockItemDetailDto ToDto(this TblStockItemDetail entity)
        {
            return new StockItemDetailDto
            (
                entity.Id,
                entity.ItemId,
                entity.Qty,
                entity.Weight,
                entity.Unit,
                entity.Melting,
                entity.Carret,
                entity.Remarks,
                entity.CreatedDate,
                entity.UpadtedDate
            );
        }

        public static TblStockItemDetail FromCreateDto(this CreateStockItemDetailDto dto)
        {
            return new TblStockItemDetail
            {
                ItemId = dto.ItemId,
                Qty = dto.Qty,
                Weight = dto.Weight,
                Unit = dto.Unit,
                Melting = dto.Melting,
                Carret = dto.Carret,
                Remarks = dto.Remarks,
                CreatedDate = DateTime.UtcNow,
                UpadtedDate = DateTime.UtcNow
            };
        }

        public static TblStockItemDetail FromUpdateDto(this UpdateStockItemDetailDto dto, TblStockItemDetail existingEntity = null)
        {
            var entity = existingEntity ?? new TblStockItemDetail();

            entity.ItemId = dto.ItemId;
            entity.Qty = dto.Qty;
            entity.Weight = dto.Weight;
            entity.Unit = dto.Unit;
            entity.Melting = dto.Melting;
            entity.Carret = dto.Carret;
            entity.Remarks = dto.Remarks;

            // Preserve the original CreatedDate if updating an existing entity.
            if (existingEntity == null)
            {
                entity.CreatedDate = DateTime.UtcNow;
            }
            entity.UpadtedDate = DateTime.UtcNow;

            return entity;
        }
    }
}