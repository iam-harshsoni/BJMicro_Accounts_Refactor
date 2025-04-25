using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Models.DomainModels;

public partial class TblEntry
{
    public long VoucherRefNo { get; set; }

    public int? EntryType { get; set; }

    public long? CrId { get; set; }

    public long? DrId { get; set; }

    public decimal? Amt { get; set; }

    public DateOnly? Date { get; set; }

    public string? StringDate { get; set; }

    public string? Remarks { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
