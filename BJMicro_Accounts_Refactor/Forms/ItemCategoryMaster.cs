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
using BJMicro_Accounts_Refactor.Domain.Entities;
using BJMicro_Accounts_Refactor.Helper;
using BJMicro_Accounts_Refactor.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BJMicro_Accounts_Refactor.Forms
{
    public partial class ItemCategoryMaster : Form
    {
        private readonly HttpClient _httpClient;
        private readonly string _categoryUrl;
        public ItemCategoryMaster(HttpClient httpClient)
        {
            InitializeComponent();
            _httpClient = httpClient;
            _categoryUrl = AppConfig.GetModuleUrl("category");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ResetForm()
        {
            txtCategoryName.Text = "";
            txtPrefix.Text = "";
            lblHiddenId.Text = string.Empty;
            panel3.Hide();
            btnCreate.Text = "Create";
        }

        private async void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FormValidationHelper.ValidateRequiredField(txtCategoryName, errorProvider1, lblError, panel3, "Enter Category Name.")) return;
                if (!FormValidationHelper.ValidateRequiredField(txtPrefix, errorProvider1, lblError, panel3, "Enter Prefix.")) return;

                if (btnCreate.Text == "Create")
                {
                    var newCategory = CreateCategoryFromInputs();
                    var createResponse = await _httpClient.PostAsJsonAsync(_categoryUrl, newCategory);
                    if (createResponse.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Record Successfully Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                        await BindGrid();
                    }
                    else
                    {
                        var errorContent = await createResponse.Content.ReadAsStringAsync();
                        MessageBox.Show("Failed to add record: {errorContent}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var result = MessageBox.Show(
                               "Are you sure you want to update today's Rates?",
                               "Update Confirmation",
                               MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        var updateDto = CreateUpdateDailyRateDto(Convert.ToInt32(lblHiddenId.Text));
                        var updateResponse = await _httpClient.PutAsJsonAsync(_categoryUrl, updateDto);

                        if (updateResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Category successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetForm();
                            btnCreate.Text = "Create"; // Reset button text after update
                            await BindGrid();
                        }
                        else
                        {
                            var errorContent = await updateResponse.Content.ReadAsStringAsync();
                            MessageBox.Show($"Failed to update category: {errorContent}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private CreateCategoryDto CreateCategoryFromInputs()
        {
            return new CreateCategoryDto(
                txtCategoryName.Text,
                txtPrefix.Text
            );
        }

        private UpdateCategoryDto CreateUpdateDailyRateDto(long id)
        {
            return new UpdateCategoryDto(
                id,
                txtCategoryName.Text,
                txtPrefix.Text
            );
        }

        private async void dtCategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgCategoryList.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        //Delete
                        var cellId = Convert.ToInt32(dgCategoryList.CurrentRow.Cells[0].Value);

                        var response = await _httpClient.DeleteAsync($"{_categoryUrl}/id/{cellId}");
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Category deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await BindGrid();
                            // Refresh your data grid or remove the row
                        }
                        else
                        {
                            var error = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Failed to delete: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //No delete
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task BindGrid(IEnumerable<CategoryMasterDto>? categories = null)
        {
            try
            {
                dgCategoryList.AutoGenerateColumns = false;

                if (categories == null)
                {
                    var response = await _httpClient.GetAsync(_categoryUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        categories = await response.Content.ReadFromJsonAsync<IEnumerable<CategoryMasterDto>>();
                    }
                    else
                    {
                        MessageBox.Show($"Error retrieving categories: {response.ReasonPhrase}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      
                        return; // Exit if we couldn't get the data
                    }
                }

                // Add null check before working with categories
                if (categories == null)
                {
                    MessageBox.Show("No categories available");
                    return;
                }

                var modelList = categories.Select((item, index) => new CategoryMasterVM
                {
                    CId = item.CId,
                    RowNo = index + 1,
                    CName = item.CName,
                    Prefix = item.Prefix,
                    CreatedDate = item.CreatedDate,
                    UpdatedDate = item.UpdatedDate


                }).ToList();

                dgCategoryList.DataSource = modelList;

                // Update total rows if you have a label for it
                if (lblTotalRows != null)
                {
                    lblTotalRows.Text = modelList.Count.ToString();
                }

            }
            catch (Exception x)
            {
                MessageBox.Show($"Error binding grid: {x.Message}" ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void ItemCategoryMaster_Load(object sender, EventArgs e)
        {
            txtCategoryName.Focus();
            await BindGrid();
        }

        private async void dtCategoryList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgCategoryList.CurrentRow.Index != -1 && dgCategoryList.CurrentRow.Cells[0].Value != null)
                {

                    var gID = Convert.ToInt32(dgCategoryList.CurrentRow.Cells[0].Value);

                    //var data = _entities.tbl_CategoryMaster.Where(x => x.cId == gID).FirstOrDefault();

                    var response = await _httpClient.GetAsync($"{_categoryUrl}/id/{gID}");

                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadFromJsonAsync<CategoryMasterDto>();


                        if (data != null)
                        {
                            txtCategoryName.Text = lblhiddenCategoryName.Text = data.CName;
                            txtPrefix.Text = data.Prefix;
                            lblHiddenId.Text = data.CId.ToString();
                            btnCreate.Text = "Update";
                        }
                        else
                        {
                            MessageBox.Show("No data received from the server.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        }
                    }
                    else
                    {
                        btnCreate.Text = "Create";
                        MessageBox.Show("Failed to fetch today's rates.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show($"Error fetching record: {x.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private async void btnClear_Click_1(object sender, EventArgs e)
        {
            ResetForm();
            await BindGrid();
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

        private async void txtCategoryName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dgCategoryList.AutoGenerateColumns = false;
                string searchTerm = txtCategoryName.Text.Trim();

                // Make API call based on your controller's available endpoints
                // Your controller doesn't have a direct search endpoint, so we'll get all and filter client-side
                var response = await _httpClient.GetAsync(_categoryUrl);

                if (response.IsSuccessStatusCode)
                {
                    var allCategories = await response.Content.ReadFromJsonAsync<IEnumerable<CategoryMasterDto>>();

                    if (allCategories != null)
                    {
                        // If search term is provided, filter the results client-side
                        var filteredCategories = string.IsNullOrEmpty(searchTerm)
                            ? allCategories
                            : allCategories.Where(c => c.CName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();

                        // Using your existing BindGrid method with filtered results
                        var modelList = filteredCategories.Select((item, index) => new CategoryMasterVM
                        {
                            RowNo = index + 1,
                            CId = item.CId,
                            CName = item.CName,
                            Prefix = item.Prefix,
                            CreatedDate = item.CreatedDate,
                            UpdatedDate = item.UpdatedDate
                        }).ToList();

                        dgCategoryList.DataSource = modelList;

                        // Update total rows if you have a label for it
                        if (lblTotalRows != null)
                        {
                            lblTotalRows.Text = modelList.Count.ToString();
                        }
                    }
                }
                else
                {
                    // Handle API error silently to match original implementation
                    // Could log the error here if needed
                }
            }
            catch (Exception x)
            {
                MessageBox.Show($"Error fetching record: {x.Message}");
            }
        }

        private void txtCategoryName_KeyPress(object sender, KeyPressEventArgs e)
        {

            TextBoxValidation val = new TextBoxValidation();

            val.textOnly(sender, e);
        }
    }
}
