﻿

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace ICONEXT.Models
{
    public class employee
    {
        public string ID { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Nickname { get; set; }

        public string Position { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public string Active { get; set; }
    }
}