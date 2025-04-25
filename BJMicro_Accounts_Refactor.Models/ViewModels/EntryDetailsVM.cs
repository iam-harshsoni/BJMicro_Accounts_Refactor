using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJMicro_Accounts_Refactor.Models.ViewModels;

public class EntryDetailsVM
{
    public long pDetailsId { get; set; }
    public Nullable<long> voucherRefNo { get; set; }
    public Nullable<long> purchaseId { get; set; }
    public Nullable<decimal> amtPaid { get; set; }
    public string createdDate { get; set; }
    public string updatedDate { get; set; }

    public virtual EntryVM tbl_Payment { get; set; }
    public virtual PurchaseMasterVM tbl_PurchaseMaster { get; set; }
}

