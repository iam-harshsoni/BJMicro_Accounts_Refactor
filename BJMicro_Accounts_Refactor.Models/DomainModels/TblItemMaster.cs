using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Models.DomainModels;

public partial class TblItemMaster
{
    public long Id { get; set; }

    public string? ItemCode { get; set; }

    public long? CategoryId { get; set; }

    public byte[]? Photo { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual TblCategoryMaster? Category { get; set; }

    public virtual ICollection<TblPurchaseDetail> TblPurchaseDetails { get; set; } = new List<TblPurchaseDetail>();

    public virtual ICollection<TblSalesDetail> TblSalesDetails { get; set; } = new List<TblSalesDetail>();

    public virtual ICollection<TblStockItemDetail> TblStockItemDetails { get; set; } = new List<TblStockItemDetail>();
}
