using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Domain.Entities;

public partial class TblAccLedger
{
    public long Id { get; set; }

    public long GroupId { get; set; }

    public string? LedgerName { get; set; }

    public decimal? OpBalance { get; set; }

    public string? OpBalanceDc { get; set; }

    public int? Type { get; set; }

    public string? Notes { get; set; }

    public int? DrId { get; set; }

    public int? CrId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TblAccGroup Group { get; set; } = null!;

    public virtual ICollection<TblLedgerDetail> TblLedgerDetails { get; set; } = new List<TblLedgerDetail>();

    public virtual ICollection<TblPurchaseMaster> TblPurchaseMasters { get; set; } = new List<TblPurchaseMaster>();

    public virtual ICollection<TblSalesMaster> TblSalesMasters { get; set; } = new List<TblSalesMaster>();
}
