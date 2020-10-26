using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ICONEXT.Models
{
    public class TaskProject
    {
        [Key]
        public int TID { get; set; }
        public string Tasks { get; set; }

        public int ProjID { get; set; }


        


    }
}
