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
            string sql = "SELECT * FROM Employee WHERE isActive = 1 ";
            sql += "AND QBFile = '" + QBFile + "'";
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
    }

    public class ComboBoxItem
    {
        public string key { get; set; }
        public int value { get; set; }
    }
}
