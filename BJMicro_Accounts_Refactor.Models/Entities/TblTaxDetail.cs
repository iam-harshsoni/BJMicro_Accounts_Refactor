using System;
using System.Collections.Generic;

namespace BJMicro_Accounts_Refactor.Domain.Entities;

public partial class TblTaxDetail
{
    public long TaxDetailsId { get; set; }

    public long? TId { get; set; }

    public decimal? CgstPer { get; set; }

    public decimal? CgstRate { get; set; }

    public decimal? SgstPer { get; set; }

    public decimal? SgstRate { get; set; }

    public decimal? IgstPer { get; set; }

    public decimal? IgstRate { get; set; }

    public DateTime? CDate { get; set; }

    public DateTime? UDate { get; set; }

    public virtual TblTaxMaster? TIdNavigation { get; set; }
}
