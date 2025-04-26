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
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Core.Services.Interfaces;
using BJMicro_Accounts_Refactor.Domain.Entities;
using BJMicro_Accounts_Refactor.Helper;
using Microsoft.Data.SqlClient;

namespace BJMicro_Accounts_Refactor.Forms
{
    public partial class DailyRates : Form
    {
        string userName;

        private readonly IDailyRateService _dailyRateService;

        int passedId, types;
        public DailyRates(string loginName,
            int id,
            int type,
            IDailyRateService dailyRateService)
        {
            InitializeComponent();

            userName = loginName;
            passedId = id;
            types = type;

            _dailyRateService = dailyRateService;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (types == 0)
            {
                MainDashboard mm = new MainDashboard(userName);
                mm.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void txt999_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtHallMark.Focus();
            }

        }

        private void txt999_FontChanged(object sender, EventArgs e)
        {

        }

        private void txt999_Enter(object sender, EventArgs e)
        {
            SidePanel2.Height = txtFineGold.Height;
            SidePanel2.Top = txtFineGold.Top;
        }

        private void txtHallMark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBuyBack.Focus();
            }
        }

        private void txtHallMark_Enter(object sender, EventArgs e)
        {

            SidePanel2.Height = txtHallMark.Height;
            SidePanel2.Top = txtHallMark.Top;
        }

        private void txtBuyBack_Enter(object sender, EventArgs e)
        {
            SidePanel2.Height = txtBuyBack.Height;
            SidePanel2.Top = txtBuyBack.Top;
        }

        private void txtBuyBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt22c.Focus();
            }
        }

        private void txt22c_Enter(object sender, EventArgs e)
        {
            SidePanel2.Height = txt22c.Height;
            SidePanel2.Top = txt22c.Top;
        }

        private void txt22c_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt23c.Focus();
            }
        }

        private void txt23c_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt18c.Focus();
            }
        }

        private void txt23c_Enter(object sender, EventArgs e)
        {
            SidePanel2.Height = txt23c.Height;
            SidePanel2.Top = txt23c.Top;
        }

        private void txtSilver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreate.Focus();
            }
        }

        private void txtSilver_Enter(object sender, EventArgs e)
        {
            SidePanel2.Height = txtSilver.Height;
            SidePanel2.Top = txtSilver.Top;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            btnCreate.Text = "Create";
            txtSilver.Text = "";
            txtHallMark.Text = "";
            txt22c.Text = "";
            txt23c.Text = "";
            txtFineGold.Text = "";
            txtBuyBack.Text = "";
            txt18c.Text = "";
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FormValidationHelper.ValidateRequiredField(txtFineGold, errorProvider1, lblError, panel3, "Enter item code.")) return;
                if (!FormValidationHelper.ValidateRequiredField(txtHallMark, errorProvider1, lblError, panel3, "Enter item code.")) return;
                if (!FormValidationHelper.ValidateRequiredField(txtBuyBack, errorProvider1, lblError, panel3, "Enter item code.")) return;
                if (!FormValidationHelper.ValidateRequiredField(txt22c, errorProvider1, lblError, panel3, "Enter item code.")) return;
                if (!FormValidationHelper.ValidateRequiredField(txt23c, errorProvider1, lblError, panel3, "Enter item code.")) return;
                if (!FormValidationHelper.ValidateRequiredField(txt18c, errorProvider1, lblError, panel3, "Enter item code.")) return;
                if (!FormValidationHelper.ValidateRequiredField(txtSilver, errorProvider1, lblError, panel3, "Enter item code.")) return;

                if (passedId == 0)
                {
                    var todaysDate = DateTime.Now.Date;

                    var existingRate = await _dailyRateService.GetByDateAsync(todaysDate);

                    if (existingRate == null)
                    {
                        await _dailyRateService.AddAsync(CreateDailyRateFromInputs());
                        MessageBox.Show("Record Successfully Added!");
                    }
                    else
                    {
                        var result = MessageBox.Show("Are you sure you want to update today's Rates?", "Update Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            // Populate the `existingRate` DTO using the inputs
                            UpdateDailyRateFromInputs(existingRate);

                            // Now pass the populated `existingRate` DTO to the service method
                            await _dailyRateService.UpdateAsync(existingRate);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private DailyRateDto CreateDailyRateFromInputs()
        {
            return new DailyRateDto
            {
                FineGold = Convert.ToDecimal(txtFineGold.Text),
                Hallmark = Convert.ToDecimal(txtHallMark.Text),
                HallmarkBuyBack = Convert.ToDecimal(txtBuyBack.Text),
                TwentyTwoC = Convert.ToDecimal(txt22c.Text),
                TwentyThreeC = Convert.ToDecimal(txt23c.Text),
                EighteenC = Convert.ToDecimal(txt18c.Text),
                Silver = Convert.ToDecimal(txtSilver.Text),
                Date = DateTime.Now.Date,
            };
        }

        private void UpdateDailyRateFromInputs(DailyRateDto? rate)
        {
            rate.FineGold = Convert.ToDecimal(txtFineGold.Text);
            rate.Hallmark = Convert.ToDecimal(txtHallMark.Text);
            rate.HallmarkBuyBack = Convert.ToDecimal(txtBuyBack.Text);
            rate.TwentyTwoC = Convert.ToDecimal(txt22c.Text);
            rate.TwentyThreeC = Convert.ToDecimal(txt23c.Text);
            rate.EighteenC = Convert.ToDecimal(txt18c.Text);
            rate.Silver = Convert.ToDecimal(txtSilver.Text);
            rate.Date = DateTime.Now.Date;
        }

        private async void DailyRates_Load(object sender, EventArgs e)
        {
            try
            {
               
                DailyRateDto result;

                // If passedId > 0, get the record by passedId, else get today's record
                if (passedId > 0)
                {
                    result = await _dailyRateService.GetByIdAsync(passedId);
                }
                else
                {
                    var datetodayss = DateTime.Now.Date;
                    result = await _dailyRateService.GetByDateAsync(datetodayss);
                }

                if (result != null)
                {
                    // Set the form data from the found record
                    btnCreate.Text = "Update";
                    txtFineGold.Text = result.FineGold.ToString();
                    txtSilver.Text = result.Silver.ToString();
                    txtHallMark.Text = result.Hallmark.ToString();
                    txt22c.Text = result.TwentyTwoC.ToString();
                    txt23c.Text = result.TwentyThreeC.ToString();
                    txtBuyBack.Text = result.HallmarkBuyBack.ToString();
                    txt18c.Text = result.EighteenC.ToString();
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception here
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void txt999_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidation val = new TextBoxValidation();
            val.onlyNumber(sender, e);
        }

        private void txtHallMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidation val = new TextBoxValidation();
            val.onlyNumber(sender, e);
        }

        private void txtBuyBack_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidation val = new TextBoxValidation();
            val.onlyNumber(sender, e);
        }

        private void txt18c_Enter(object sender, EventArgs e)
        {
            SidePanel2.Height = txt18c.Height;
            SidePanel2.Top = txt18c.Top;
        }

        private void txt18c_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSilver.Focus();
            }
        }
    }
}
