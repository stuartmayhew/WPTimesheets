using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheets.Models
{
    public class Facility
    {
        [Key]
        public int facID { get; set; }
        public string Branch { get; set; }
        public string facName { get; set; }

    }
}
