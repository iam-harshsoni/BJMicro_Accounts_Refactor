using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Domain.Entities;

public partial class TblCategoryMaster
{
    public long CId { get; set; }

    public string? CName { get; set; }

    public string? Prefix { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TblItemMaster> TblItemMasters { get; set; } = new List<TblItemMaster>();
}
