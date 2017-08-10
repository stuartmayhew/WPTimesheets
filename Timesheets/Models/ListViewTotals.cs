using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Timesheets.Models
{
    public class ListViewTotals
    {
        public string custName { get; set; }
        public decimal RegHours { get; set; }
        public decimal OTHours { get; set; }
        public decimal RegMon { get; set; }
        public decimal OTMon { get; set; }
        public decimal RegTue { get; set; }
        public decimal OTTue { get; set; }
        public decimal RegWed { get; set; }
        public decimal OTWed { get; set; }
        public decimal RegThur { get; set; }
        public decimal OTThur { get; set; }
        public decimal RegFri { get; set; }
        public decimal OTFri { get; set; }
        public decimal RegSat { get; set; }
        public decimal OTSat { get; set; }
        public decimal RegSun { get; set; }
        public decimal OTSun { get; set; }

        public ListViewTotals()
        {
            PropertyInfo[] props = this.GetType().GetProperties();
            foreach (var prop in props)
                if (prop.Name != "custName")
                    prop.SetValue(this, 0.0M);
        }
    }
}
