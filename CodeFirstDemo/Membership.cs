using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public class Membership
    {
        public int MembershipID { get; set; }

        public DateTime When { get; set; }




        // Foreign Keys
        // Uiteindelijk kun je de drie tabellen joinen

        public virtual Team Team { get; set; }
        public virtual Person Person { get; set; }
    }
}
