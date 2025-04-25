using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Models.DomainModels;

public partial class TblUserProfile
{
    public long UserId { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public decimal? Mobile { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<TblUserLogiln> TblUserLogilns { get; set; } = new List<TblUserLogiln>();
}
