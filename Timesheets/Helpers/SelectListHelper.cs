using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timesheets.Models;
namespace Timesheets.Helpers
{
    public static class SelectListHelper
    {
        public static List<ComboBoxItem> GetEmployeeList(string QBFile,string branchStr,bool showActive,bool useItemNo)
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            string sql = "SELECT * FROM Employee WHERE QBFile = '" + QBFile + "' ";
            if (branchStr != "AA")
                sql += "AND Branch = '" + branchStr + "' ";
            if (showActive)
                sql += " AND isActive = 1";
            List<Employee> empList = new ReaderToModel<Employee>().CreateList(sql, CommonProcs.WCompanyConnStr);
            foreach(var emp in empList)
            {
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.value = emp.EmployeeID;
                if (useItemNo)
                    cbItem.key = emp.EmployeeID.ToString() + "-" + emp.LastName + "," + emp.FirstName;
                else
                    cbItem.key = emp.LastName + "," + emp.FirstName;
                items.Add(cbItem);
            }
            return items;
        }

        internal static List<ComboBoxItem> GetCustomerList(string QBFile, string branchStr,bool showActive, bool useItemNo)
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            string sql = "SELECT * FROM Customer WHERE QBFile = '" + QBFile + "' ";
            if (branchStr != "AA")
                sql += "AND branch = '" + branchStr.Trim() + "' ";
            if (showActive)
                sql += " AND isActive = 1";

            List<Customer> custList = new ReaderToModel<Customer>().CreateList(sql, CommonProcs.WCompanyConnStr);
            foreach (var cust in custList)
            {
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.value = cust.CustomerID;
                if (useItemNo)
                    cbItem.key = cust.CustomerID.ToString() + "-" + cust.FullName;
                else
                    cbItem.key = cust.FullName;

                items.Add(cbItem);
            }
            return items;
        }

        internal static List<ComboBoxItem> GetPayrollItemList(string QBFile, string branchStr, bool useItemNo)
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            string sql = "SELECT * FROM PayrollItem WHERE QBFile = '" + QBFile + "' ";
            if (branchStr != "AA")
                sql += "AND branch = '" + branchStr.Trim() + "' ";
            sql += "AND WageType='HourlyRegular'";
            List<PayrollItem> priList = new ReaderToModel<PayrollItem>().CreateList(sql, CommonProcs.WCompanyConnStr);
            foreach (var pri in priList)
            {
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.value = pri.payItemID;
                cbItem.key = pri.Name.Split('-')[1];
                items.Add(cbItem);
            }
            return items;
        }

        internal static List<ComboBoxItem> GetClassCombo(string QBFile, string branchStr, bool useItemNo)
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            string sql = "SELECT * FROM Clss WHERE QBFile = '" + QBFile + "' ";
            if (branchStr != "AA")
                sql += "AND branch = '" + branchStr.Trim() + "'";

            List<Clss> clsList = new ReaderToModel<Clss>().CreateList(sql, CommonProcs.WCompanyConnStr);
            foreach (var cls in clsList)
            {
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.value = cls.ClassID;
                if (useItemNo)
                    cbItem.key = cls.ClassID.ToString() + "-" + cls.Name;
                else
                    cbItem.key = cls.Name;
                items.Add(cbItem);
            }
            return items;
        }

        internal static List<ComboBoxItem> GetAreaList(List<int> facIDs)
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            foreach (var fac in facIDs)
            {
                string sql = "SELECT * FROM Area WHERE facID=" + fac;
                List<Area> areaList = new ReaderToModel<Area>().CreateList(sql, CommonProcs.WCompanyConnStr);
                foreach (var area in areaList)
                {
                    ComboBoxItem cbItem = new ComboBoxItem();
                    cbItem.value = area.areaID;
                    cbItem.key = area.areaName;
                    items.Add(cbItem);
                }
            }
            return items;
        }

        internal static List<ComboBoxItem> GetFacilityList(string branchStr)
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            string sql = "SELECT * FROM Facility ";
            if (branchStr != "AA")
                sql += "WHERE branch = '" + branchStr.Trim() + "'";
            List<Facility> facList = new ReaderToModel<Facility>().CreateList(sql, CommonProcs.WCompanyConnStr);
            foreach (var fac in facList)
            {
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.value = fac.facID;
                cbItem.key = fac.facName;
                items.Add(cbItem);
            }
            return items;
        }

        public static List<ComboBoxItem> GetStateList()
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            string sql = "SELECT * FROM USStates ORDER BY StateName ";
            List<USStates> stateList = new ReaderToModel<USStates>().CreateList(sql, CommonProcs.WCompanyConnStr);
            foreach (var state in stateList)
            {
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.strValue = state.StateAbbr;
                cbItem.key = state.StateName;
                items.Add(cbItem);
            }
            return items;
        }
    }


}
