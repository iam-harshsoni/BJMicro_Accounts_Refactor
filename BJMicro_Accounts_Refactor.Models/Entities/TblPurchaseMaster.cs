using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Domain.Entities;

public partial class TblPurchaseMaster
{
    public long PId { get; set; }

    public string? RefNo { get; set; }

    public long? LedgerId { get; set; }

    public DateTime? Date { get; set; }

    public decimal? TotalWeight { get; set; }

    public string? Unit { get; set; }

    public decimal? TotalMelting { get; set; }

    public decimal? TotalPurchaseMelting { get; set; }

    public decimal? TotalMaking { get; set; }

    public decimal? TotalFine { get; set; }

    public decimal? TotalAmt { get; set; }

    public string? Remarks { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual TblAccLedger? Ledger { get; set; }

    public virtual ICollection<TblPurchaseDetail> TblPurchaseDetails { get; set; } = new List<TblPurchaseDetail>();
}
