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
        Task<IEnumerable<DailyRateDto>> GetAllAsync(int pageNumber, int pageSize);
        Task<DailyRateDto?> GetByIdAsync(long id);
        Task<DailyRateDto?> GetByDateAsync(DateTime todaysDate);
        Task AddAsync(CreateDailyRateDto dto);
        Task UpdateAsync(UpdateDailyRateDto dto);
        Task DeleteAsync(long id);
        Task<IEnumerable<DailyRateDto>> GetRatesByDateRange(DateTime fromDate, DateTime toDate);

        //  Task AddOrUpdate(DailyRateDto rate);
    }
}
