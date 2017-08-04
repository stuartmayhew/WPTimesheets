﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheets.Models
{
    public class TimeSheet
    {
        [Key]
        public int TimesheetID { get; set; }
        public DateTime WeekEnding { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public int ClassID { get; set; }
        public int PayrollItemID { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
        public decimal OTHours { get; set; }
        public decimal RegHours { get; set; }
        public bool Approved { get; set; }
    }
}
