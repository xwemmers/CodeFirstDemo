﻿using System;
using System.Collections.Generic;

using System.Data.Entity;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirstDemo
{
    class MijnDBContext : DbContext
    {
        // Definitie van alle tabellen in de DB
        public DbSet<Person> People { get; set; }
    }
}