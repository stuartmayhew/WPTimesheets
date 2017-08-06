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
    public partial class fmLoginEdit : Form
    {
        public fmLoginEdit()
        {
            InitializeComponent();
        }

        private void fmLoginEdit_Load(object sender, EventArgs e)
        {
            LoadLoginGrid();
            LoadAccessLevels();
        }

        private void LoadLoginGrid()
        {
            string sql = "SELECT * FROM Login";
            List<Login> logins = new ReaderToModel<Login>().CreateList(sql,CommonProcs.WCompanyConnStr);
            gvLogins.DataSource = logins;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gvLogins.Rows)
            {
                Login login = new Login();
                login.userID = int.Parse(row.Cells[0].Value.ToString());
                login.firstName = row.Cells[1].Value.ToString();
                login.lastName = row.Cells[2].Value.ToString();
                login.userName = row.Cells[3].Value.ToString();
                login.password = row.Cells[4].Value.ToString();
                login.accessLevel = int.Parse(row.Cells[5].Value.ToString());
                login.branch = int.Parse(row.Cells[6].Value.ToString());
                new ModelToSQL<Login>().WriteUpdateToSQL("Login", login, "userID", CommonProcs.WCompanyConnStr);
            }
            LoadLoginGrid();
        }

        private void LoadAccessLevels()
        {
            string sql = "SELECT * FROM AccessLevels";
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                System.Data.SqlClient.SqlDataReader dr = dg.GetDataReader(sql);
                while (dr.Read())
                {
                    string alStr = dr["accessLevelID"].ToString() + " - " + dr["accDesc"].ToString();
                    lbAccessLevels.Items.Add(alStr);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.firstName = "New Login";
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                new ModelToSQL<Login>().WriteInsertSQL("Login", login, "userID", CommonProcs.WCompanyConnStr);
            }
            LoadLoginGrid();
        }
    }
}
