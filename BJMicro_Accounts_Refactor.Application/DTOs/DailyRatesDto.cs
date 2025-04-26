using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJMicro_Accounts_Refactor.Core.DTOs
{
    public class DailyRateDto
    {
        public long Id { get; set; }
        public decimal? FineGold { get; set; }
        public decimal? Hallmark { get; set; }
        public decimal? HallmarkBuyBack { get; set; }
        public decimal? TwentyTwoC { get; set; }
        public decimal? TwentyThreeC { get; set; }
        public decimal? EighteenC { get; set; }
        public decimal? Silver { get; set; }
        public DateTime? Date { get; set; } 
    }
}
