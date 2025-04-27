using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private readonly IDailyRateService _dailyRateService;
        AmtFormatting amtFormat = new AmtFormatting();
        string passedUname;


        public DashBoard(string uName, IDailyRateService dailyRateService)
        {
            InitializeComponent();
            passedUname = uName;
            _dailyRateService = dailyRateService;
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

            var todaysRate = await _dailyRateService.GetByDateAsync(todayDate);

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
        private async Task BindGrid(IEnumerable<DailyRateDto> rates = null)
        {
            try
            {
                dgDailyRateReport.AutoGenerateColumns = false;

                if (rates == null)
                {
                    rates = await _dailyRateService.GetAllAsync();

                    rates = rates.OrderByDescending(x => x.Id).Take(8).ToList();

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

                var filteredRates = await _dailyRateService.GetRatesByDateRange(fromDate, toDate);

                await BindGrid(filteredRates);
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
            DailyGoldRates dr = new DailyGoldRates(passedUname, 0, 1, _dailyRateService);
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

                    DailyGoldRates acc = new DailyGoldRates(passedUname, lID, 1, _dailyRateService);
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
