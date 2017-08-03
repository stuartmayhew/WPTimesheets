﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheets.Models;
namespace Timesheets.Helpers
{
    public static class QBDataPump
    {
        public static int PumpCustomers(string Company)
        {
            string sql = "SELECT * FROM Customer WHERE TimeModified > " + CommonProcs.TimeStampString(DateTime.Now.AddDays(-1));
            List<QBCustomer> customers = new ODBCReaderToModel<QBCustomer>().CreateList(sql, Company);
            if (customers.Count > 0)
            {
                foreach (var QBcust in customers)
                {
                    if (QBcust.Name.Contains("00") || QBcust.Name.Contains("01") || QBcust.Name.Contains("02"))
                    {
                        Customer cust = QBcust.ConvertTo<Customer>();
                        cust.QBFile = Company;
                        cust.Branch = cust.Name.Substring(0, 2);
                        using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
                        {
                            dg.RunCommand("DELETE FROM Customer WHERE ListID='" + cust.ListID + "' AND QBFile='" + Company + "'");
                        }
                        new ModelToSQL<Customer>().WriteInsertSQL("Customer", cust, "CustomerID", CommonProcs.WCompanyConnStr);
                    }
                }
            }
            return customers.Count;
        }

        public static int PumpEmployees(string Company)
        {
            string sql = "SELECT * FROM Employee WHERE TimeModified > " + CommonProcs.TimeStampString(DateTime.Now.AddDays(-1));
            List<QBEmployee> employees = new ODBCReaderToModel<QBEmployee>().CreateList(sql, Company);
            if (employees.Count > 0)
            {
                foreach (var QBemp in employees)
                {
                    Employee emp = QBemp.ConvertTo<Employee>();
                    emp.QBFile = Company;
                    using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
                    {
                        dg.RunCommand("DELETE FROM Customer WHERE ListID='" + emp.ListID + "' AND QBFile='" + Company + "'");
                    }
                    new ModelToSQL<Employee>().WriteInsertSQL("Employee", emp, "EmployeeID", CommonProcs.WCompanyConnStr);
                }
            }
            return employees.Count;
        }

        public static int PumpPayrollItems(string Company)
        {
            string sql = "SELECT * FROM PayrollItemWage WHERE TimeModified > " + CommonProcs.TimeStampString(DateTime.Now.AddDays(-1));
            List<QBPayrollItem> payItems = new ODBCReaderToModel<QBPayrollItem>().CreateList(sql, Company);
            if (payItems.Count > 0)
            {
                foreach (var QBpayItem in payItems)
                {
                    if (QBpayItem.Name.Contains("00") || QBpayItem.Name.Contains("01") || QBpayItem.Name.Contains("02"))
                    {
                        PayrollItem payItem = QBpayItem.ConvertTo<PayrollItem>();
                        payItem.QBFile = Company;
                        using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
                        {
                            dg.RunCommand("DELETE FROM Payrollitem WHERE ListID='" + payItem.ListID + "' AND QBFile='" + Company + "'");
                        }
                        new ModelToSQL<PayrollItem>().WriteInsertSQL("PayrollItem", payItem, "payItemID", CommonProcs.WCompanyConnStr);
                    }
                }
            }
            return payItems.Count;
        }

        public static int PumpClass(string Company)
        {
            string sql = "SELECT * FROM Class WHERE TimeModified > " + CommonProcs.TimeStampString(DateTime.Now.AddDays(-1));
            List<QBClass> clsItems = new ODBCReaderToModel<QBClass>().CreateList(sql, Company);
            if (clsItems.Count > 0)
            {
                foreach (var QBclass in clsItems)
                {
                    if (QBclass.Name.Contains("00") || QBclass.Name.Contains("01") || QBclass.Name.Contains("02"))
                    {
                        Clss clss = QBclass.ConvertTo<Clss>();
                        clss.QBFile = Company;
                        clss.Branch = clss.Name.Substring(0, 2);
                        using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
                        {
                            dg.RunCommand("DELETE FROM Clss WHERE ListID='" + clss.ListID + "' AND QBFile='" + Company + "'");
                        }
                        new ModelToSQL<Clss>().WriteInsertSQL("PayrollItem", clss, "ClassID", CommonProcs.WCompanyConnStr);
                    }
                }
            }
            return clsItems.Count;
        }

