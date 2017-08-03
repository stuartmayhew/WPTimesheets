using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timesheets.Helpers;

namespace Timesheets
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            fmSplash splash = new fmSplash();
            splash.Show();
            System.Threading.Thread.Sleep(5000);
            splash.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DateTime start = DateTime.Now;

            KillProcess();

            int custCount = QBDataPump.PumpAllCustomers("W");
            KillProcess();
            int emCount = QBDataPump.PumpAllEmployees("W");
            KillProcess();
            int clsCount = QBDataPump.PumpAllClass("W");
            KillProcess();
            int prItemCount = QBDataPump.PumpAllPayrollItems("W");
            KillProcess();

            DateTime end = DateTime.Now;
            Cursor = Cursors.Default;
            MessageBox.Show("DONE start " + start + " done " + end);

            Cursor = Cursors.WaitCursor;
            start = DateTime.Now;

            custCount = QBDataPump.PumpAllCustomers("K");
            KillProcess();
            emCount = QBDataPump.PumpAllEmployees("K");
            KillProcess();
            clsCount = QBDataPump.PumpAllClass("K");
            KillProcess();
            prItemCount = QBDataPump.PumpAllPayrollItems("K");
            KillProcess();

            end = DateTime.Now;
            Cursor = Cursors.Default;
            MessageBox.Show("DONE start " + start + " done " + end);
        }

        private void KillProcess()
        {
            Process[] proc = Process.GetProcessesByName("QBW32");
            if (proc.Count() > 0)
                proc[0].Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DateTime start = DateTime.Now;
            int custCount = QBDataPump.PumpCustomers("K");
            DateTime end = DateTime.Now;
            Cursor = Cursors.Default;
            MessageBox.Show("DONE Start " + start + " End " + end + " count " + custCount);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DateTime start = DateTime.Now;
            int custCount = QBDataPump.PumpAllCustomers("W");
            DateTime end = DateTime.Now;
            Cursor = Cursors.Default;
            MessageBox.Show("DONE Start " + start + " End " + end + " count " + custCount);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DateTime start = DateTime.Now;
            int custCount = QBDataPump.PumpAllCustomers("K");
            DateTime end = DateTime.Now;
            Cursor = Cursors.Default;
            MessageBox.Show("DONE Start " + start + " End " + end + " count " + custCount);
        }
    }
}
