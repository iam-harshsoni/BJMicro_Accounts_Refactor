using BJMicro_Accounts_Refactor.Core.DTOs;

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
