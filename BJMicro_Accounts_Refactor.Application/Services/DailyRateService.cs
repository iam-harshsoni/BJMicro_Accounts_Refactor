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

        public async Task AddAsync(DailyRateDto dto)
        {
            var entity = DailyRateMapper.MapToEntityForCreate(dto);
            await _unitOfWork.DailyRates.AddAsync(entity);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(long id)
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

        public async Task<IEnumerable<DailyRateDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.DailyRates.GetAllAsync();
            return entities.Select(x=>DailyRateMapper.ToDto(x)).ToList();
        }

        public async Task<DailyRateDto?> GetByIdAsync(long id)
        {
            var entity = await _unitOfWork.DailyRates.GetAsync(x => x.Id == id);
            return entity == null ? null : DailyRateMapper.ToDto(entity);
        }

        public async Task<DailyRateDto?> GetByDateAsync(DateTime todaysDate)
        {
            var entity = await _unitOfWork.DailyRates.GetAsync(x => x.Date == todaysDate);
            return entity == null ? null : DailyRateMapper.ToDto(entity);
        }

        public async Task UpdateAsync(DailyRateDto dto)
        {
            var entity = await _unitOfWork.DailyRates.GetAsync(x => x.Id == dto.Id);
            if (entity != null)
            {
                DailyRateMapper.MapToEntityForUpdate(entity, dto);
                _unitOfWork.DailyRates.Update(entity);
                await _unitOfWork.SaveAsync();
            }
        }

        public async Task<IEnumerable<DailyRateDto>> GetRatesByDateRange(DateTime fromDate, DateTime toDate)
        {
            var entities = await _unitOfWork.DailyRates.GetAllAsync(x => x.Date >= fromDate && x.Date <= toDate);

            return entities.Select(x => DailyRateMapper.ToDto(x)).ToList();

        }

        public async Task AddOrUpdate(DailyRateDto rate)
        {
            var existingData = await _unitOfWork.DailyRates.GetAsync(x => x.Date == rate.Date);

            if (existingData != null)
            {
                var entity = DailyRateMapper.MapToEntityForCreate(rate);
                await _unitOfWork.DailyRates.AddAsync(entity);
                await _unitOfWork.SaveAsync();
            }
            else
            {
                DailyRateMapper.MapToEntityForUpdate(existingData, rate);
                _unitOfWork.DailyRates.Update(existingData);
                await _unitOfWork.SaveAsync();
            }
        }
    }
}
