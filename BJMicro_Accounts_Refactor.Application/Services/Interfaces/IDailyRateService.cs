using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.Core.DTOs;

namespace BJMicro_Accounts_Refactor.Core.Services.Interfaces
{
    public interface IDailyRateService
    {
        Task<IEnumerable<DailyRateDto>> GetAllAsync();
        Task<DailyRateDto?> GetByIdAsync(long id);
        Task<DailyRateDto?> GetByDateAsync(DateTime todaysDate);
        Task AddAsync(DailyRateDto dto);
        Task UpdateAsync(DailyRateDto dto);
        Task DeleteAsync(long id);
    }
}
