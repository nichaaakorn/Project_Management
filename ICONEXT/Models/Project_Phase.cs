using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ICONEXT.Models
{
    public class Project_Phase
    {
        [Key]
        public int ProjID { get; set; }
        public string Name { get; set; }
        public string Partner { get; set; }
        public string Customer { get; set; }
        public string StartDate { get; set; }

        public int TID { get; set; }
        public string Tasks { get; set; }


        public string Phase { get; set; }
        public string FromDate { get; set; }
        public string EndDate { get; set; }
        public string Usage { get; set; }


    }
}
