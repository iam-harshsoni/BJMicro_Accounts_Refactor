using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJMicro_Accounts_Refactor.ViewModels;

public class TaxMasterVM
{
    public long tId { get; set; }
    public string voucherType { get; set; }
    public Nullable<long> voucherId { get; set; }
    public Nullable<decimal> totalTax { get; set; }
    public Nullable<System.DateTime> cDate { get; set; }
    public Nullable<System.DateTime> uDate { get; set; }
}

