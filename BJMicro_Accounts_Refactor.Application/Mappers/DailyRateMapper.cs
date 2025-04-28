using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers
{
    public static class DailyRateMapper
    {
        public static DailyRateDto ToDto(this DailyRate entity)
        {
            return new DailyRateDto
            (
                entity.Id,
                entity.FineGold,
                entity.Hallmark,
                entity.HallmarkBuyBack,
                entity.TwentyTwoC,
                entity.TwentyThreeC,
                entity.EighteenC,
                entity.Silver,
                entity.Date
            );
        }

        public static DailyRate FromCreateDto(this CreateDailyRateDto dto)
        {
            return new DailyRate
            {
                Date = DateTime.UtcNow,
                FineGold = dto.FineGold,
                Hallmark = dto.Hallmark,
                HallmarkBuyBack = dto.HallmarkBuyBack,
                TwentyTwoC = dto.TwentyTwoC,
                TwentyThreeC = dto.TwentyThreeC,
                EighteenC = dto.EighteenC,
                Silver = dto.Silver,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            };

        }

        public static DailyRate FromUpdateDto(this UpdateDailyRateDto dto, DailyRate existingEntity = null)
        {
            // If updating an existing entity, preserve its original properties
            var entity = existingEntity ?? new DailyRate();
            
            entity.Id = dto.Id;
            entity.FineGold = dto.FineGold;
            entity.Hallmark = dto.Hallmark;
            entity.HallmarkBuyBack = dto.HallmarkBuyBack;
            entity.TwentyTwoC = dto.TwentyTwoC;
            entity.TwentyThreeC = dto.TwentyThreeC;
            entity.EighteenC = dto.EighteenC;
            entity.Silver = dto.Silver;
            entity.UpdatedDate = DateTime.UtcNow;
            
            return entity;
        }
    }
}
