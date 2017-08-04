using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Timesheets.Helpers;
using Timesheets.Models;
namespace Timesheets
{
    public partial class fmMain : Form
    {
        int accessLevel;
        int branch;
        string userName;
        string noteText;
        decimal totalHoursForWeek = 0.0M;
        public fmMain()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            t.Abort();
        }
        public void SplashStart()
        {
            Application.Run(new fmSplash());
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wPCompanyDataSet.vw_TimelineItems' table. You can move, or remove it, as needed.
            fmLogin fLogin = new fmLogin();
            DialogResult = fLogin.ShowDialog();
            lblWeekEnding.Text = CommonProcs.GetWeekEnding(DateTime.Now).ToShortDateString();
            userName = MyConfig.ReadValue("firstName") + " " + MyConfig.ReadValue("lastName");
            accessLevel = int.Parse(MyConfig.ReadValue("accessLevel"));
            branch = int.Parse(MyConfig.ReadValue("branch"));
            Text = "Timesheet Entry v." + Application.ProductVersion.ToString();
            lblStatus.Text = "Current user: " + userName + "  Current Branch: " + branch;
            LoadMainCombos();
            LoadBranchCombos();
            cbCompany.SelectedIndex = 0;
            FillGridView();
        }

        private void dtpWeekEnding_ValueChanged(object sender, EventArgs e)
        {
            lblWeekEnding.Text = CommonProcs.GetWeekEnding(dtpWeekEnding.Value).ToShortDateString();
        }

        private void LoadMainCombos()
        {
            string companyStr = GetCurrentCompany();
            cbBranch.SelectedIndex = branch + 1;
            cbEmployee.DataSource = SelectListHelper.GetEmployeeList(companyStr);
            cbEmployee.DisplayMember = "key";
            cbEmployee.ValueMember = "value";
        }

        private string GetCurrentCompany()
        {
            switch (cbCompany.SelectedIndex)
            {
                case 0:
                    return "W";
                case 1:
                    return "K";
                default:
                    return "W";
            }
        }

        private string GetCurrentBranch()
        {
            switch (cbBranch.SelectedIndex)
            {
                case 0:
                    return "AA";
                case 1:
                    return "00";
                case 2:
                    return "01";
                case 3:
                    return "02";
                default:
                    return "AA";
            }
        }

        private void LoadBranchCombos()
        {
            string companyStr = GetCurrentCompany();
            string branchStr = GetCurrentBranch();

            LoadCustomerCombo(companyStr,branchStr);
            LoadPayrollItemCombo(companyStr, branchStr);
            LoadClassCombo(companyStr, branchStr);
        }

        private void LoadPayrollItemCombo(string companyStr,string branchStr)
        {
            cbPayrollItem.DataSource = SelectListHelper.GetPayrollItemList(companyStr, branchStr);
            cbPayrollItem.DisplayMember = "key";
            cbPayrollItem.ValueMember = "value";
        }

        private void LoadCustomerCombo(string companyStr, string branchStr)
        {
            cbCustomer.DataSource = SelectListHelper.GetCustomerList(companyStr, branchStr);
            cbCustomer.DisplayMember = "key";
            cbCustomer.ValueMember = "value";
        }

        private void LoadClassCombo(string companyStr, string branchStr)
        {
            cbClassEquip.DataSource = SelectListHelper.GetClassCombo(companyStr, branchStr);
            cbClassEquip.DisplayMember = "key";
            cbClassEquip.ValueMember = "value";
        }

        private void refreshEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QBDataPump pump = new QBDataPump();
            pump.PumpEmployees(GetCurrentCompany());
        }

        private void refreshCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QBDataPump pump = new QBDataPump();
            pump.PumpCustomers(GetCurrentCompany());
        }

        private void refreshPayrollItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QBDataPump pump = new QBDataPump();
            pump.PumpPayrollItems(GetCurrentCompany());
        }

        private void refreshClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QBDataPump pump = new QBDataPump();
            pump.PumpClass(GetCurrentCompany());
        }

        private void btnAddHours_Click(object sender, EventArgs e)
        {
            TimeSheet ts = new TimeSheet();
            ts.EmployeeID = int.Parse(cbEmployee.SelectedValue.ToString());
            ts.CustomerID = int.Parse(cbCustomer.SelectedValue.ToString());
            ts.ClassID = int.Parse(cbClassEquip.SelectedValue.ToString());
            ts.PayrollItemID = int.Parse(cbPayrollItem.SelectedValue.ToString());

            decimal hours = decimal.Parse(tbHours.Text);
            totalHoursForWeek += hours;

            ts.RegHours = CalcRegularHours(hours);
            ts.OTHours = CalcOTHours(hours);
            if (ts.OTHours < 0)
            {
                return;
            }
            ts.Date = dtpDateWorked.Value;
            ts.WeekEnding = dtpWeekEnding.Value;
            ts.Notes = noteText;
            ts.Approved = false;
            ts.TimesheetID = new ModelToSQL<TimeSheet>().WriteInsertSQL("Timesheet", ts, "TimesheetID", CommonProcs.WCompanyConnStr);
            FillGridView();
        }

        private void FillGridView()
        {
            vw_TimelineItemsTableAdapter.Fill(wPCompanyDataSet.vw_TimelineItems, int.Parse(cbEmployee.SelectedValue.ToString()));
            gvTimesheet.DataSource = vw_TimelineItemsTableAdapter;
            gvTimesheet.Refresh();
        }

        private decimal CalcOTHours(decimal hours)
        {
            if (rbOver8.Checked)
            {
                if (hours >= 8.0M)
                    return hours - 8.0M;
                else
                    return 0.0M;
            }
            else if (rb410.Checked)
            {
                if (hours >= 10.0M)
                    return hours - 10.0M;
                else
                    return 10.0M;
            }

            else if (rbOver40.Checked)
            {
                if (totalHoursForWeek >= 40)
                    return hours;
                else
                    return 0;
            }
            else
            {
                MessageBox.Show("Please select OT when worked option");
                return -1;
            }
        }

        private decimal CalcRegularHours(decimal hours)
        {
            if (rbOver8.Checked)
                return 8.0M;
            else if (rb410.Checked)
                return 10.0M;
            else
                return hours;
        }

        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBranchCombos();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            fmNote fNote = new fmNote();
            fNote.ShowDialog();
            if (fNote.noteText != string.Empty)
                noteText = fNote.noteText;
        }
    }
}
