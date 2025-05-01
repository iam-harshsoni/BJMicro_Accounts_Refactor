
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers;
public static class TblItemMasterMapper
{
    // Map entity to full read DTO
    public static TblItemMasterDto ToDto(TblItemMaster itemMaster)
    {
        return new TblItemMasterDto(
            itemMaster.Id,
            itemMaster.ItemCode,
            itemMaster.CategoryId,
            itemMaster.Photo,
            itemMaster.CreatedDate,
            itemMaster.UpdateDate
        );
    }

    // Create a new TblItemMaster entity from a creation DTO
    public static TblItemMaster FromCreateDto(CreateItemDto createDto)
    {
        return new TblItemMaster
        {
            ItemCode = createDto.ItemCode,
            CategoryId = createDto.CategoryId,
            Photo = createDto.Photo,
            CreatedDate = DateTime.UtcNow
        };
    }

    // Update an existing TblItemMaster entity using an update DTO
    public static TblItemMaster FromUpdateDto(UpdateItemDto updateDto, TblItemMaster existingItemMaster = null)
    {
        // If updating an existing entity, preserve its original properties
        var entity = existingItemMaster ?? new TblItemMaster();

        entity.ItemCode = updateDto.ItemCode;
        entity.CategoryId = updateDto.CategoryId;
        entity.Photo = updateDto.Photo;
        entity.UpdateDate = DateTime.UtcNow;

        return entity;
    }
}