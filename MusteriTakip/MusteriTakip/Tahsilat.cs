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
    public partial class Tahsilat : Form
    {
        public Tahsilat()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=musteriTakip;Integrated Security=true");

        void listele()
        {
            bag.Open();
            //Veritabanından tüm bilgileri getirmek için
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM    SonMusteri", bag);
            DataSet ds = new DataSet();
            DataTable tablo = new DataTable();

            //Tüm tabloyu kaplayacak şekilde yazar
            adptr.Fill(tablo);
            //Tabloyu Datagridview'e aktararak gridview'i tablo gibi gösterir
            dataGridView1.DataSource = tablo;
            bag.Close();
        }

        private void Tahsilat_Load(object sender, EventArgs e)
        {
            //Bu satırı sütun sütun değilde satrın tümünü seçer 
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listele();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilisatır;

            secilisatır = dataGridView1.CurrentRow;
            Borç_ekle b = new Borç_ekle();
            //b.label5.Text = secilisatır.Cells["adi"].Value.ToString() +"  "+ secilisatır.Cells["soyadi"].Value.ToString();
            b.label1.Text = secilisatır.Cells["MusteriNo"].Value.ToString();
            b.label5.Text = secilisatır.Cells["MusteriAdi"].Value.ToString()+" "+secilisatır.Cells["MusteriSoyadi"].Value.ToString();
            b.ShowDialog();
            
            listele();


          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilisatır;

            secilisatır = dataGridView1.CurrentRow;
            ÖdemeAl b = new ÖdemeAl();
            //b.label5.Text = secilisatır.Cells["adi"].Value.ToString() +"  "+ secilisatır.Cells["soyadi"].Value.ToString();
            b.label1.Text = secilisatır.Cells["MusteriNo"].Value.ToString();
            b.label5.Text = secilisatır.Cells["MusteriAdi"].Value.ToString() + " " + secilisatır.Cells["MusteriSoyadi"].Value.ToString();
            b.ShowDialog();
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
