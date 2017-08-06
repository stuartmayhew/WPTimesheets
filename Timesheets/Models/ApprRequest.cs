using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheets.Models
{
    public class ApprRequest
    {
        [Key]
        public int EmployeeID { get; set; }
        public string employeeName { get; set; }
    }
}
