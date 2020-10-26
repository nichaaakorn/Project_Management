using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ICONEXT.Models
{
    public class PhaseProject
    {
        [Key]
        public int PID { get; set; }
        public string Phase { get; set; }
        public string FromDate { get; set; }
        public string EndDate { get; set; }
        public string Usage { get; set; }
        public int TID { get; set; }
    }
}
