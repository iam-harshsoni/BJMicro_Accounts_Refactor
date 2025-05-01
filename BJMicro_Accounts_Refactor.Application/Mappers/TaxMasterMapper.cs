using System;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers;

public static class TaxMasterMapper
{
    public static TaxMasterDto ToDto(this TblTaxMaster entity)
    {
        return new TaxMasterDto
        (
            entity.TId,
            entity.VoucherType,
            entity.VoucherId,
            entity.TotalTax,
            entity.CDate,
            entity.UDate
        );
    }

    public static TblTaxMaster FromCreateDto(this CreateTaxMasterDto dto)
    {
        return new TblTaxMaster
        {
            VoucherType = dto.VoucherType,
            VoucherId = dto.VoucherId,
            TotalTax = dto.TotalTax,
            CDate = DateTime.UtcNow,
            UDate = DateTime.UtcNow
        };
    }

    public static TblTaxMaster FromUpdateDto(this UpdateTaxMasterDto dto, TblTaxMaster existingEntity = null)
    {
        var entity = existingEntity ?? new TblTaxMaster();

        entity.VoucherType = dto.VoucherType;
        entity.VoucherId = dto.VoucherId;
        entity.TotalTax = dto.TotalTax;

        // Preserve the original creation date if updating an existing entity.
        if (existingEntity == null)
        {
            entity.CDate = DateTime.UtcNow;
        }
        entity.UDate = DateTime.UtcNow;

        return entity;
    }
}