using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

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
        Task<IEnumerable<DailyRateDto>> GetRatesByDateRange(DateTime fromDate, DateTime toDate);

        Task AddOrUpdate(DailyRateDto rate);
    }
}
