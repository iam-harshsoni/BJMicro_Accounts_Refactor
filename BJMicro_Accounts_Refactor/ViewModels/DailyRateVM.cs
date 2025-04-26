
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJMicro_Accounts_Refactor.ViewModels;

public class DailyRateVM
{
    public long rowNo { get; set; }
    public long id { get; set; }
    public decimal? fineGold { get; set; }
    public decimal? hallmark { get; set; }
    public decimal? hallmarkBuyBack { get; set; }
    public decimal? twentyTwoC { get; set; }
    public decimal? twentyThreeC { get; set; }
    public decimal? silver { get; set; }
    public string date { get; set; }
    public DateTime? createdDate { get; set; }
    public DateTime? updatedDate { get; set; }


    // Add these properties for formatted display
    public string fineGoldFormatted { get; set; }
    public string twentyTwoCFormatted { get; set; }
    public string twentyThreeCFormatted { get; set; }
    public string silverFormatted { get; set; }
    public string hallmarkFormatted { get; set; }
    public string hallmarkBuyBackFormatted { get; set; }
}

