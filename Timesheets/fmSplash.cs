using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timesheets.Helpers;

namespace Timesheets
{
    public partial class fmSplash : Form
    {
        public fmSplash()
        {
            InitializeComponent();
        }

        private void fmSplash_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Timesheet System";
            lblVersion.Text = Application.ProductVersion.ToString();
        }


        private void RefreshQuickbooksData()
        {
            //QBDataPump dataPump = new QBDataPump();
            //progressBar1.Value = 10;
            //lblStatus.Text = "Loading Customers";
            ////CommonProcs.KillQuickbooks();
            //dataPump.PumpCustomers("W");
            //Application.DoEvents();

            //progressBar1.Value = 30;
            //lblStatus.Text = "Loading Employees";
            //CommonProcs.KillQuickbooks();
            //dataPump.PumpEmployees("W");
            //Application.DoEvents();

            //progressBar1.Value = 30;
            //lblStatus.Text = "Loading PayrollItems";
            //CommonProcs.KillQuickbooks();
            //dataPump.PumpPayrollItems("W");
            //Application.DoEvents();

            //progressBar1.Value = 30;
            //lblStatus.Text = "Loading Classes";
            //CommonProcs.KillQuickbooks();
            //dataPump.PumpClass("W");
            //Application.DoEvents();
        }

        private void fmSplash_Shown(object sender, EventArgs e)
        {
            RefreshQuickbooksData();
        }
    }
}
