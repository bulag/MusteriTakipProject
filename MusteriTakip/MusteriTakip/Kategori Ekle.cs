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
    public partial class Kategori_Ekle : Form
    {
        public Kategori_Ekle()
        {
            InitializeComponent();
        }

        private void Kategori_Ekle_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.KategorilerTableAdapter ta = new DataSet1TableAdapters.KategorilerTableAdapter();
            dataGridView1.DataSource = ta.GetKategoriler();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // if (String.IsNullOrWhiteSpace(textBox1.Text)) 
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("kategori alanı boş olamaz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            else
            {
                DataSet1TableAdapters.KategorilerTableAdapter ta = new DataSet1TableAdapters.KategorilerTableAdapter();
                ta.KategoriEkle(textBox1.Text);
                dataGridView1.DataSource = ta.GetKategoriler();
                textBox1.Text = "";
            }
            

           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
