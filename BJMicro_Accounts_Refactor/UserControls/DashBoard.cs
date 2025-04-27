using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BJMicro_Accounts_Refactor.Core.AccoutsModuleClasses;
using BJMicro_Accounts_Refactor.Core.DTOs;
using BJMicro_Accounts_Refactor.Core.Services.Interfaces;
using BJMicro_Accounts_Refactor.Domain.Entities;
using BJMicro_Accounts_Refactor.Forms;
using BJMicro_Accounts_Refactor.ViewModels;

namespace BJMicro_Accounts_Refactor.UserControls
{
    public partial class DashBoard : UserControl
    {
        private readonly HttpClient _httpClient;
        AmtFormatting amtFormat = new AmtFormatting();
        string passedUname;
        private const string ApiBaseUrl = "https://localhost:7039/api/dailyrates"; // Replace with your API URL
        private readonly string _dailyRatesUrl;

        public DashBoard(string uName, HttpClient httpClient)
        {
            InitializeComponent();
            passedUname = uName;
            _httpClient = httpClient;
            _dailyRatesUrl = AppConfig.GetModuleUrl("dailyrates");
        }

        private async void DashBoard_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeDatePickers();
                await BindDailyRates();
                await BindGrid();
            }
            catch (Exception x)
            {

            }
        }

        private void InitializeDatePickers()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
        }

        private async Task BindDailyRates()
        {
            DateTime todayDate = DateTime.Today;

            //var todaysRate = await _dailyRateService.GetByDateAsync(todayDate);
            var response = await _httpClient.GetAsync($"{_dailyRatesUrl}/date/{todayDate:yyyy-MM-dd}");

            if (response.IsSuccessStatusCode)
            {
                var todaysRate = await response.Content.ReadFromJsonAsync<DailyRateDto>();

                if (todaysRate == null)
                {
                    btnEnterRates.Enabled = true;
                }
                else
                {
                    btnEnterRates.Enabled = false;

                    lblFine.Text = amtFormat.comma(todaysRate.FineGold);
                    lbl22C.Text = amtFormat.comma(todaysRate.TwentyTwoC);
                    lbl23C.Text = amtFormat.comma(todaysRate.TwentyThreeC);
                    lblhallMarkBuyBack.Text = amtFormat.comma(todaysRate.HallmarkBuyBack);
                    lblHallMark.Text = amtFormat.comma(todaysRate.Hallmark);
                    lblSilver.Text = amtFormat.comma(todaysRate.Silver);

                }
            }
            else
            {
                btnEnterRates.Enabled = true;
                MessageBox.Show("Failed to fetch today's rates.");
            }

        }
        private async Task BindGrid(IEnumerable<DailyRateDto> rates = null)
        {
            try
            {
                dgDailyRateReport.AutoGenerateColumns = false;

                if (rates == null)
                {
                    var response = await _httpClient.GetAsync(_dailyRatesUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        //rates = await _dailyRateService.GetAllAsync();

                        rates = await response.Content.ReadFromJsonAsync<IEnumerable<DailyRateDto>>();

                        rates = rates.OrderByDescending(x => x.Id).Take(8).ToList();
                    }

                }

                var modelList = rates.Select((item, index) => new DailyRateVM
                {
                    id = item.Id,
                    rowNo = index + 1,
                    date = item.Date?.ToString("dd-MM-yyyy") ?? string.Empty,
                    fineGold = item.FineGold ?? 0,
                    twentyTwoC = item.TwentyTwoC ?? 0,
                    twentyThreeC = item.TwentyThreeC ?? 0,
                    silver = item.Silver ?? 0,
                    hallmark = item.Hallmark ?? 0,
                    hallmarkBuyBack = item.HallmarkBuyBack ?? 0,

                    // Formatted
                    fineGoldFormatted = amtFormat.comma(item.FineGold ?? 0),
                    twentyTwoCFormatted = amtFormat.comma(item.TwentyTwoC ?? 0),
                    twentyThreeCFormatted = amtFormat.comma(item.TwentyThreeC ?? 0),
                    silverFormatted = amtFormat.comma(item.Silver ?? 0),
                    hallmarkFormatted = amtFormat.comma(item.Hallmark ?? 0),
                    hallmarkBuyBackFormatted = amtFormat.comma(item.HallmarkBuyBack ?? 0)

                }).ToList();

                dgDailyRateReport.DataSource = modelList;
            }
            catch (Exception x)
            {
                MessageBox.Show($"Error binding grid: {x.Message}");
            }
        }

        private void dgPurchaseReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = DateTime.ParseExact(dateTimePicker1.Text, "dd-MM-yyyy", null);
                DateTime toDate = DateTime.ParseExact(dateTimePicker2.Text, "dd-MM-yyyy", null);

                if (fromDate > toDate)
                {
                    MessageBox.Show("Invalid date range. Please select valid dates.");
                    return;
                }

                //Fetching data in json as per the arguments
                var response = await _httpClient.GetAsync($"{_dailyRatesUrl}/range?fromDate={fromDate:yyyy-MM-dd}&toDate={toDate:yyyy-MM-dd}");

                if (response.IsSuccessStatusCode)
                {
                    // Converting / Serializing data from Json to multiple DTO Objects using IEnumerable as its a list of objects.
                    var filteredRates = await response.Content.ReadFromJsonAsync<IEnumerable<DailyRateDto>>();
                    await BindGrid(filteredRates);
                }


            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid date format entered.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering data: {ex.Message}");
            }
        }

        private async void btnEnterRates_Click(object sender, EventArgs e)
        {
            DailyGoldRates dr = new DailyGoldRates(passedUname, 0, 1, _httpClient);

            dr.ShowDialog();
            await BindGrid();
        }

        private async void btnClear_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.Date.ToString();
            dateTimePicker2.Text = DateTime.Now.Date.ToString();
            await BindGrid();
        }

        private async void dgDailyRateReport_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgDailyRateReport.CurrentRow.Index != -1 && dgDailyRateReport.CurrentRow.Cells[1].Value != null)
                {
                    var lID = Convert.ToInt32(dgDailyRateReport.CurrentRow.Cells[0].Value);

                    DailyGoldRates acc = new DailyGoldRates(passedUname, lID, 1, _httpClient);
                    acc.ShowDialog();
                    await BindGrid();
                }
            }
            catch (Exception x)
            {

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
