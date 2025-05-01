using System;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers;

public static class TransactionMasterMapper
{
    public static TransactionMasterDto ToDto(this TblTransactionMaster entity)
    {
        return new TransactionMasterDto
        (
            entity.TId,
            entity.TDate,
            entity.VoucherType,
            entity.VoucherRefNo,
            entity.CrAmt,
            entity.DrAmt,
            entity.LedgerId,
            entity.CreatedDate,
            entity.UpdatedDate,
            entity.LoginId
        );
    }

    public static TblTransactionMaster FromCreateDto(this CreateTransactionMasterDto dto)
    {
        return new TblTransactionMaster
        {
            TDate = dto.TDate,
            VoucherType = dto.VoucherType,
            VoucherRefNo = dto.VoucherRefNo,
            CrAmt = dto.CrAmt,
            DrAmt = dto.DrAmt,
            LedgerId = dto.LedgerId,
            LoginId = dto.LoginId,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow
        };
    }

    public static TblTransactionMaster FromUpdateDto(this UpdateTransactionMasterDto dto, TblTransactionMaster existingEntity = null)
    {
        var entity = existingEntity ?? new TblTransactionMaster();

        entity.TDate = dto.TDate;
        entity.VoucherType = dto.VoucherType;
        entity.VoucherRefNo = dto.VoucherRefNo;
        entity.CrAmt = dto.CrAmt;
        entity.DrAmt = dto.DrAmt;
        entity.LedgerId = dto.LedgerId;
        entity.LoginId = dto.LoginId;

        // Preserve the original CreatedDate if updating an existing entity.
        if (existingEntity == null)
        {
            entity.CreatedDate = DateTime.UtcNow;
        }
        entity.UpdatedDate = DateTime.UtcNow;

        return entity;
    }
}