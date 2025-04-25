using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Models.DomainModels;

public partial class TblPurchaseDetail
{
    public long PdetailsId { get; set; }

    public long? PurchaseId { get; set; }

    public long? ProductId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Weight { get; set; }

    public string? Unit { get; set; }

    public decimal? Karat { get; set; }

    public decimal? KRate { get; set; }

    public decimal? Melting { get; set; }

    public decimal? PurchaseMelting { get; set; }

    public decimal? Making { get; set; }

    public decimal? Fine { get; set; }

    public decimal? Rate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TblItemMaster? Product { get; set; }

    public virtual TblPurchaseMaster? Purchase { get; set; }
}
