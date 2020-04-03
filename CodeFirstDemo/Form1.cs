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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MijnDBContext db = new MijnDBContext();

        private void button6_Click(object sender, EventArgs e)
        {
            var p = new Person();
            p.Firstname = txtFirstname.Text;
            p.Lastname = txtLastname.Text;
            p.Gender = (GenderType)cbxGender.SelectedIndex;
            p.DateOfBirth = dtpDateOfBirth.Value.Date;
            p.Country = cbxCountry.Text;

            db.People.Add(p);
            db.SaveChanges();

            // Laat de hele tabel zien
            dg.DataSource = db.People.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Laat de hele tabel zien
            dg.DataSource = db.People.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(db.Database.Connection.ConnectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxGender.DataSource = Enum.GetValues(typeof(GenderType));

            // Vier regels code voor het ophalen van de web api met landen
            // https://restcountries.eu/rest/v2

            // HttpClient
            // NuGet package: NewtonSoft.Json
            // JsonConvert.Deserialize(string)
            // class Country (name, region, capital, population)

            cbxCountry.DataSource = new[] { "Nederland", "Belgie" }; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Zoeken in de DB:
            var query = from p in db.People
                        where p.Firstname.Contains(txtSearch.Text)
                        orderby p.Lastname
                        select p;

            dg.DataSource = query.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var p = (Person)dg.SelectedRows[0].DataBoundItem;

            db.People.Remove(p);

            db.SaveChanges();

            dg.DataSource = db.People.ToList();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }

            dtpDateOfBirth.Value = DateTime.Now.Date;
            cbxCountry.SelectedIndex = -1;
            cbxGender.SelectedIndex = -1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var p = new Person();
            p.Firstname = "Xander";
            p.Lastname = "Wemmers";
            p.DateOfBirth = new DateTime(1974, 2, 7);

            var t = new Team();
            t.Description = "Pink";

            var t2 = new Team();
            t2.Description = "Development";

            var mem = new Membership();
            mem.When = DateTime.Now;
            mem.Person = p;
            mem.Team = t;

            var mem2 = new Membership();
            mem2.Person = p;
            mem2.Team = t2;
            mem2.When = DateTime.Now;

            db.Memberships.Add(mem);
            db.Memberships.Add(mem2);

            db.Teams.Add(new Team { Description = "Vrijdagmiddagborrel" });
            db.Teams.Add(new Team { Description = "Training" });
            db.Teams.Add(new Team { Description = "Schaken" });

            db.People.Add(new Person { Firstname = "Eric", Lastname = "Aarts", DateOfBirth = DateTime.Now });
            db.People.Add(new Person { Firstname = "Gerlie", Lastname = "Lima Giezen", DateOfBirth = DateTime.Now });
            db.People.Add(new Person { Firstname = "Ton", Lastname = "Bastianen", DateOfBirth = DateTime.Now });
            db.People.Add(new Person { Firstname = "Mark", Lastname = "van Assema", DateOfBirth = DateTime.Now });

            db.SaveChanges();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            db.Database.Delete();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dg.DataSource = db.People.ToList();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dg.DataSource = db.Teams.ToList();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            // Next Exercise:

            // Toon van Team de Description
            // Toon van Person de Firstname en Lastname

            var query = from m in db.Memberships
                        select new
                        {
                            m.MembershipID,
                            m.When,
                            m.Team.Description,
                            m.Person.Firstname,
                            m.Person.Lastname
                        };

            dg.DataSource = query.ToList();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var form = new AddMembershipForm();
            form.ShowDialog();
        }
    }
}
