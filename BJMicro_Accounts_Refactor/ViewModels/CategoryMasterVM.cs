using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJMicro_Accounts_Refactor.ViewModels;
public class CategoryMasterVM
{
    public int RowNo { get; set; }
    public long CId { get; set; }
    public string? CName { get; set; }
    public string? Prefix { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
