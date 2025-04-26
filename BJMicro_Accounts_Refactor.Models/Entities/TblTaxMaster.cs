using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Domain.Entities;

public partial class TblTaxMaster
{
    public long TId { get; set; }

    public string? VoucherType { get; set; }

    public long? VoucherId { get; set; }

    public decimal? TotalTax { get; set; }

    public DateTime? CDate { get; set; }

    public DateTime? UDate { get; set; }

    public virtual ICollection<TblTaxDetail> TblTaxDetails { get; set; } = new List<TblTaxDetail>();
}
