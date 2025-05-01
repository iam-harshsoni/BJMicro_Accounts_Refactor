using System;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers;

public static class EntryDetailMapper
{
    public static EntryDetailDto ToDto(this TblEntryDetail entity)
    {
        return new EntryDetailDto
        (
            entity.PDetailsId,
            entity.VoucherRefNo,
            entity.PurchaseSalesIds,
            entity.AmtPaid,
            entity.CreatedDate,
            entity.UpdatedDate
        );
    }

    public static TblEntryDetail FromCreateDto(this CreateEntryDetailDto dto)
    {
        return new TblEntryDetail
        {
            VoucherRefNo = dto.VoucherRefNo,
            PurchaseSalesIds = dto.PurchaseSalesIds,
            AmtPaid = dto.AmtPaid,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow
        };
    }

    public static TblEntryDetail FromUpdateDto(this UpdateEntryDetailDto dto, TblEntryDetail existingEntity = null)
    {
        var entity = existingEntity ?? new TblEntryDetail();

        entity.VoucherRefNo = dto.VoucherRefNo;
        entity.PurchaseSalesIds = dto.PurchaseSalesIds;
        entity.AmtPaid = dto.AmtPaid;

        if (existingEntity == null)
        {
            entity.CreatedDate = DateTime.UtcNow;
        }
        entity.UpdatedDate = DateTime.UtcNow;

        return entity;
    }
}