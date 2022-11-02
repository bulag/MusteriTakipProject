using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTakip
{
    public partial class ÖdemeAl : Form
    {
        public ÖdemeAl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Tahsilat th=new Tahsilat();
            //th.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.SonMusteriTableAdapter taMus = new DataSet1TableAdapters.SonMusteriTableAdapter();
            DataSet1TableAdapters.MusteriDetayTableAdapter detay = new DataSet1TableAdapters.MusteriDetayTableAdapter();
            taMus.BorcAzalt(Convert.ToInt16(textBox2.Text), Convert.ToInt16(label1.Text));
            detay.DetayEkle(Convert.ToInt16(label1.Text), 0, Convert.ToInt16(textBox2.Text),dateTimePicker1.Text,textBox1.Text);
            this.Close();
        }

        private void ÖdemeAl_Load(object sender, EventArgs e)
        {

        }
    }
}
