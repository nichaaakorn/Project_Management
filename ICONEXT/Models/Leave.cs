using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ICONEXT.Models
{
    public class Leave
    {
        [Key]
        public int LID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string note { get; set; }
        public string Days { get; set; }

        public string ID { get; set; }
    }
}





