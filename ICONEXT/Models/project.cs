using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ICONEXT.Models
{
    public class project
    {
        [Key]
        public int ProjID { get; set; }
        public string Name { get; set; }
        public string Partner { get; set; }
        public string Customer { get; set; }
        public string StartDate { get; set; }

        
    }
}
