using System;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers;

public static class AccLedgerMapper
{
    public static AccLedgerDto ToDto(this TblAccLedger entity)
    {
        return new AccLedgerDto
        (
            entity.Id,
            entity.GroupId,
            entity.LedgerName,
            entity.OpBalance,
            entity.OpBalanceDc,
            entity.Type,
            entity.Notes,
            entity.DrId,
            entity.CrId,
            entity.CreatedDate,
            entity.UpdatedDate
        );
    }

    public static TblAccLedger FromCreateDto(this CreateAccLedgerDto dto)
    {
        return new TblAccLedger
        {
            GroupId = dto.GroupId,
            LedgerName = dto.LedgerName,
            OpBalance = dto.OpBalance,
            OpBalanceDc = dto.OpBalanceDc,
            //Type = dto.EntryType,
            Notes = dto.Notes,
            DrId = dto.DrId,
            CrId = dto.CrId,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow
        };
    }

    public static TblAccLedger FromUpdateDto(this UpdateAccLedgerDto dto, TblAccLedger existingEntity = null)
    {
        var entity = existingEntity ?? new TblAccLedger();

        entity.GroupId = dto.GroupId;
        entity.LedgerName = dto.LedgerName;
        entity.OpBalance = dto.OpBalance;
        entity.OpBalanceDc = dto.OpBalanceDc;
        // entity.Type = dto.EntryType;
        entity.Notes = dto.Notes;
        entity.DrId = dto.DrId;
        entity.CrId = dto.CrId;

        // If it's a new entity, set CreatedDate. Always update UpdatedDate.
        if (existingEntity == null)
        {
            entity.CreatedDate = DateTime.UtcNow;
        }
        entity.UpdatedDate = DateTime.UtcNow;

        return entity;
    }
}