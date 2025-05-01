using System;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers;

public static class AccGroupMapper
{
    public static AccGroupDto ToDto(this TblAccGroup entity)
    {
        return new AccGroupDto
        (
            entity.GroupId,
            entity.Id,
            entity.ParentId,
            entity.GroupName,
            entity.AffectsGross,
            entity.CreatedDate,
            entity.UpdateDate
        );
    }

    public static TblAccGroup FromCreateDto(this CreateAccGroupDto dto)
    {
        return new TblAccGroup
        {
            Id = dto.Id,
            ParentId = dto.ParentId,
            GroupName = dto.GroupName,
            AffectsGross = dto.AffectsGross,
            CreatedDate = DateTime.UtcNow,
            UpdateDate = DateTime.UtcNow
        };
    }

    public static TblAccGroup FromUpdateDto(this UpdateAccGroupDto dto, TblAccGroup existingEntity = null)
    {
        var entity = existingEntity ?? new TblAccGroup();

        entity.Id = dto.Id;
        entity.ParentId = dto.ParentId;
        entity.GroupName = dto.GroupName;
        entity.AffectsGross = dto.AffectsGross;

        // If there is no existing entity, then it is like creating a new record,
        // so assign the CreatedDate. In all cases, update the UpdateDate.
        if (existingEntity == null)
        {
            entity.CreatedDate = DateTime.UtcNow;
        }
        entity.UpdateDate = DateTime.UtcNow;

        return entity;
    }
}