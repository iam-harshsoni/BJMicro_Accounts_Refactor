using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.Core.Mappers
{
    public static class DailyRateMapper
    {
        public static DailyRateDto ToDto(DailyRate entity)
        {
            return new DailyRateDto
            {
                Id = entity.Id,
                FineGold = entity.FineGold,
                Hallmark = entity.Hallmark,
                HallmarkBuyBack = entity.HallmarkBuyBack,
                TwentyTwoC=entity.TwentyTwoC,
                TwentyThreeC   =entity.TwentyThreeC,
                EighteenC  = entity.EighteenC,
                Silver = entity.Silver,
                Date = entity.Date

            };
        }

        public static DailyRate MapToEntityForCreate(DailyRateDto dto)
        {
            return new DailyRate
            {
                Id = dto.Id,
                FineGold = dto.FineGold,
                Hallmark = dto.Hallmark,
                HallmarkBuyBack = dto.HallmarkBuyBack,
                TwentyTwoC = dto.TwentyTwoC,
                TwentyThreeC = dto.TwentyThreeC,
                EighteenC = dto.EighteenC,
                Silver = dto.Silver,
                Date = dto.Date,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
        }

        public static void MapToEntityForUpdate(DailyRate? entity, DailyRateDto dto)
        {
            entity.FineGold = dto.FineGold;
            entity.Hallmark = dto.Hallmark;
            entity.HallmarkBuyBack = dto.HallmarkBuyBack;
            entity.TwentyTwoC = dto.TwentyTwoC;
            entity.TwentyThreeC = dto.TwentyThreeC;
            entity.EighteenC = dto.EighteenC;
            entity.Silver = dto.Silver;
            entity.Date = dto.Date;
            entity.UpdatedDate = DateTime.Now; // Only UpdatedDate is changed
        }
    }
}
