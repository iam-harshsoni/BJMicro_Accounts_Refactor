using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Models.DomainModels;

public partial class TblEntryDetail
{
    public long PDetailsId { get; set; }

    public long? VoucherRefNo { get; set; }

    public long? PurchaseSalesIds { get; set; }

    public decimal? AmtPaid { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
