﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo
{
    class Person
    {
        public int PersonID { get; set; }
        
        [Required]
        [StringLength(40)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public GenderType Gender { get; set; }

        [StringLength(20)]
        public string Country { get; set; }
    }

    enum GenderType
    {
        Male, Female, Unknown
    }
}