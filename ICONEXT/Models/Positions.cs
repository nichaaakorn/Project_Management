using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ICONEXT.Models
{
   
    
    public class Positions
    {
        [Key]
        public int ID { get; set; }

        public string Position { get; set; }

        public string Description { get; set; }
    }
}
