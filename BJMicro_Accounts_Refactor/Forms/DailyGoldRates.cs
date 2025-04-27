using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BJMicro_Accounts_Refactor.App_Code;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Core.Services;
using BJMicro_Accounts_Refactor.Core.Services.Interfaces;
using BJMicro_Accounts_Refactor.Domain.Entities;
using BJMicro_Accounts_Refactor.Helper;
using Microsoft.Data.SqlClient;

namespace BJMicro_Accounts_Refactor.Forms
{
    public partial class DailyGoldRates : Form
    {

        private readonly HttpClient _httpClient;
        private readonly string _dailyRatesUrl;
        private string userName;
        private int passedId, types;


        public DailyGoldRates(string loginName, int id, int type, HttpClient httpClient)
        {
            InitializeComponent();
            userName = loginName;
            passedId = id;
            types = type;
            _httpClient = httpClient;
            _dailyRatesUrl = AppConfig.GetModuleUrl("dailyrates");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (types == 0)
            {
                MainDashboard mm = new MainDashboard(userName, _httpClient);
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

                var newRate = CreateDailyRateFromInputs();

                if (passedId == 0)
                {
                    var todaysDate = DateTime.Now.Date;

                    var response = await _httpClient.GetAsync($"{_dailyRatesUrl}/date/{todaysDate:yyyy-MM-dd}");

                    if (response.IsSuccessStatusCode)
                    {
                        var existingRate = await response.Content.ReadFromJsonAsync<DailyRateDto>();

                        if (existingRate == null)
                        {
                            // Create new daily rate
                            var createResponse = await _httpClient.PostAsJsonAsync(_dailyRatesUrl, newRate);
                            if (createResponse.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Record Successfully Added!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add record.");
                            }
                        }
                        else
                        {
                            // Ask for confirmation before updating today's rate
                            var result = MessageBox.Show(
                                "Are you sure you want to update today's Rates?",
                                "Update Confirmation",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                // Populate the `existingRate` DTO using the inputs
                                var updateDto = CreateUpdateDailyRateDto(existingRate.Id);

                                var updateResponse = await _httpClient.PutAsJsonAsync(_dailyRatesUrl, existingRate);
                                if (updateResponse.IsSuccessStatusCode)
                                {
                                    MessageBox.Show("Record Successfully Updated!");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update record.");
                                }

                            }
                        }
                    }
                }
                else // Updating an existing record by ID
                {
                    // Create update DTO with passed ID
                    var updateDto = CreateUpdateDailyRateDto(passedId);

                    // Use PutAsJsonAsync for updates
                    var updateResponse = await _httpClient.PutAsJsonAsync(_dailyRatesUrl, updateDto);
                    if (updateResponse.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Record Successfully Updated!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update record.");
                    }

                }
                clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private CreateDailyRateDto CreateDailyRateFromInputs()
        {
            return new CreateDailyRateDto
            (
                Convert.ToDecimal(txtFineGold.Text),
                Convert.ToDecimal(txtHallMark.Text),
                Convert.ToDecimal(txtBuyBack.Text),
                Convert.ToDecimal(txt22c.Text),
                Convert.ToDecimal(txt23c.Text),
                Convert.ToDecimal(txt18c.Text),
                Convert.ToDecimal(txtSilver.Text)
            );
        }

        private UpdateDailyRateDto CreateUpdateDailyRateDto(long id)
        {
            return new UpdateDailyRateDto(
                id,
                Convert.ToDecimal(txtFineGold.Text),
                Convert.ToDecimal(txtHallMark.Text),
                Convert.ToDecimal(txtBuyBack.Text),
                Convert.ToDecimal(txt22c.Text),
                Convert.ToDecimal(txt23c.Text),
                Convert.ToDecimal(txt18c.Text),
                Convert.ToDecimal(txtSilver.Text)
            );
        }

        private async void DailyRates_Load(object sender, EventArgs e)
        {
            try
            {

                DailyRateDto? result;

                // If passedId > 0, get the record by passedId, else get today's record
                if (passedId > 0)
                {
                    var response = await _httpClient.GetAsync($"{_dailyRatesUrl}/id/{passedId}");

                    if (response.IsSuccessStatusCode)
                    {
                        result = await response.Content.ReadFromJsonAsync<DailyRateDto>();
                    }
                    else
                    {
                        result = null;
                        MessageBox.Show("Failed to fetch record.");
                    }


                }
                else
                {
                    var todayDate = DateTime.Now.Date;

                    var response = await _httpClient.GetAsync($"{_dailyRatesUrl}/date/{todayDate:yyyy-MM-dd}");

                    if (response.IsSuccessStatusCode)
                    {
                        result = await response.Content.ReadFromJsonAsync<DailyRateDto>();
                    }
                    else
                    {
                        result = null;
                        MessageBox.Show("Failed to fetch today's rates.");
                    }
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
