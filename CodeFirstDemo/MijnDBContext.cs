using System;
using System.Collections.Generic;

using System.Data.Entity; // Entity Framework

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirstDemo
{
    public class MijnDBContext : DbContext
    {
        // Definitie van alle tabellen in de DB
        public DbSet<Person> People { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Membership> Memberships { get; set; }
    }
}
