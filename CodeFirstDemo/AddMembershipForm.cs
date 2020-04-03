using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstDemo
{
    public partial class AddMembershipForm : Form
    {
        public AddMembershipForm()
        {
            InitializeComponent();
        }

        MijnDBContext db = new MijnDBContext();

        private void AddMembershipForm_Load(object sender, EventArgs e)
        {
            lbxPeople.DataSource = db.People.ToList();
            lbxTeams.DataSource = db.Teams.ToList();

            lbxTeams.DisplayMember = "Description";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = lbxPeople.SelectedItem as Person;
            var t = lbxTeams.SelectedItem as Team;

            // En dan kun je een nieuwe Membership aanmaken en toevoegen aan de DB

            var mem = new Membership();
            mem.When = DateTime.Now;
            mem.Person = p;
            mem.Team = t;

            db.Memberships.Add(mem);

            db.SaveChanges();
        }

        // Check of iemand al lid
        // Delete een membership (op Form1)
        // Form om Teams toe te voegen
        // Als je in Form1 een Person selecteert, laat dan de Teams zien
        // En andersom: als je in Form1 een Team selecteert, laat dan de personen in dat team zien


    }
}
