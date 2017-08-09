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
    public partial class fmEmpEdit : Form
    {
        public string empID;
        public fmEmpEdit()
        {
            InitializeComponent();
        }

        private void fmEmpEdit_Load(object sender, EventArgs e)
        {
            lblEmpID.Text = empID;
        }
    }
}
