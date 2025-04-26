using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Domain.Entities;

public partial class TblSalesDetail
{
    public long SDetailsId { get; set; }

    public long? SalesId { get; set; }

    public long? ProductId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Weight { get; set; }

    public string? Unit { get; set; }

    public decimal? Karat { get; set; }

    public decimal? KRate { get; set; }

    public decimal? Making { get; set; }

    public decimal? Rate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual TblItemMaster? Product { get; set; }

    public virtual TblSalesMaster? Sales { get; set; }
}
