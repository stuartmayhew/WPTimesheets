using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheets.Models;
using System.Windows.Forms;
namespace Timesheets.Helpers
{
    public class QBDataPump
    {
        StatusStrip statusBar;
        ToolStripProgressBar progBar;
        ToolStripLabel progLbl;
        public void PumpCurrentAll(string company)
        {
            CommonProcs.KillQuickbooks();
            PumpCustomers(company);
            CommonProcs.KillQuickbooks();
            PumpEmployees(company);
            CommonProcs.KillQuickbooks();
            PumpPayrollItems(company);
            CommonProcs.KillQuickbooks();
            PumpClass(company);
            CommonProcs.KillQuickbooks();
        }

        public QBDataPump(StatusStrip statBar)
        {
            CommonProcs.KillQuickbooks();
            statusBar = statBar;
            progBar = (ToolStripProgressBar)statusBar.Items["ssProg"];
            progLbl = (ToolStripLabel)statusBar.Items["ssLabel"];
        }

        public int PumpCustomers(string Company)
        {
            string sql = "SELECT * FROM Customer WHERE TimeModified > " + CommonProcs.TimeStampString(DateTime.Now.AddDays(-1));
            UpdateStatusBar("Opening Quickbooks", 10);
            List<QBCustomer> customers = new ODBCReaderToModel<QBCustomer>().CreateList(sql, Company);
            if (customers.Count > 0)
            {
                progBar.Maximum = customers.Count;
                foreach (var QBcust in customers)
                {
                    UpdateStatusBar("Adding " + QBcust.Name, 1);
                    if (QBcust.Name.Contains("00") || QBcust.Name.Contains("01") || QBcust.Name.Contains("02"))
                    {
                        Customer cust = QBcust.ConvertTo<Customer>();
                        cust.QBFile = Company;
                        cust.Branch = cust.Name.Substring(0, 2);
                        using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
                        {
                            cust.CustomerID = dg.GetScalarInteger("SELECT CustomerID FROM Customer WHERE ListID='" + cust.ListID + "' AND QBFile='" + Company + "'");
                        }
                        new ModelToSQL<Customer>().WriteUpdateToSQL("Customer", cust, "CustomerID", CommonProcs.WCompanyConnStr);
                    }
                }
            }
            UpdateStatusBar("Done", progBar.Maximum);
            return customers.Count;
        }



        public int PumpEmployees(string Company)
        {
            string sql = "SELECT * FROM Employee WHERE TimeModified > " + CommonProcs.TimeStampString(DateTime.Now.AddDays(-1));
            UpdateStatusBar("Opening Quickbooks", 10);
            List<QBEmployee> employees = new ODBCReaderToModel<QBEmployee>().CreateList(sql, Company);
            if (employees.Count > 0)
            {
                foreach (var QBemp in employees)
                {
                    UpdateStatusBar("Adding " + QBemp.Name, 1);
                    Employee emp = QBemp.ConvertTo<Employee>();
                    emp.QBFile = Company;
                    
                    using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
                    {
                        emp.EmployeeID = dg.GetScalarInteger("SELECT EmployeeID FROM Employee WHERE ListID='" + emp.ListID + "' AND QBFile='" + Company + "'");
                    }
                    new ModelToSQL<Employee>().WriteUpdateToSQL("Employee", emp, "EmployeeID", CommonProcs.WCompanyConnStr);
                }
            }
            UpdateStatusBar("Done", progBar.Maximum);
            return employees.Count;
        }

        public int PumpPayrollItems(string Company)
        {
            string sql = "SELECT * FROM PayrollItemWage WHERE TimeModified > " + CommonProcs.TimeStampString(DateTime.Now.AddDays(-1));
            UpdateStatusBar("Opening Quickbooks", 10);
            List<QBPayrollItem> payItems = new ODBCReaderToModel<QBPayrollItem>().CreateList(sql, Company);
            if (payItems.Count > 0)
            {
                foreach (var QBpayItem in payItems)
                {
                    if (QBpayItem.Name.Contains("00") || QBpayItem.Name.Contains("01") || QBpayItem.Name.Contains("02"))
                    {
                        UpdateStatusBar("Adding " + QBpayItem.Name, 1);
                        PayrollItem payItem = QBpayItem.ConvertTo<PayrollItem>();
                        payItem.QBFile = Company;
                        using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
                        {
                            payItem.payItemID = dg.GetScalarInteger("SELECT payItemID FROM PayrollItem WHERE ListID='" + payItem.ListID + "' AND QBFile='" + Company + "'");
                        }
                        new ModelToSQL<PayrollItem>().WriteUpdateToSQL("PayrollItem", payItem, "payItemID", CommonProcs.WCompanyConnStr);
                    }
                }
            }
            UpdateStatusBar("Done", progBar.Maximum);
            return payItems.Count;
        }

        public int PumpClass(string Company)
        {
            string sql = "SELECT * FROM Class WHERE TimeModified > " + CommonProcs.TimeStampString(DateTime.Now.AddDays(-1));
            UpdateStatusBar("Opening Quickbooks", 10);
            List<QBClass> clsItems = new ODBCReaderToModel<QBClass>().CreateList(sql, Company);
            if (clsItems.Count > 0)
            {
                foreach (var QBclass in clsItems)
                {
                    if (QBclass.Name.Contains("00") || QBclass.Name.Contains("01") || QBclass.Name.Contains("02"))
                    {
                        UpdateStatusBar("Adding " + QBclass.Name, 1);
                        Clss clss = QBclass.ConvertTo<Clss>();
                        clss.QBFile = Company;
                        clss.Branch = clss.Name.Substring(0, 2);
                        using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
                        {
                            clss.ClassID = dg.GetScalarInteger("SELECT ClassID FROM Clss WHERE ListID='" + clss.ListID + "' AND QBFile='" + Company + "'");
                        }
                        new ModelToSQL<Clss>().WriteUpdateToSQL("Clss", clss, "ClassID", CommonProcs.WCompanyConnStr);
                    }
                }
            }
            UpdateStatusBar("Done", progBar.Maximum);
            return clsItems.Count;
        }

        private void UpdateStatusBar(string v1, int v2)
        {
            if (progBar.Value == progBar.Maximum)
                progBar.Value = v2;
            progLbl.Text = v1;
            if (progBar.Maximum > (progBar.Value + v2))
                progBar.Value += v2;
            else
                progBar.Value = progBar.Maximum;
            Application.DoEvents();
        }
    }
}
