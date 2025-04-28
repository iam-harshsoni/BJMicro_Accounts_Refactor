using System;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers
{
    public static class SalesDetailMapper
    {
        public static SalesDetailDto ToDto(this TblSalesDetail entity)
        {
            return new SalesDetailDto
            (
                entity.SDetailsId,
                entity.SalesId,
                entity.ProductId,
                entity.Qty,
                entity.Weight,
                entity.Unit,
                entity.Karat,
                entity.KRate,
                entity.Making,
                entity.Rate,
                entity.CreatedDate,
                entity.UpdateDate
            );
        }

        public static TblSalesDetail FromCreateDto(this CreateSalesDetailDto dto)
        {
            return new TblSalesDetail
            {
                SalesId = dto.SalesId,
                ProductId = dto.ProductId,
                Qty = dto.Qty,
                Weight = dto.Weight,
                Unit = dto.Unit,
                Karat = dto.Karat,
                KRate = dto.KRate,
                Making = dto.Making,
                Rate = dto.Rate,
                CreatedDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow
            };
        }

        public static TblSalesDetail FromUpdateDto(this UpdateSalesDetailDto dto, TblSalesDetail existingEntity = null)
        {
            var entity = existingEntity ?? new TblSalesDetail();

            entity.SalesId = dto.SalesId;
            entity.ProductId = dto.ProductId;
            entity.Qty = dto.Qty;
            entity.Weight = dto.Weight;
            entity.Unit = dto.Unit;
            entity.Karat = dto.Karat;
            entity.KRate = dto.KRate;
            entity.Making = dto.Making;
            entity.Rate = dto.Rate;

            // If this is a new instance, initialize CreatedDate; otherwise, preserve the original.
            if (existingEntity == null)
            {
                entity.CreatedDate = DateTime.UtcNow;
            }

            entity.UpdateDate = DateTime.UtcNow;

            return entity;
        }
    }
}