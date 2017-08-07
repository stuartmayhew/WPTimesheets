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
        bool showActive = false;
        bool showActiveCust = false;
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
            isLoading = true;
            fmLogin fLogin = new fmLogin();
            DialogResult = fLogin.ShowDialog();
            lblWeekEnding.Text = CommonProcs.GetWeekEnding(DateTime.Now).ToShortDateString();
            dtpWeekEnding.Value = CommonProcs.GetWeekEnding(DateTime.Now);
            userName = MyConfig.ReadValue("firstName") + " " + MyConfig.ReadValue("lastName");
            accessLevel = int.Parse(MyConfig.ReadValue("accessLevel"));
            branch = int.Parse(MyConfig.ReadValue("branch"));
            Text = "Timesheet Entry";
            lblStatus.Text = "Current user: " + userName + "  Current Branch: " + branch;
            cbBranch.SelectedIndex = branch + 1;

            LoadBranchCombos();

            isLoading = false;
            cbCompany.SelectedIndex = 0;
            FillGridView();
        }

        private void dtpWeekEnding_ValueChanged(object sender, EventArgs e)
        {
            lblWeekEnding.Text = CommonProcs.GetWeekEnding(dtpWeekEnding.Value).ToShortDateString();
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
            LoadEmployeeCombo(companyStr, branchStr, showActive);
            LoadCustomerCombo(companyStr,branchStr,showActiveCust);
            LoadPayrollItemCombo(companyStr, branchStr);
            LoadClassCombo(companyStr, branchStr);
            List<int> facIDs = LoadFacilityCombo(branchStr);
            LoadAreaCombo(facIDs);
        }

        private void LoadAreaCombo(List<int> facIDs)
        {
            cbArea.DataSource = SelectListHelper.GetAreaList(facIDs);
            cbArea.DisplayMember = "key";
            cbArea.ValueMember = "value";
        }

        private List<int> LoadFacilityCombo(string branchStr)
        {
            cbFac.DataSource = SelectListHelper.GetFacilityList(branchStr);
            cbFac.DisplayMember = "key";
            cbFac.ValueMember = "value";
            return CommonProcs.GetFacList(branchStr);
        }

        private void LoadPayrollItemCombo(string companyStr,string branchStr)
        {
            cbPayrollItem.DataSource = SelectListHelper.GetPayrollItemList(companyStr, branchStr);
            cbPayrollItem.DisplayMember = "key";
            cbPayrollItem.ValueMember = "value";
        }

        private void LoadCustomerCombo(string companyStr, string branchStr,bool showActive)
        {
            cbCustomer.DataSource = SelectListHelper.GetCustomerList(companyStr, branchStr, showActive);
            cbCustomer.DisplayMember = "key";
            cbCustomer.ValueMember = "value";
        }

        private void LoadClassCombo(string companyStr, string branchStr)
        {
            cbClassEquip.DataSource = SelectListHelper.GetClassCombo(companyStr, branchStr);
            cbClassEquip.DisplayMember = "key";
            cbClassEquip.ValueMember = "value";
        }
        private void LoadEmployeeCombo(string companyStr,string branchStr,bool showActive = false)
        {
            cbEmployee.DataSource = SelectListHelper.GetEmployeeList(companyStr,branchStr,showActive);
            cbEmployee.DisplayMember = "key";
            cbEmployee.ValueMember = "value";
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
            ts.FacID = int.Parse(cbFac.SelectedValue.ToString());
            ts.AreaID = int.Parse(cbArea.SelectedValue.ToString());
            ts.Notes = noteText;
            ts.SupApprove = false;
            ts.OMApprove = false;
            ts.HOApprove = false;
            ts.TimesheetID = new ModelToSQL<TimeSheet>().WriteInsertSQL("Timesheet", ts, "TimesheetID", CommonProcs.WCompanyConnStr);
            FillGridView();
            LoadAreaCombo(CommonProcs.GetFacList(GetCurrentBranch()));
            dtpDateWorked.Value = dtpDateWorked.Value.AddDays(1);
            dtpDateWorked.Focus();
        }

        private void FillGridView()
        {
            string sql = "SELECT TimesheetID AS ID,Customer,Facility,Area,";
            sql += "ClassEquip,PayrollItem,WorkDate,";
            sql += "WorkDay,RegHours,OTHours,Notes ";
            sql += "FROM TimesheetEntryGrid WHERE EmployeeID = " + cbEmployee.SelectedValue;
            List<TimesheetEntryGrid> gridRows = new ReaderToModel<TimesheetEntryGrid>().CreateList(sql,CommonProcs.WCompanyConnStr);
            gvTimesheet.DataSource = gridRows;
        }

        private void FillTotalsView()
        {
            gvRecap.Columns.Clear();
            string sql = "SELECT EmployeeID,EmpName,WeekEnding,RegHours,OTHours ";
            sql += "FROM TimesheetTotals WHERE WeekEnding = '" + dtpWeekEnding.Value.ToShortDateString() + "'";
            List<TimesheetTotals> totals = new ReaderToModel<TimesheetTotals>().CreateList(sql, CommonProcs.WCompanyConnStr);
            foreach (var tot in totals)
            {
                if (CheckApproved(tot,"SUP"))
                    tot.SupApproved = true;
                if (CheckApproved(tot, "OM"))
                    tot.OMApproved = true;
                if (CheckApproved(tot, "HO"))
                    tot.HOApproved = true;

            }
            gvRecap.DataSource = totals;

            DataGridViewButtonColumn sAppColumn = new DataGridViewButtonColumn();
            sAppColumn.HeaderText = "Super Appr";
            sAppColumn.Name = "approve";
            sAppColumn.Text = "Approve";
            sAppColumn.UseColumnTextForButtonValue = true;
            gvRecap.Columns.Add(sAppColumn);

            DataGridViewButtonColumn omAppColumn = new DataGridViewButtonColumn();
            omAppColumn.HeaderText = "Off Mgr Appr";
            omAppColumn.Name = "approve";
            omAppColumn.Text = "Approve";
            omAppColumn.UseColumnTextForButtonValue = true;
            gvRecap.Columns.Add(omAppColumn);

            DataGridViewButtonColumn hoAppColumn = new DataGridViewButtonColumn();
            hoAppColumn.HeaderText = "Home Office Appr";
            hoAppColumn.Name = "approve";
            hoAppColumn.Text = "Approve";
            hoAppColumn.UseColumnTextForButtonValue = true;
            gvRecap.Columns.Add(hoAppColumn);

            DataGridViewButtonColumn viewColumn = new DataGridViewButtonColumn();
            viewColumn.HeaderText = "View";
            viewColumn.Text = "Timesheet";
            viewColumn.Name = "view";
            gvRecap.Columns.Add(viewColumn);
            viewColumn.UseColumnTextForButtonValue = true;
        }

        private bool CheckApproved(TimesheetTotals tot, string type)
        {
            int empID = tot.EmployeeID;
            string sql = "SELECT * FROM Timesheet WHERE EmployeeID = " + empID;
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                switch (type)
                {
                    case "SUP":
                        sql += " AND SupApprove = 0";
                        break;
                    case "OM":
                        sql += " AND OMApprove = 0";
                        break;
                    case "HO":
                        sql += " AND HOApprove = 0";
                        break;
                }
                if (dg.HasData(sql))
                    return false;
                else
                    return true;
            }
        }

        private void gvRecap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (CommonProcs.CheckAccessLevel() < 5)
                {
                    MessageBox.Show("Not Authorized to approve Timesheet");
                    return;
                }
                    
                ApproveBySuper(e);
                FillTotalsView();
            }
            else if (e.ColumnIndex == 9)
            {
                if (CommonProcs.CheckAccessLevel() < 5)
                {
                    MessageBox.Show("Not Authorized to approve Timesheet");
                    return;
                }
                ApproveByOM(e);
                FillTotalsView();
            }
            else if (e.ColumnIndex == 10)
            {
                if (CommonProcs.CheckAccessLevel() < 5)
                {
                    MessageBox.Show("Not Authorized to approve Timesheet");
                    return;
                }
                ApproveByHO(e);
                FillTotalsView();
            }
            else if (e.ColumnIndex == 11)
                ShowTimesheet();
        }

        private void ShowTimesheet()
        {
            fmTimesheetView fTV = new fmTimesheetView();
            fTV.Show();
        }

        private void ApproveByHO(DataGridViewCellEventArgs e)
        {
            string empId = gvRecap.Rows[e.RowIndex].Cells[0].Value.ToString();
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                string sql = "UPDATE Timesheet SET HOApprove = 1 WHERE EmployeeID = " + empId;
                dg.RunCommand(sql);
            }
        }

        private void ApproveByOM(DataGridViewCellEventArgs e)
        {
            string empId = gvRecap.Rows[e.RowIndex].Cells[0].Value.ToString();
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                string sql = "UPDATE Timesheet SET OMApprove = 1 WHERE EmployeeID = " + empId;
                dg.RunCommand(sql);
            }
        }

        private void ApproveBySuper(DataGridViewCellEventArgs e)
        {
            string empId = gvRecap.Rows[e.RowIndex].Cells[0].Value.ToString();
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                string sql = "UPDATE Timesheet SET SupApprove = 1 WHERE EmployeeID = " + empId;
                dg.RunCommand(sql);
            }

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

        private void btnShowActive_Click(object sender, EventArgs e)
        {
            if (showActive)
            {
                btnShowActive.Text = "Show Active";
                LoadEmployeeCombo(GetCurrentCompany(), GetCurrentBranch(), false);
                showActive = false;
            }
            else
            {
                btnShowActive.Text = "Show All";
                LoadEmployeeCombo(GetCurrentCompany(), GetCurrentBranch(), true);
                showActive = true;
            }
        }

        private void btnShowActiveCust_Click(object sender, EventArgs e)
        {
            if (showActiveCust)
            {
                btnShowActiveCust.Text = "Show Active";
                LoadCustomerCombo(GetCurrentCompany(), GetCurrentBranch(), false);
                showActiveCust = false;
            }
            else
            {
                btnShowActiveCust.Text = "Show All";
                LoadCustomerCombo(GetCurrentCompany(), GetCurrentBranch(), true);
                showActiveCust = true;
            }
        }

        private void tbTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbTabs.SelectedIndex == 1)
                FillTotalsView();
        }

        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
                LoadBranchCombos();
        }

        private void btnAppRequest_Click(object sender, EventArgs e)
        {
            fmRequestApproval rmReq = new fmRequestApproval();
            rmReq.Show();
        }

        private void cbFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                int selFac = int.Parse(cbFac.SelectedValue.ToString());
                List<int> facID = new List<int>();
                facID.Add(selFac);
                LoadAreaCombo(facID);
            }
        }

        private void setupFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmFacility fFac = new fmFacility();
            fFac.ShowDialog();
            LoadFacilityCombo(GetCurrentBranch());
        }

        private void setupAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmArea fArea = new fmArea();
            fArea.ShowDialog();
            LoadAreaCombo(CommonProcs.GetFacList(GetCurrentBranch()));
        }

        private void setupLoginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CommonProcs.CheckAccessLevel() < 10)
            {
                MessageBox.Show("Not Authorized to View/Edit logins");
                return;
            }

            fmLoginEdit fLogEdit = new fmLoginEdit();
            fLogEdit.ShowDialog();
        }

        private void Combo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            string searchStr = box.Text;
            var autoComplete = new AutoCompleteStringCollection();
            ComboBox.ObjectCollection items = box.Items;
            foreach(ComboBoxItem item in items)
            {
                if (item.key.Contains(searchStr))
                    autoComplete.Add(item.key);

            }
        }
    }
}
