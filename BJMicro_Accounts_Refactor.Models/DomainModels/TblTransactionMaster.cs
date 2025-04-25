using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Models.DomainModels;

public partial class TblTransactionMaster
{
    public long TId { get; set; }

    public DateTime TDate { get; set; }

    public string? VoucherType { get; set; }

    public long? VoucherRefNo { get; set; }

    public decimal? CrAmt { get; set; }

    public decimal? DrAmt { get; set; }

    public long? LedgerId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public long? LoginId { get; set; }

    public virtual TblUserLogiln? Login { get; set; }
}
