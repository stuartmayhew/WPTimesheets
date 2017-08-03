using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheets.Models
{
    public class PayrollItem
    {
        [Key]
        public int payItemID { get; set; }
        public string QBFile { get; set; }
        public string Branch { get; set; }
        public string ListID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string WageType { get; set; }
        public string ExpenseAccountRefListID { get; set; }
        public string ExpenseAccountRefFullName { get; set; }
    }
}
