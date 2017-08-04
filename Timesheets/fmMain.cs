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

namespace Timesheets
{
    public partial class fmMain : Form
    {
        int accessLevel;
        int branch;
        string userName;
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
            fmLogin fLogin = new fmLogin();
            DialogResult = fLogin.ShowDialog();
            lblWeekEnding.Text = CommonProcs.GetWeekEnding(DateTime.Now).ToShortDateString();
            userName = MyConfig.ReadValue("firstName") + " " + MyConfig.ReadValue("lastName");
            accessLevel = int.Parse(MyConfig.ReadValue("accessLevel"));
            branch = int.Parse(MyConfig.ReadValue("branch"));
            Text = "Timesheet Entry v." + Application.ProductVersion.ToString();
            lblStatus.Text = "Current user: " + userName + "  Current Branch: " + branch;
            RefreshQuickbooksData();
            LoadMainCombos();
            LoadBranchCombos();
            cbCompany.SelectedIndex = 0;

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

        private void LoadBranchCombos()
        {

        }

        private void RefreshQuickbooksData()
        {
            CommonProcs.KillQuickbooks();

            QBDataPump dataPump = new QBDataPump();
            ToolStripProgressBar progBar = (ToolStripProgressBar)statusStrip1.Items["ssProg"];
            ToolStripLabel progLbl = (ToolStripLabel)statusStrip1.Items["ssLabel"];
            progBar.Value = 10;
            progLbl.Text = "Loading Customers";
            dataPump.PumpCustomers("W");
            Application.DoEvents();

            progBar.Value = 30;
            progLbl.Text = "Loading Employees";
            CommonProcs.KillQuickbooks();
            dataPump.PumpEmployees("W");
            Application.DoEvents();

            progBar.Value = 30;
            progLbl.Text = "Loading PayrollItems";
            CommonProcs.KillQuickbooks();
            dataPump.PumpPayrollItems("W");
            Application.DoEvents();

            progBar.Value = 30;
            progLbl.Text = "Loading Classes";
            CommonProcs.KillQuickbooks();
            dataPump.PumpClass("W");
            Application.DoEvents();
        }
    }
}
