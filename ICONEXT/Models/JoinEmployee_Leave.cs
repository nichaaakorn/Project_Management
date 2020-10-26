using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ICONEXT.Models
{
    public class JoinEmployee_Leave
    {
        [Key]

        public string ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public string Position { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Active { get; set; }


        public int LID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string note { get; set; }
        public string Days { get; set; }

    }
}
