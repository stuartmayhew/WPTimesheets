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
using Timesheets.Models;


namespace Timesheets
{
    public partial class fmRequestApproval : Form
    {
        public fmRequestApproval()
        {
            InitializeComponent();
        }

        private void fmRequestApproval_Load(object sender, EventArgs e)
        {
            List<ApprRequest> requests = new List<ApprRequest>();
            string sql = "SELECT TOP(10) * FROM Employee ";
            List<Employee> emps = new ReaderToModel<Employee>().CreateList(sql, CommonProcs.WCompanyConnStr);
            foreach (var emp in emps)
            {
                ApprRequest req = new ApprRequest();
                req.EmployeeID = emp.EmployeeID;
                req.employeeName = emp.LastName + "," + emp.FirstName;
                lbRequest.Items.Add(req.employeeName);
            }
        }
    }
}
