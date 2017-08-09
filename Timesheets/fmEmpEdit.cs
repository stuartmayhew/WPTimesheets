using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timesheets.Models;
using Timesheets.Helpers;

namespace Timesheets
{
    public partial class fmEmpEdit : Form
    {
        public string empID;
        public fmEmpEdit()
        {
            InitializeComponent();
        }

        private void fmEmpEdit_Load(object sender, EventArgs e)
        {
            LoadUSStates();
            lblEmpID.Text = empID;
            string sql = "SELECT * FROM Employee WHERE EmployeeID = " + empID;
            Employee emp = new ReaderToModel<Employee>().CreateModel(sql, CommonProcs.WCompanyConnStr);
            this.tbFirstName.Text = emp.FirstName;
            this.tbMiddleName.Text = emp.MiddleName;
            this.tbLastName.Text = emp.LastName;
            this.tbAddress1.Text = emp.Address1;
            this.tbAddress2.Text = emp.Address2;
            this.tbCity.Text = emp.City;
            this.cbState.Text = emp.State;
            this.tbZip.Text = emp.Zip;
            this.tbPhone.Text = emp.Phone;
            this.tbEmail.Text = emp.Email;
            this.tbSSN.Text = emp.SSN;
            this.cbBranch.SelectedIndex = GetBranchIndex(emp.Branch);
            this.cbCompany.SelectedIndex = GetCompIndex(emp.QBFile);
            cbActive.Checked = emp.IsActive;
            cbApprove.Checked = emp.TSApprover;
            cbSubmit.Checked = emp.TSSubmitter;
            if (emp.FirstName == "New")
                btnClose.Text = "Cancel";
            else
                btnClose.Text = "Close";
        }

        private int GetCompIndex(string qBFile)
        {
            if (qBFile == "W")
                return 0;
            return 1;
        }

        private int GetBranchIndex(string branch)
        {
           switch (branch)
            {
                case "00":
                    return 0;
                case "01":
                    return 1;
                case "02":
                    return 2;
            }
            return 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeID = int.Parse(lblEmpID.Text);
            emp.FirstName = this.tbFirstName.Text;
            emp.MiddleName = this.tbMiddleName.Text;
            emp.LastName = this.tbLastName.Text;
            emp.Address1 = this.tbAddress1.Text;
            emp.Address2 = this.tbAddress2.Text;
            emp.City = this.tbCity.Text;
            emp.State = this.cbState.SelectedValue.ToString();
            emp.Zip = this.tbZip.Text;
            emp.Phone = this.tbPhone.Text;
            emp.Email = this.tbEmail.Text;
            emp.SSN = tbSSN.Text;
            emp.TSApprover = cbApprove.Checked;
            emp.TSSubmitter = cbSubmit.Checked;
            emp.IsActive = cbActive.Checked;
            emp.Branch = GetCurrentBranch();
            emp.QBFile = GetCurrentCompany();
            new ModelToSQL<Employee>().WriteUpdateToSQL("Employee", emp, "EmployeeID", CommonProcs.WCompanyConnStr);

        }

        private string GetCurrentCompany()
        {
            if (cbCompany.SelectedIndex == 0)
                return "W";
            else
                return "K";
        }

        private string GetCurrentBranch()
        {
            switch (cbBranch.SelectedIndex)
            {
                case 0:
                    return "00";
                case 1:
                    return "01";
                case 2:
                    return "02";
            }
            return "";
        }

        private void LoadUSStates()
        {
            cbState.DataSource = SelectListHelper.GetStateList();
            cbState.DisplayMember = "key";
            cbState.ValueMember = "strValue";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "Close")
                Close();
            else
            {
                using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
                {
                    dg.RunCommand("DELETE FROM Employee WHERE EmployeeID = " + lblEmpID.Text);
                }
                Close();
            }
        }
    }
}
