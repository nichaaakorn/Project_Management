using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ICONEXT.Models
{
    public class Project_Task
    {
        [Key]
        public int ProjID { get; set; }
        public string Name { get; set; }
        public string Tasks { get; set; }
        

    }
}
