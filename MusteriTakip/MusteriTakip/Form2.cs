using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTakip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=musteriTakip;Integrated Security=true");


        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteriler mus = new Musteriler();
            SqlCommand komut = new SqlCommand("INSERT INTO SonMusteri(MusteriAdi,MusteriSoyadi,borc,eposta,telefon,aldigiürün,Tarih) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox7.Text + "','" + textBox5.Text + "','" +maskedTextBox1.Text + "','" + comboBox1.Text + "','"+textBox1.Text+"')", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            //MessageBox.Show("basarlı");
            mus.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HESAP hsp = new HESAP();
            hsp.Show();
        }
    }
}
