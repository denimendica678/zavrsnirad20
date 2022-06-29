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
    public partial class Upis : Form
    {
        //kreirali smo varijablu tipa string - path koja na njeno pozivanje kreira datoteku Brodovi.xml na Desktopu lokalnog računala
        string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Brodovi.xml");
        
        public Upis()
        {
            InitializeComponent();

        }

        private void Upis_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            //zatvaramo trenutnu formu
            this.Hide();

            //kreiramo objekt fm klase (ujedno i forme) UpisBrodova, te ga prikazujemo na ekranu
            UpisBrodova fm = new UpisBrodova();
            fm.Show();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //kreiramo try catch zbog mogućnosti da na računalu ne postoji datoteka Brodovi.xml na Desktopu, te ako ne postoji kreira se nova
            try
            {

                //kreiramo varijablu Brodovi koja na poziv učitava datoteku brodovi
                var Brodovi = XDocument.Load(path);

                //posebni elementi u XML-u dobivaju svaki svoj posebni podatak
                var Brod = new XElement("Brod",
                        new XElement("Ime", textBoxImeBroda.Text),
                        new XElement("Imo", textBoxImo.Text),
                        new XElement("Duzina", textBoxDuzina.Text),
                        new XElement("Sirina", textBoxSirina.Text),
                        new XElement("Gaz", textBoxGaz.Text),
                        new XElement("Vrsta", comboBoxVrstaBrodaUB.Text),
                        new XElement("Zastava", comboBoxZastava.Text));

                //dodavanje zapisa u root XML-a
                Brodovi.Root.Add(Brod);

                //spremanje datoteke
                Brodovi.Save(path);
            }
            //ukoliko program ne pronađe datoteku Brodovi.xml, pokreće se sljedeći kod koji kreira Brodovi.xml datoteku
            catch (Exception ex)
            {
                var Brodovi = new XDocument();

                //dodavanje novog xelementa (root u XML-u)
                Brodovi.Add(new XElement("Brodovi"));

                //kreiramo varijablu Brod kojoj dodjeljujemo vrijednost izgleda i podataka koji će se naknadno spremiti u datoteku Brodovi.xml
                var Brod = new XElement("Brod",
                            new XElement("Ime", textBoxImeBroda.Text),
                            new XElement("Imo", textBoxImo.Text),
                            new XElement("Duzina", textBoxDuzina.Text),
                            new XElement("Sirina", textBoxSirina.Text),
                            new XElement("Gaz", textBoxGaz.Text),
                            new XElement("Vrsta", comboBoxVrstaBrodaUB.Text),
                            new XElement("Zastava", comboBoxZastava.Text));

                //dodavanje zapisa u root
                Brodovi.Root.Add(Brod);

                //spremanje na putanju
                Brodovi.Save(path);
                
            }

            //slijedećim dijelom koda upisani podatci sa prostoroa za unos podataka brišu se
            textBoxImeBroda.Text = "";
            textBoxImo.Text = "";
            textBoxDuzina.Text = "";
            textBoxSirina.Text = "";
            textBoxGaz.Text = "";
            comboBoxVrstaBrodaUB.Text = "";
            comboBoxZastava.Text = "";


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
