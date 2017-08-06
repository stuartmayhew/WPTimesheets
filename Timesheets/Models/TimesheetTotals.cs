using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheets.Models
{
    public class TimesheetTotals
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
        public decimal RegHours { get; set; }
        public decimal OTHours { get; set; }
        public DateTime WeekEnding { get; set; }
        [NotMapped]
        public bool SupApproved { get; set; }
        [NotMapped]
        public bool OMApproved { get; set; }
        [NotMapped]
        public bool HOApproved { get; set; }




    }
}
