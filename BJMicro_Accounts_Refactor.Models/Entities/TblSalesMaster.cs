using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Domain.Entities;

public partial class TblSalesMaster
{
    public long SId { get; set; }

    public string? BillNo { get; set; }

    public long? LedgerId { get; set; }

    public DateTime? Date { get; set; }

    public decimal? TotalWeight { get; set; }

    public string? Unit { get; set; }

    public decimal? TotalKarat { get; set; }

    public decimal? TotalMaking { get; set; }

    public decimal? TotalAmt { get; set; }

    public string? Remarks { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual TblAccLedger? Ledger { get; set; }

    public virtual ICollection<TblSalesDetail> TblSalesDetails { get; set; } = new List<TblSalesDetail>();
}
