using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezbaZavrsniRad
{
    public partial class Pocetna : Form
    {
      
        public Pocetna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNajave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpis_Click(object sender, EventArgs e)
        {
            this.Hide();
            KalendarBrodova fm = new KalendarBrodova();
            fm.Show();
        }

        private void btnKalendar_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpisBrodova fm = new UpisBrodova();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpisAgencije_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpisAgencije fm = new UpisAgencije();
            fm.Show();
        }
    }
}
