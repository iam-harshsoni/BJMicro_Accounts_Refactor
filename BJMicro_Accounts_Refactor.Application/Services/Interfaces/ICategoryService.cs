using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.Core.DTOs;

namespace BJMicro_Accounts_Refactor.Application.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryMasterDto>> GetAllAsync(int pageNumber, int pageSize);
        // Task<CategoryMasterDto?> GetByIdAsync(long id);
        Task<CategoryMasterDto?> GetByIdAsync(long id);
        Task AddAsync(CreateCategoryDto dto);
        Task UpdateAsync(UpdateCategoryDto dto);
        Task DeleteAsync(long id);
    }
}