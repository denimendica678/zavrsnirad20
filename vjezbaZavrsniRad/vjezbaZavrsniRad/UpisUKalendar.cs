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
    public partial class UpisUKalendar : Form
    {
        //kreirali smo varijablu tipa string - path koja na njeno pozivanje kreira datoteku Kalendar.xml na Desktopu lokalnog računala
        string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Kalendari.xml");

        public UpisUKalendar()
        {
            InitializeComponent();
            try
            {
                //dodavanje elementa Naziv iz XML-a u padajući izbornik
                DataSet ds1 = new DataSet();
                ds1.ReadXml(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Agencije.xml"));
                this.comboBoxAgencija.DataSource = ds1.Tables[0];
                this.comboBoxAgencija.DisplayMember = "Naziv";

                //dodavanje elementa Ime iz XML-a u padajući izbornik
                DataSet ds2 = new DataSet();
                ds2.ReadXml(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Brodovi.xml"));
                this.comboBoxImeBroda.DataSource = ds2.Tables[0];
                this.comboBoxImeBroda.DisplayMember = "Ime";
            }
            catch (Exception ex)
            {
                //pojavljivanje messagebox-a koji dolazi ako nema upisanih brodova ni agencija
                MessageBox.Show("Molimo Vas da prije unošenja brodova u kalendar upišete novi brod te agenciju.", "Pažnja", MessageBoxButtons.OK);
            }

        }

        private void UpisUKalendar_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            KalendarBrodova fm = new KalendarBrodova();
            fm.Show();
        }

        private void btnUnesiBrodUKalendar_Click(object sender, EventArgs e)
        {
            //kreiramo try catch zbog mogućnosti da na računalu ne postoji datoteka Kalendari.xml na Desktopu, te ako ne postoji kreira se nova
            try
            {

                //kreiramo varijablu Kalendari koja na poziv učitava datoteku kalendari
                var Kalendari = XDocument.Load(path);

                //posebni elementi u XML-u dobivaju svaki svoj posebni podatak
                var Kalendar = new XElement("Kalendar",
                            new XElement("Brod", comboBoxImeBroda.Text),
                            new XElement("Dolazak", dateTimePickerDolazak.Text),
                            new XElement("Odlazak", dateTimePickerOdlazak.Text),
                            new XElement("Agencija", comboBoxAgencija.Text),
                            new XElement("Stanje", comboBoxStanje.Text),
                            new XElement("Vez", comboBoxVez.Text));

                //upisivanje root-a u XML
                Kalendari.Root.Add(Kalendar);

                //spremamo zapise na putanju
                Kalendari.Save(path);
            }
            //ukoliko program ne pronađe datoteku Kalendari.xml, pokreće se sljedeći kod koji kreira Kalendari.xml datoteku
            catch (Exception ex)
            {
                //kreiranje varijable Kalendari koja kreira novi XDocument
                var Kalendari = new XDocument();

                //dodavanje novog elementa
                Kalendari.Add(new XElement("Kalendari"));

                //kreiramo varijablu Kalendari kojoj dodjeljujemo vrijednost izgleda i podataka koji će se naknadno spremiti u datoteku Kalendari.xml
                var Kalendar = new XElement("Kalendar",
                            new XElement("Brod", comboBoxImeBroda.Text),
                            new XElement("Dolazak", dateTimePickerDolazak.Text),
                            new XElement("Odlazak", dateTimePickerOdlazak.Text),
                            new XElement("Agencija", comboBoxAgencija.Text),
                            new XElement("Stanje", comboBoxStanje.Text),
                            new XElement("Vez", comboBoxVez.Text));

                //upisivanje root elementa u XML
                Kalendari.Root.Add(Kalendar);

                //spremamo zapise na putanju
                Kalendari.Save(path);

                

            }

            //slijedećim dijelom koda upisani podatci sa prostoroa za unos podataka brišu se
            comboBoxImeBroda.Text = "";
            dateTimePickerDolazak.Text = "";
            dateTimePickerOdlazak.Text = "";
            comboBoxAgencija.Text = "";
            comboBoxStanje.Text = "";
            comboBoxVez.Text = "";
            
        }

        private void comboBoxStanje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
