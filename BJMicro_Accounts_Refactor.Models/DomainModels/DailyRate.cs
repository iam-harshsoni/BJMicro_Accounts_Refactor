using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Models.DomainModels;

public partial class DailyRate
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

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
