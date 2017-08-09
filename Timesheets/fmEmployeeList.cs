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
    public partial class fmEmployeeList : Form
    {
        public string currBranch;
        public string currCompany;
        bool isLoading = false;
        public fmEmployeeList()
        {
            InitializeComponent();
        }

        private void fmEmployeeList_Load(object sender, EventArgs e)
        {
            isLoading = true;
            SetBranch();
            SetCompany();
            cbShow.SelectedIndex = 0;
            isLoading = false;
            LoadEmployeeGrid();
        }

        private void SetBranch()
        {
            if (currBranch == "AA")
                cbBranch.SelectedIndex = 0;
            else if (currBranch == "00")
                cbBranch.SelectedIndex = 1;
            else if (currBranch == "01")
                cbBranch.SelectedIndex = 2;
            else if (currBranch == "02")
                cbBranch.SelectedIndex = 3;
        }
        private void SetCompany()
        {
            if (currCompany == "W")
                cbCompany.SelectedIndex = 0;
            else
                cbCompany.SelectedIndex = 1;

        }

        private string GetBranch()
        {
            if (cbBranch.SelectedIndex == 0)
                currBranch = "AA";
            else if (cbBranch.SelectedIndex == 1)
                currBranch = "00";
            else if (cbBranch.SelectedIndex == 2)
                currBranch = "01";
            else if (cbBranch.SelectedIndex == 3)
                currBranch = "02";
            return currBranch;
        }
        private string GetCompany()
        {
            if (cbCompany.SelectedIndex == 0)
                currCompany = "W";
            else
                currCompany = "K";
            return currCompany;
        }

        private void LoadEmployeeGrid()
        {
            string sql = "SELECT EmployeeID,Lastname,Firstname,Branch,TSApprover FROM Employee ";
            sql += "WHERE QBFile='" + GetCompany() + "' ";
            if (GetBranch() != "AA")
                sql += "AND Branch = '" + GetBranch() + "' ";
            switch (cbShow.SelectedIndex)
            {
                case 0:
                    sql += "AND isActive = 1";
                    break;
                case 1:
                    sql += "AND isActive = 0";
                    break;
            }
            DataSet ds = null;
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                ds = dg.GetDataSet(sql);
            }
//            List<Employee> empList = new ReaderToModel<Employee>().CreateList(sql, CommonProcs.WCompanyConnStr);
            gvEmpList.DataSource = ds.Tables[0].DefaultView;

        }

        private void gvEmpList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            fmEmpEdit fEdit = new fmEmpEdit();
            fEdit.empID = gvEmpList.Rows[e.RowIndex].Cells[0].Value.ToString();
            fEdit.ShowDialog();
        }

        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
                LoadEmployeeGrid();
        }

        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
                LoadEmployeeGrid();
        }

        private void cbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
                LoadEmployeeGrid();
        }

        private void gvEmpList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow row in gvEmpList.Rows)
            {
                row.HeaderCell.Value = "Edit";
            }
        }
    }
}
