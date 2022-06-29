using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace vjezbaZavrsniRad
{
    public partial class UpisAgencije : Form
    {
        //kreirali smo varijablu tipa string - path koja na njeno pozivanje kreira datoteku Agencije.xml na Desktopu lokalnog računala
        string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Agencije.xml");

        public UpisAgencije()
        {
            InitializeComponent();
        }

        private void UpisAgencije_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNatragUA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna fm = new Pocetna();
            fm.Show();
        }

        private void btnUnesiNovuAgenciju_Click(object sender, EventArgs e)
        {
            //kreiramo try catch zbog mogućnosti da na računalu ne postoji datoteka Agencije.xml na Desktopu, te ako ne postoji kreira se nova
            try
            {

                //kreiramo varijablu Agencije koja na poziv učitava datoteku agencije
                var Agencije = XDocument.Load(path);

                //posebni elementi u XML-u dobivaju svaki svoj posebni podatak
                var Agencija = new XElement("Agencija",
                        new XElement("Naziv", textNazivAgencije.Text),
                        new XElement("Email", textAgencijaEmail.Text),
                        new XElement("Oib", textAgencijaOib.Text),
                        new XElement("BrojRacuna", textAgencijaBrRacuna.Text));

                //dodavanje roota u XML
                Agencije.Root.Add(Agencija);

                //spremanje datoteke
                Agencije.Save(path);
            }
            //ukoliko program ne pronađe datoteku Agencije.xml, pokreće se sljedeći kod koji kreira Agencije.xml datoteku
            catch (Exception ex)
            {
                var Agencije = new XDocument();

                //dodavanje novog xelementa (root u XML-u)
                Agencije.Add(new XElement("Agencije"));

                //kreiramo varijablu Agencija kojoj dodjeljujemo vrijednost izgleda i podataka koji će se naknadno spremiti u datoteku Agencije.xml
                var Agencija = new XElement("Agencija",
                        new XElement("Naziv", textNazivAgencije.Text),
                        new XElement("Email", textAgencijaEmail.Text),
                        new XElement("Oib", textAgencijaOib.Text),
                        new XElement("BrojRacuna", textAgencijaBrRacuna.Text));

                //dodavanje zapisa u root
                Agencije.Root.Add(Agencija);

                //spremanje datoteke
                Agencije.Save(path);

            }

            //slijedećim dijelom koda upisani podatci sa prostoroa za unos podataka brišu se
            textNazivAgencije.Text = "";
            textAgencijaEmail.Text = "";
            textAgencijaOib.Text = "";
            textAgencijaBrRacuna.Text = "";
       
        }
    }
}
