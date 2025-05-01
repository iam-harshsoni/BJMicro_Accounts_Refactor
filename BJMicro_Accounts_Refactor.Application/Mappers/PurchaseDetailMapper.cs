using System;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers;

public static class PurchaseDetailMapper
{
    public static PurchaseDetailDto ToDto(this TblPurchaseDetail entity)
    {
        return new PurchaseDetailDto
        (
            entity.PdetailsId,
            entity.PurchaseId,
            entity.ProductId,
            entity.Qty,
            entity.Weight,
            entity.Unit,
            entity.Karat,
            entity.KRate,
            entity.Melting,
            entity.PurchaseMelting,
            entity.Making,
            entity.Fine,
            entity.Rate,
            entity.CreatedDate,
            entity.UpdatedDate
        );
    }

    public static TblPurchaseDetail FromCreateDto(this CreatePurchaseDetailDto dto)
    {
        return new TblPurchaseDetail
        {
            PurchaseId = dto.PurchaseId,
            ProductId = dto.ProductId,
            Qty = dto.Qty,
            Weight = dto.Weight,
            Unit = dto.Unit,
            Karat = dto.Karat,
            KRate = dto.KRate,
            Melting = dto.Melting,
            PurchaseMelting = dto.PurchaseMelting,
            Making = dto.Making,
            Fine = dto.Fine,
            Rate = dto.Rate,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow
        };
    }

    public static TblPurchaseDetail FromUpdateDto(this UpdatePurchaseDetailDto dto, TblPurchaseDetail existingEntity = null)
    {
        var entity = existingEntity ?? new TblPurchaseDetail();

        entity.PurchaseId = dto.PurchaseId;
        entity.ProductId = dto.ProductId;
        entity.Qty = dto.Qty;
        entity.Weight = dto.Weight;
        entity.Unit = dto.Unit;
        entity.Karat = dto.Karat;
        entity.KRate = dto.KRate;
        entity.Melting = dto.Melting;
        entity.PurchaseMelting = dto.PurchaseMelting;
        entity.Making = dto.Making;
        entity.Fine = dto.Fine;
        entity.Rate = dto.Rate;

        if (existingEntity == null)
        {
            entity.CreatedDate = DateTime.UtcNow;
        }
        entity.UpdatedDate = DateTime.UtcNow;

        return entity;
    }
}