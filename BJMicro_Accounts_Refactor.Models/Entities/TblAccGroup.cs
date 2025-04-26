using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Domain.Entities;

public partial class TblAccGroup
{
    public long GroupId { get; set; }

    public long? Id { get; set; }

    public long? ParentId { get; set; }

    public string? GroupName { get; set; }

    public int? AffectsGross { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<TblAccLedger> TblAccLedgers { get; set; } = new List<TblAccLedger>();
}
