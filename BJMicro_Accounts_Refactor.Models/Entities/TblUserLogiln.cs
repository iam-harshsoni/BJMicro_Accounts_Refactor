using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Domain.Entities;

public partial class TblUserLogiln
{
    public long Id { get; set; }

    public long? UserId { get; set; }

    public string? LoginId { get; set; }

    public string? Password { get; set; }

    public DateTime? LastLogin { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<TblTransactionMaster> TblTransactionMasters { get; set; } = new List<TblTransactionMaster>();

    public virtual TblUserProfile? User { get; set; }
}
