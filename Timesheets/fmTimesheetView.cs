using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timesheets
{
    public partial class fmTimesheetView : Form
    {
        public fmTimesheetView()
        {
            InitializeComponent();
        }

        private void fmTimesheetView_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.trawickinternational.com/assets/time.pdf");
        }
    }
}
