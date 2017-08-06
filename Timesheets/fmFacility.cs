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
    public partial class fmFacility : Form
    {
        bool isLoading = false;
        public fmFacility()
        {
            InitializeComponent();
        }

        private void fmFacility_Load(object sender, EventArgs e)
        {
            isLoading = true;
            ShowFacGrid();
            isLoading = false;
        }

        private void ShowFacGrid()
        {
            string branch = GetCurrentBranch();
            string sql = "SELECT * FROM Facility ";
            if (branch != "AA")
                sql += "WHERE Branch='" + branch + "'";
            List<Facility> facs = new ReaderToModel<Facility>().CreateList(sql, CommonProcs.WCompanyConnStr);
            gvFacility.DataSource = facs;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Facility fac = new Facility();
            fac.Branch = GetCurrentBranch();
            fac.facName = tbFacName.Text;
            new ModelToSQL<Facility>().WriteInsertSQL("Facility", fac, "facID", CommonProcs.WCompanyConnStr);
            ShowFacGrid();
        }

        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
                ShowFacGrid();
        }
    }
}
