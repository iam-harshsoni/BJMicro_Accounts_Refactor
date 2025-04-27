using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Core.Mappers;
using BJMicro_Accounts_Refactor.Core.Services.Interfaces;
using BJMicro_Accounts_Refactor.DataAccess.Repositories.IRepository;
using BJMicro_Accounts_Refactor.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BJMicro_Accounts_Refactor.Core.Services
{
    public class DailyRateService : IDailyRateService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DailyRateService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        //Get all ( List all )
        public async Task<IEnumerable<DailyRateDto>> GetAllAsync(int pageNumber, int pageSize)
        {
            var allEntities = await _unitOfWork.DailyRates.GetAllAsync();
            
            var entities = allEntities
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
 
            return entities.Select(x => x.ToDto()).ToList();
        }

        //Get by {id}
        public async Task<DailyRateDto?> GetByIdAsync(long id)
        {
            var entity = await _unitOfWork.DailyRates.GetAsync(x => x.Id == id);
            return entity == null ? null : entity.ToDto();
        }

        //Get by {date}
        public async Task<DailyRateDto?> GetByDateAsync(DateTime todaysDate)
        {
            var entity = await _unitOfWork.DailyRates.GetAsync(x => x.Date == todaysDate);
            return entity == null ? null : entity.ToDto();
        }

        //Create
        public async Task AddAsync(CreateDailyRateDto dailyRateDto)
        {
            var entity = DailyRateMapper.FromCreateDto(dailyRateDto);
            await _unitOfWork.DailyRates.AddAsync(entity);
            await _unitOfWork.SaveAsync();
        }

        // Update
        public async Task UpdateAsync(UpdateDailyRateDto dto)
        {
            var entity = await _unitOfWork.DailyRates.GetAsync(x => x.Id == dto.Id);
            if (entity != null)
            {
                entity = DailyRateMapper.FromUpdateDto(dto, entity);
                _unitOfWork.DailyRates.Update(entity);
                await _unitOfWork.SaveAsync();
            }
        }

        //Delete
        public async Task DeleteAsync(long id)
        {
            try
            {

                var entity = await _unitOfWork.DailyRates.GetAsync(x => x.Id == id);

                // Check if the entity exists before attempting to remove it
                if (entity != null)
                {
                    _unitOfWork.DailyRates.Remove(entity);
                    await _unitOfWork.SaveAsync(); // Don't forget to save changes!
                }
                else
                {
                    // Handle the case where the entity doesn't exist (optional)
                    throw new KeyNotFoundException($"No DailyRate found with ID: {id}");
                }
            }
            catch (Exception ex)
            {
                // Log the exception for diagnostic purposes
                Console.Error.WriteLine($"Error deleting DailyRate: {ex.Message}");
                throw; // Optionally rethrow the exception if necessary
            }

        }



        // Get by Date Range
        public async Task<IEnumerable<DailyRateDto>> GetRatesByDateRange(DateTime fromDate, DateTime toDate)
        {
            var entities = await _unitOfWork.DailyRates.GetAllAsync(x => x.Date >= fromDate && x.Date <= toDate);

            return entities.Select(x => DailyRateMapper.ToDto(x)).ToList();

        }

        // // Create and Update
        // public async Task AddOrUpdate(DailyRateDto rate)
        // {
        //     var existingData = await _unitOfWork.DailyRates.GetAsync(x => x.Date == rate.Date);

        //     if (existingData == null)
        //     {
        //         var entity = DailyRateMapper.ToCreateDto(rate);
        //         await _unitOfWork.DailyRates.AddAsync(entity);
        //         await _unitOfWork.SaveAsync();
        //     }
        //     else
        //     {
        //         DailyRateMapper.ToUpdateDto(existingData, rate);
        //         _unitOfWork.DailyRates.Update(existingData);
        //         await _unitOfWork.SaveAsync();
        //     }
        // }
    }
}
