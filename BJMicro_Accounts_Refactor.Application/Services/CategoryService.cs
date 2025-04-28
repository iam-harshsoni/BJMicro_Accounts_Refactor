using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.Core.Mappers;
using BJMicro_Accounts_Refactor.Core.Services.Interfaces;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.DataAccess.Repositories;
using BJMicro_Accounts_Refactor.DataAccess.Repositories.IRepository;
using Microsoft.Identity.Client;

namespace BJMicro_Accounts_Refactor.Core.Services
{
    public class CategoryService(IUnitOfWork unitOfWork) : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<IEnumerable<CategoryMasterDto>> GetAllAsync(int pageNumber, int pageSize)
        {
            var allEntities = await _unitOfWork.Category.GetAllAsync();

            var entities = allEntities
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList();

            return entities.Select(x => x.ToDto()).ToList();

        }

        public async Task<CategoryMasterDto?> GetByIdAsync(long id)
        {
            var entity = await _unitOfWork.Category.GetAsync(x => x.CId == id);
            return entity == null ? null : entity.ToDto();
        }

        public async Task AddAsync(CreateCategoryDto dto)
        {
            var entity = CategoryMapper.FromCreateDto(dto);
            await _unitOfWork.Category.AddAsync(entity);
            await _unitOfWork.SaveAsync();
        }
        public async Task UpdateAsync(UpdateCategoryDto dto)
        {
            var entity = await _unitOfWork.Category.GetAsync(x => x.CId == dto.CId);
            if (entity != null)
            {
                entity = CategoryMapper.FromUpdateDto(dto, entity);
                _unitOfWork.Category.Update(entity);
                await _unitOfWork.SaveAsync();
            }
        }
        public async Task DeleteAsync(long id)
        {
            try
            {
                var entity = await _unitOfWork.Category.GetAsync(x => x.CId == id);

                if (entity != null)
                {
                    _unitOfWork.Category.Remove(entity);
                    await _unitOfWork.SaveAsync();
                }
            }
            catch (Exception ex)
            {
                // Log the exception for diagnostic purposes
                Console.Error.WriteLine($"Error deleting DailyRate: {ex.Message}");
                throw; // Optionally rethrow the exception if necessary
            }
        }

    }
}