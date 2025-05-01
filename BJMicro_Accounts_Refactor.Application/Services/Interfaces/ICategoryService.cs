using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.Core.DTOs;

namespace BJMicro_Accounts_Refactor.Core.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryMasterDto>> GetAllAsync(int pageNumber, int pageSize);
        // Task<CategoryMasterDto?> GetByIdAsync(long id);
        Task<CategoryMasterDto?> GetByIdAsync(long id);
        Task AddAsync(CreateCategoryDto dto);
        Task UpdateAsync(long id, UpdateCategoryDto dto);
        Task DeleteAsync(long id);
    }
}