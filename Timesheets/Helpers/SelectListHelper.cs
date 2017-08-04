using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheets.Models;
namespace Timesheets.Helpers
{
    public static class SelectListHelper
    {
        public static List<ComboBoxItem> GetEmployeeList(string QBFile)
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            string sql = "SELECT * FROM Employee WHERE QBFile = '" + QBFile + "'";
            List<Employee> empList = new ReaderToModel<Employee>().CreateList(sql, CommonProcs.WCompanyConnStr);
            foreach(var emp in empList)
            {
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.value = emp.EmployeeID;
                cbItem.key = emp.EmployeeID.ToString() + "-" + emp.LastName + "," + emp.FirstName;
                items.Add(cbItem);
            }
            return items;
        }

        internal static object GetCustomerList(string QBFile, string branchStr)
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            string sql = "SELECT * FROM Customer WHERE QBFile = '" + QBFile + "' AND branch='" + branchStr.Trim() + "'";
            if (branchStr == "AA")
                sql = "SELECT * FROM Customer WHERE QBFile = '" + QBFile + "'";
            List<Customer> custList = new ReaderToModel<Customer>().CreateList(sql, CommonProcs.WCompanyConnStr);
            foreach (var cust in custList)
            {
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.value = cust.CustomerID;
                cbItem.key = cust.CustomerID.ToString() + "-" + cust.FullName;
                items.Add(cbItem);
            }
            return items;
        }

        internal static object GetPayrollItemList(string QBFile, string branchStr)
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            string sql = "SELECT * FROM PayrollItem WHERE QBFile = '" + QBFile + "' AND branch='" + branchStr.Trim() + "'";
            if (branchStr == "AA")
                sql = "SELECT * FROM PayrollItem WHERE QBFile = '" + QBFile + "'";
            List<PayrollItem> priList = new ReaderToModel<PayrollItem>().CreateList(sql, CommonProcs.WCompanyConnStr);
            foreach (var pri in priList)
            {
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.value = pri.payItemID;
                cbItem.key = pri.payItemID.ToString() + "-" + pri.Name;
                items.Add(cbItem);
            }
            return items;
        }

        internal static object GetClassCombo(string QBFile, string branchStr)
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            string sql = "SELECT * FROM Clss WHERE QBFile = '" + QBFile + "' AND branch='" + branchStr.Trim() + "'";
            if (branchStr == "AA")
                sql = "SELECT * FROM Clss WHERE QBFile = '" + QBFile + "'";
            List<Clss> clsList = new ReaderToModel<Clss>().CreateList(sql, CommonProcs.WCompanyConnStr);
            foreach (var cls in clsList)
            {
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.value = cls.ClassID;
                cbItem.key = cls.ClassID.ToString() + "-" + cls.Name;
                items.Add(cbItem);
            }
            return items;
        }
    }

    public class ComboBoxItem
    {
        public string key { get; set; }
        public int value { get; set; }
    }
}
