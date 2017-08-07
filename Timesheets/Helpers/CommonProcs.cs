using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using Timesheets.Models;
using System.Data;
using System.Reflection;

namespace Timesheets.Helpers
{
    public static class CommonProcs
    {
        public static string QBConnStr = "Data Source=52.15.204.7;Initial Catalog=WPAccess;Persist Security Info=True;User ID=sa;Password=Sh@dow111";
        public static string WCompanyConnStr = "Data Source=52.15.204.7;Initial Catalog=WPCompany;Persist Security Info=True;User ID=sa;Password=Sh@dow111";

        public static string TimeStampString(DateTime date)
        {
            string tsString = " {ts '" + date.ToString("yyyy-MM-dd") + " 00:00:00.000'}";
            return tsString;
        }

        internal static DateTime GetWeekEnding(DateTime selDate)
        {
            DateTime endOfWeek;
            int thisWeekNumber = GetIso8601WeekOfYear(selDate);
            DateTime firstDayOfWeek = FirstDateOfWeek(selDate.Year, thisWeekNumber, CultureInfo.CurrentCulture);
            endOfWeek = firstDayOfWeek.AddDays(7);
            return endOfWeek;

        }

        public static int GetIso8601WeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.CurrentCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public static DateTime FirstDateOfWeek(int year, int weekOfYear, System.Globalization.CultureInfo ci)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = (int)ci.DateTimeFormat.FirstDayOfWeek - (int)jan1.DayOfWeek;
            DateTime firstWeekDay = jan1.AddDays(daysOffset);
            int firstWeek = ci.Calendar.GetWeekOfYear(jan1, ci.DateTimeFormat.CalendarWeekRule, ci.DateTimeFormat.FirstDayOfWeek);
            if ((firstWeek <= 1 || firstWeek >= 52) && daysOffset >= -3)
            {
                weekOfYear -= 1;
            }
            return firstWeekDay.AddDays(weekOfYear * 7);
        }

        public static string DateString(DateTime date)
        {
            string tsString = " {d '" + date.ToString("yyyy-MM-dd") + "'}";
            return tsString;
        }

        public static TConvert ConvertTo<TConvert>(this object entity) where TConvert : new()
        {
            var convertProperties = TypeDescriptor.GetProperties(typeof(TConvert)).Cast<PropertyDescriptor>();
            var entityProperties = TypeDescriptor.GetProperties(entity).Cast<PropertyDescriptor>();

            var convert = new TConvert();

            foreach (var entityProperty in entityProperties)
            {
                var property = entityProperty;
                var convertProperty = convertProperties.FirstOrDefault(prop => prop.Name == property.Name);
                if (convertProperty != null)
                {
                    convertProperty.SetValue(convert, Convert.ChangeType(entityProperty.GetValue(entity), convertProperty.PropertyType));
                }
            }

            return convert;
        }

        public static void KillQuickbooks()
        {
            Process[] proc = Process.GetProcessesByName("QBW32");
            if (proc.Count() > 0)
                proc[0].Kill();
        }

        internal static List<int> GetFacList(string branchStr)
        {
            List<int> facList = new List<int>();
            string sql = "SELECT * FROM Facility ";
            if (branchStr != "AA")
                sql += "WHERE Branch = '" + branchStr + "' ";
            List<Facility> facs = new ReaderToModel<Facility>().CreateList(sql, WCompanyConnStr);
            foreach (var fac in facs)
            {
                facList.Add(fac.facID);
            }
            return facList;
        }

        internal static int CheckAccessLevel()
        {
            string accLevel = MyConfig.ReadValue("accessLevel");
            return int.Parse(accLevel);
        }
    }
}
 