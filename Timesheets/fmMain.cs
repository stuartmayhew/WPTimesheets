﻿using System;
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
        bool supCheckedAll = false;
        bool OMCheckedAll = false;
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
        #region Main
        private void fmMain_Load(object sender, EventArgs e)
        {
            isLoading = true;
            fmLogin fLogin = new fmLogin();
            if (!System.IO.File.Exists("user.txt"))
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
            tbTabs.TabPages[1].Enabled = CheckCompleteForRecap();
            SetAccessFromAccessLevel(accessLevel);
            FillGridView();
        }

        private void SetAccessFromAccessLevel(int accessLevel)
        {
            
        }

        private bool CheckCompleteForRecap()
        {
            DateTime weekEnding = this.dtpWeekEnding.Value;
            string sql = "SELECT * FROM Timesheet ";
            sql += " WHERE WeekEnding = '" + weekEnding.ToShortDateString() + "' ";
            sql += "AND Complete = 0";
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                if (dg.HasData(sql))
                    return false;
            }
            return true;
        }
        #endregion

        #region DateTime
        private void dtpWeekEnding_ValueChanged(object sender, EventArgs e)
        {
            lblWeekEnding.Text = CommonProcs.GetWeekEnding(dtpWeekEnding.Value).ToShortDateString();
            tbTabs.TabPages[1].Enabled = CheckCompleteForRecap();
        }

        #endregion
        #region Util
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
        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBranchCombos();
        }


        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
                FillGridView();
        }
        #endregion
        #region Combos
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
        #endregion
        #region Menu
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
        #endregion
        #region Timesheet
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
            string sql = "SELECT TimesheetID,Customer,Facility,Area,";
            sql += "ClassEquip,PayrollItem,WorkDate,";
            sql += "WorkDay,RegHours,OTHours,Notes ";
            sql += "FROM TimesheetEntryGrid WHERE EmployeeID = " + cbEmployee.SelectedValue;
            List<TimesheetEntryGrid> gridRows = new ReaderToModel<TimesheetEntryGrid>().CreateList(sql,CommonProcs.WCompanyConnStr);
            gvTimesheet.DataSource = gridRows;
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            fmNote fNote = new fmNote();
            fNote.ShowDialog();
            if (fNote.noteText != string.Empty)
                noteText = fNote.noteText;
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

        private void gvTimesheet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gvTimesheet.Columns[e.ColumnIndex].Name != "OTHours" && gvTimesheet.Columns[e.ColumnIndex].Name != "RegHours")
                return;
            string colName = gvTimesheet.Columns[e.ColumnIndex].Name;
            string newValue = gvTimesheet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            string timeSheetID = gvTimesheet.Rows[e.RowIndex].Cells[0].Value.ToString();
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                string sql = "UPDATE Timesheet SET " + colName + " = " + newValue + " WHERE TimesheetID=" + timeSheetID;
                dg.RunCommand(sql);
            }
        }

        private void tbHours_Enter(object sender, EventArgs e)
        {
            tbHours.Text = "";
        }
        #endregion
        #region Recap
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
                //if (CheckApproved(tot, "HO"))
                //    tot.HOApproved = true;

            }
            gvRecap.DataSource = totals;

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
            if (gvRecap.Columns[e.ColumnIndex].Name == "SupApproved")
            {
                UncheckApproval(e);
            }
            else if (gvRecap.Columns[e.ColumnIndex].Name == "OMApproved")
            {
                UncheckApproval(e);
            }
            else if (gvRecap.Columns[e.ColumnIndex].Name == "HOApproved")
            {
                UncheckApproval(e);
            }


            else if (gvRecap.Columns[e.ColumnIndex].Name == "SupApproved")
            {
                if (CommonProcs.CheckAccessLevel() < 9)
                {
                    MessageBox.Show("Not Authorized to approve Timesheet");
                    return;
                }
                    
                ApproveBySuper(e);
                FillTotalsView();
            }
            else if (gvRecap.Columns[e.ColumnIndex].Name == "OMApproved")
            {
                if (CommonProcs.CheckAccessLevel() < 10)
                {
                    MessageBox.Show("Not Authorized to approve Timesheet");
                    return;
                }
                ApproveByOM(e);
                FillTotalsView();
            }
            else if (gvRecap.Columns[e.ColumnIndex].Name == "HOApproved")
            {
                if (CommonProcs.CheckAccessLevel() != 10)
                {
                    MessageBox.Show("Not Authorized to approve Timesheet");
                    return;
                }
                ApproveByHO(e);
                FillTotalsView();
            }
            else if (gvRecap.Columns[e.ColumnIndex].Name == "view")
                ShowTimesheet();
        }

        private void ShowTimesheet()
        {
            fmTimesheetView fTV = new fmTimesheetView();
            fTV.Show();
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (gvTimesheet.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select the entry before trying to delete");
                return;
            }
            string TimelineID = gvTimesheet.SelectedRows[0].Cells[0].Value.ToString();
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                string sql = "DELETE FROM Timesheet  WHERE TimesheetID=" + TimelineID;
                dg.RunCommand(sql);
            }
            FillGridView();
        }
        #endregion



        private void tbTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbTabs.SelectedIndex == 1)
                FillTotalsView();
        }

        #region Approval

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


        //private void btnCheckSup_Click(object sender, EventArgs e)
        //{
        //    CheckAll("SUP");
        //}

        //private void btnCheckOM_Click(object sender, EventArgs e)
        //{
        //    CheckAll("OM");
        //}

        //private void btnCheckHO_Click(object sender, EventArgs e)
        //{
        //    CheckAll("HO");
        //}
        private void CheckAll(string btnName,bool checkedAll)
        {
            string checkVal = "1";
            if (checkedAll)
                checkVal = "0";
            switch (btnName)
            {
                case "SUP":
                    if (CommonProcs.CheckAccessLevel() < 9)
                    {
                        MessageBox.Show("Not Authorized to approve Timesheet");
                        return;
                    }
                    break;
                case "OM":
                    if (CommonProcs.CheckAccessLevel() < 10)
                    {
                        MessageBox.Show("Not Authorized to approve Timesheet");
                        return;
                    }

                    break;
                //case "HO":
                //    if (CommonProcs.CheckAccessLevel() != 10)
                //    {
                //        MessageBox.Show("Not Authorized to approve Timesheet");
                //        return;
                //    }

                //    break;
            }
            ApproveAll(btnName,checkVal);
            FillTotalsView();
        }

        private void ApproveAll(string btnName,string val)
        {
            string appField = "SupApprove";
            if (btnName == "OM")
                appField = "OMApprove";
            string sql = "UPDATE Timesheet SET " + appField + "= " + val;
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                dg.RunCommand(sql);
            }
        }

        private void UncheckApproval(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            string empID = gvRecap.Rows[e.RowIndex].Cells[0].Value.ToString();
            string fieldVal = "1";
            bool val = (bool)gvRecap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (val)
                fieldVal = "0";
            string appField = "SupApprove";
            switch (gvRecap.Columns[e.ColumnIndex].Name)
            {
                case "OMApproved":
                    appField = "OMApprove";
                    break;
                case "HOApproved":
                    appField = "HOApprove";
                    break;
            }
            string sql = "UPDATE Timesheet SET " + appField + "= " + fieldVal;
            sql += " WHERE EmployeeID = " + empID;
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                dg.RunCommand(sql);
            }
            FillTotalsView();
        }
        #endregion

        private void gvRecap_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gvRecap.Columns[e.ColumnIndex].Name == "SupApproved")
            {
                CheckAll("SUP", supCheckedAll);
                supCheckedAll = !supCheckedAll;
            }
            else if (gvRecap.Columns[e.ColumnIndex].Name == "OMApproved")
            {
                CheckAll("OM", OMCheckedAll);
                OMCheckedAll = !OMCheckedAll;
            }
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmEmployeeList fEList = new fmEmployeeList();
            fEList.currBranch = GetCurrentBranch();
            fEList.currCompany = GetCurrentCompany();
            fEList.Show();
        }
    }
}
