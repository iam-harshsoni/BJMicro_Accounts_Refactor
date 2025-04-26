using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJMicro_Accounts_Refactor.ViewModels;

public class AccGroupVM
{
    public long rowNo { get; set; }

    public long groupId { get; set; }
    public long? parentId { get; set; }
    public string ParentGroupName { get; set; }
    public string groupName { get; set; }
    public string createdDate { get; set; }
    public string updateDate { get; set; }

}
