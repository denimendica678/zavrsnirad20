using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace vjezbaZavrsniRad
{
    public partial class UpisBrodova : Form
    {

        //kreirali smo varijablu tipa string - path koja na njeno pozivanje kreira datoteku Brodovi.xml na Desktopu lokalnog računala
        string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Brodovi.xml");
 
        public UpisBrodova()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //zatvaramo trenutnu formu
            this.Hide();

            //kreiramo objekt fm klase (ujedno i forme) Pocetna, te ga prikazujemo na ekranu
            Pocetna fm = new Pocetna();
            fm.Show();
        }

        private void UpisBrodova_Load(object sender, EventArgs e)
        {
            //učitavanje novih unosa iz XML-a u dataGridView prozor
            try
            {
                //kreiramo objekt ds kojemu dodajemo vrijednost putanje datoteke gore navedene
                DataSet ds = new DataSet();
                ds.ReadXml(path);
                
                foreach (DataRow item in ds.Tables["Brod"].Rows)
                {
                    int n = dtUpisaniBrodovi.Rows.Add();

                    dtUpisaniBrodovi.Rows[n].Cells[0].Value = item[0];
                    dtUpisaniBrodovi.Rows[n].Cells[1].Value = item[1];
                    dtUpisaniBrodovi.Rows[n].Cells[2].Value = item[5];
                    dtUpisaniBrodovi.Rows[n].Cells[3].Value = item[2];
                    dtUpisaniBrodovi.Rows[n].Cells[4].Value = item[3];
                    dtUpisaniBrodovi.Rows[n].Cells[5].Value = item[4];
                    dtUpisaniBrodovi.Rows[n].Cells[6].Value = item[6];

                }
            }
            catch(Exception ex)
            {
               
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //zatvaramo trenutnu formu
            this.Hide();

            //kreiramo objekt fm klase (ujedno i forme) Upis, te ga prikazujemo na ekranu
            Upis fm = new Upis();
            fm.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtUpisaniBrodovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
