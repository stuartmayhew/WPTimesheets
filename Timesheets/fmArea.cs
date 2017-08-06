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
    public partial class fmArea : Form
    {
        bool isLoading = false;
        public fmArea()
        {
            InitializeComponent();
        }

        private void fmArea_Load(object sender, EventArgs e)
        {
            isLoading = true;
            ShowAreaGrid();
            cbFac.DataSource = SelectListHelper.GetFacilityList("AA");
            cbFac.DisplayMember = "key";
            cbFac.ValueMember = "value";
            isLoading = false;
            cbFac.SelectedIndex = 0;
        }

        private void ShowAreaGrid()
        {
            string sql = "SELECT * FROM Area ";
            if (cbFac.SelectedValue != null)
                sql += "WHERE facId = " + cbFac.SelectedValue.ToString();
            List<Area> areas = new ReaderToModel<Area>().CreateList(sql, CommonProcs.WCompanyConnStr);
            gvArea.DataSource = areas;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Area area = new Area();
            area.facID = int.Parse(cbFac.SelectedValue.ToString());
            area.areaName = tbAreaName.Text;
            new ModelToSQL<Area>().WriteInsertSQL("Area", area, "areaID", CommonProcs.WCompanyConnStr);
            ShowAreaGrid();
        }

        private void cbFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
                ShowAreaGrid();
        }
    }
}
