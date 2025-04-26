using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Domain.Entities;

public partial class TblStockItemDetail
{
    public long Id { get; set; }

    public long? ItemId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Weight { get; set; }

    public string? Unit { get; set; }

    public decimal? Melting { get; set; }

    public decimal? Carret { get; set; }

    public string? Remarks { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpadtedDate { get; set; }

    public virtual TblItemMaster? Item { get; set; }
}
