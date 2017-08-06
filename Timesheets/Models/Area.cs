using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheets.Models
{
    public class Area
    {
        [Key]
        public int areaID { get; set; }
        public int facID { get; set; }
        public string areaName { get; set; }
    }
}
