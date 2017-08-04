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
    public partial class fmNote : Form
    {
        public string noteText = "";
        public fmNote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noteText = tbNoteText.Text;
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            noteText = "";
            DialogResult = DialogResult.Cancel;
        }
    }
}
