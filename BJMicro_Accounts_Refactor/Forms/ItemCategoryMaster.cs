using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BJMicro_Accounts_Refactor.App_Code;
using BJMicro_Accounts_Refactor.Domain.Entities;
using BJMicro_Accounts_Refactor.ViewModels;

namespace BJMicro_Accounts_Refactor.Forms
{
    public partial class ItemCategoryMaster : Form
    {
         
        public ItemCategoryMaster()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void clear()
        {
            txtCategoryName.Text = "";
            txtPrefix.Text = "";
            panel3.Hide();
            btnCreate.Text = "Create";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
             

        }

        private void dtCategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        void dataGridBind()
        {
            
        }

        private void ItemCategoryMaster_Load(object sender, EventArgs e)
        {
            txtCategoryName.Focus();
            dataGridBind();
        }

        private void dtCategoryList_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void txtCategoryName_Enter(object sender, EventArgs e)
        {
            SidePanel2.Height = txtCategoryName.Height;
            SidePanel2.Top = txtCategoryName.Top;
        }

        private void txtPrefix_Enter(object sender, EventArgs e)
        {
            SidePanel2.Height = txtPrefix.Height;
            SidePanel2.Top = txtPrefix.Top;
        }

        private void txtCategoryName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrefix.Focus();
            }
        }

        private void txtPrefix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreate.Focus();
            }
        }

        private void txtCategoryName_KeyUp(object sender, KeyEventArgs e)
        {
             
        }

        private void txtCategoryName_KeyPress(object sender, KeyPressEventArgs e)
        {

            TextBoxValidation val = new TextBoxValidation();

            val.textOnly(sender, e);
        }
    }
}
