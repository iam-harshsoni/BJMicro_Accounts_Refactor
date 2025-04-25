using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJMicro_Accounts_Refactor.UserControls
{
    public partial class Payment : UserControl
    {
        private int passedVoucherType = 0;
        public Payment(int voucherType)
        {
            InitializeComponent();
            this.passedVoucherType = voucherType;
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
