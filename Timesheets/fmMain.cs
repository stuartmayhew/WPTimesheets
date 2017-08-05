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
        decimal totalRegTime = 0.0M;
        decimal totalOTTime = 0.0M;
        bool isLoading = false;
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
            dtpWeekEnding.Value = CommonProcs.GetWeekEnding(DateTime.Now);
            userName = MyConfig.ReadValue("firstName") + " " + MyConfig.ReadValue("lastName");
            accessLevel = int.Parse(MyConfig.ReadValue("accessLevel"));
            branch = int.Parse(MyConfig.ReadValue("branch"));
            Text = "Timesheet Entry";
            lblStatus.Text = "Current user: " + userName + "  Current Branch: " + branch;
            isLoading = true;
            LoadMainCombos();
            LoadBranchCombos();
            isLoading = false;
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
            QBDataPump pump = new QBDataPump(statusStrip1);
            pump.PumpEmployees(GetCurrentCompany());
        }

        private void refreshCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QBDataPump pump = new QBDataPump(statusStrip1);
            pump.PumpCustomers(GetCurrentCompany());
        }

        private void refreshPayrollItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QBDataPump pump = new QBDataPump(statusStrip1);
            pump.PumpPayrollItems(GetCurrentCompany());
        }

        private void refreshClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QBDataPump pump = new QBDataPump(statusStrip1);
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

            if (((ComboBoxItem)cbPayrollItem.SelectedItem).key.Contains("RG"))
            {
                ts.RegHours = hours;
                totalRegTime += hours;
            }
            if (((ComboBoxItem)cbPayrollItem.SelectedItem).key.Contains("OT"))
            {
                ts.OTHours = hours;
                totalOTTime += hours;
            }
            if (ts.OTHours < 0)
            {
                return;
            }
            ts.WorkDate = dtpDateWorked.Value;
            ts.WeekEnding = dtpWeekEnding.Value;
            ts.Notes = noteText;
            ts.Approved = false;
            ts.TimesheetID = new ModelToSQL<TimeSheet>().WriteInsertSQL("Timesheet", ts, "TimesheetID", CommonProcs.WCompanyConnStr);
            FillGridView();
            dtpDateWorked.Value = dtpDateWorked.Value.AddDays(1);
            dtpDateWorked.Focus();
        }

        private void FillGridView()
        {
            string sql = "SELECT TimesheetID AS ID,Customer,ClassEquip,PayrollItem,WorkDate,WorkDay,RegHours,OTHours,Notes ";
            sql += "FROM TimesheetEntryGrid WHERE EmployeeID = " + cbEmployee.SelectedValue;
            List<TimesheetEntryGrid> gridRows = new ReaderToModel<TimesheetEntryGrid>().CreateList(sql,CommonProcs.WCompanyConnStr);
            gvTimesheet.DataSource = gridRows;
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

        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
                FillGridView();
        }
    }
}
