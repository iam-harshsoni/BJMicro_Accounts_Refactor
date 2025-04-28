
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Application.Mappers
{
    public static class CategoryMapper
    {
        public static CategoryMasterDto ToDto(this TblCategoryMaster entity)
        {
            return new CategoryMasterDto(
                entity.CId,
                entity.CName,
                entity.Prefix
            );
        }

        public static TblCategoryMaster FromCreateDto(this CreateCategoryDto dto)
        {

            return new TblCategoryMaster
            {
                CName = dto.CName,
                Prefix = dto.Prefix,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            };
        }

        public static TblCategoryMaster FromUpdateDto(this UpdateCategoryDto dto, TblCategoryMaster existingEntity = null)
        {

            // If updating an existing entity, preserve its original properties
            var entity = existingEntity ?? new TblCategoryMaster();

            entity.CName = dto.CName;
            entity.Prefix = dto.Prefix;
            entity.CreatedDate = DateTime.UtcNow;

            return entity;
        }
    }
}