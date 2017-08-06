using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheets.Models
{
    public class TimesheetEntryGrid
    {
        public string Customer { get; set; }
        public string Facility { get; set; }
        public string Area { get; set; }
        public string ClassEquip { get; set; }
        public string PayrollItem { get; set; }
        public string WorkDay { get; set; }
        public DateTime WorkDate { get; set; }
        public decimal OTHours { get; set; }
        public decimal RegHours { get; set; }
        public string Notes { get; set; }
    }
}
