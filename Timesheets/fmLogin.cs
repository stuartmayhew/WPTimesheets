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
    public partial class fmLogin : Form
    {
        int tryCount = 0;
        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = GetLogin(tbUser.Text,tbPass.Text);
            if (login != null)
            {
                MyConfig.BuildFile(login);
                DialogResult = DialogResult.OK;
            }
            else
            {
                tryCount++;
                if (tryCount > 3)
                    Application.Exit();
                lblName.Text = "Invalid User name or password";
                tbPass.Text = "";
                tbUser.Text = "";

            }
        }

        private Login GetLogin(string user, string pass)
        {
            Login login = readLoginRecord();
            return login;
        }

        private void fmLogin_Load(object sender, EventArgs e)
        {
            Login login = GetLoginFromFile();
            if (login != null)
            {
                tbUser.Text = login.userName;
                lblName.Text = "Enter password for " + login.firstName + " " + login.lastName;
                tbPass.Focus();
            }
            else
            {
                lblName.Text = "Please enter your username and password";
                tbUser.Visible = true;
                tbUser.Focus();
            }
        }

        private Login GetLoginFromFile()
        {
            Login login = null;

            if (System.IO.File.Exists("user.txt"))
            {
                login = ReadLoginFile();
            }
            return login;
        }

        private Login ReadLoginFile()
        {
            Login login = MyConfig.ReadFile();
            return login;
        }

        private Login readLoginRecord()
        {
            string username = tbUser.Text;
            string password = tbPass.Text;
            string sql = "SELECT * FROM Login WHERE userName = '" + username.Trim() + "' ";
            sql += "AND password = '" + password.Trim() + "'";
            Login login = new ReaderToModel<Login>().CreateModel(sql, CommonProcs.WCompanyConnStr);
            return login;
        }
    }
}
