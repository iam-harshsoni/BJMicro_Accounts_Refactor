using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Models.DomainModels;

public partial class TblLedgerDetail
{
    public long Id { get; set; }

    public long? LedgerId { get; set; }

    public string? Address { get; set; }

    public decimal? Contact { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual TblAccLedger? Ledger { get; set; }
}
