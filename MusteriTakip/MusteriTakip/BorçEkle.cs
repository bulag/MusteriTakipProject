using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MusteriTakip
{
    public partial class Borç_ekle : Form
    {
        public Borç_ekle()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=musteriTakip;Integrated Security=true");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
      
        private void button1_Click(object sender, EventArgs e)
        {
            
            DataSet1TableAdapters.MusteriDetayTableAdapter taMusteriDetay = new DataSet1TableAdapters.MusteriDetayTableAdapter();
            DataSet1TableAdapters.SonMusteriTableAdapter dt = new DataSet1TableAdapters.SonMusteriTableAdapter();

            taMusteriDetay.DetayEkle(Convert.ToInt16(label1.Text), Convert.ToInt16(textBox2.Text), 0, dateTimePicker1.Text,textBox1.Text);
            dt.BorcArtir(Convert.ToInt16(textBox2.Text), Convert.ToInt16(label1.Text));
            
            this.Close();
        }

        private void Borç_ekle_Load(object sender, EventArgs e)
        {

        }
        
    }
}