        public static int PumpAllCustomers(string Company)
        {
            string sql = "SELECT * FROM Customer";
            List<QBCustomer> customers = new ODBCReaderToModel<QBCustomer>().CreateList(sql, Company);
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                dg.RunCommand("DELETE FROM Customer WHERE QBFile='" + Company + "'");
            }
            if (customers.Count > 0)
                {
                    foreach (var QBcust in customers)
                    {
                        if (QBcust.Name.Contains("00") || QBcust.Name.Contains("01") || QBcust.Name.Contains("02"))
                        {
                            Customer cust = QBcust.ConvertTo<Customer>();
                            cust.QBFile = Company;
                            cust.Branch = cust.Name.Substring(0, 2);
                            new ModelToSQL<Customer>().WriteInsertSQL("Customer", cust, "CustomerID", CommonProcs.WCompanyConnStr);
                        }
                    }
                }
            return customers.Count;
        }

        public static int PumpAllEmployees(string Company)
        {
            string sql = "SELECT * FROM Employee";
            List<QBEmployee> employees = new ODBCReaderToModel<QBEmployee>().CreateList(sql, Company);
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                dg.RunCommand("DELETE FROM Employee WHERE QBFile='" + Company + "'");
            }
            if (employees.Count > 0)
            {
                foreach (var QBemp in employees)
                {
                    Employee emp = QBemp.ConvertTo<Employee>();
                    emp.QBFile = Company;
                    new ModelToSQL<Employee>().WriteInsertSQL("Employee", emp, "EmployeeID", CommonProcs.WCompanyConnStr);
                }
            }
            return employees.Count;
        }

        public static int PumpAllPayrollItems(string Company)
        {
            string sql = "SELECT * FROM PayrollItemWage";
            List<QBPayrollItem> payItems = new ODBCReaderToModel<QBPayrollItem>().CreateList(sql, Company);
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                dg.RunCommand("DELETE FROM PayrollItem WHERE QBFile='" + Company + "'");
            }
            if (payItems.Count > 0)
            {
                foreach (var QBpayItem in payItems)
                {
                    if (QBpayItem.Name.Contains("00") || QBpayItem.Name.Contains("01") || QBpayItem.Name.Contains("02"))
                    {
                        PayrollItem payItem = QBpayItem.ConvertTo<PayrollItem>();
                        payItem.QBFile = Company;
                        payItem.Branch = payItem.Name.Substring(0, 2);
                        new ModelToSQL<PayrollItem>().WriteInsertSQL("PayrollItem", payItem, "payItemID", CommonProcs.WCompanyConnStr);
                    }
                }
            }
            return payItems.Count;
        }

        public static int PumpAllClass(string Company)
        {
            string sql = "SELECT * FROM Class";
            List<QBClass> clsItems = new ODBCReaderToModel<QBClass>().CreateList(sql, Company);
            using (clsDataGetter dg = new clsDataGetter(CommonProcs.WCompanyConnStr))
            {
                dg.RunCommand("DELETE FROM Clss WHERE QBFile='" + Company + "'");
            }
            if (clsItems.Count > 0)
            {
                foreach (var QBclass in clsItems)
                {
                    if (QBclass.Name.Contains("00") || QBclass.Name.Contains("01") || QBclass.Name.Contains("02"))
                    {
                        Clss clss = QBclass.ConvertTo<Clss>();
                        clss.QBFile = Company;
                        clss.Branch = clss.Name.Substring(0, 2);
                        new ModelToSQL<Clss>().WriteInsertSQL("Clss", clss, "ClassID", CommonProcs.WCompanyConnStr);
                    }
                }
            }
            return clsItems.Count;
        }
    }
}