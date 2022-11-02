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
using System.IO;

namespace MusteriTakip
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=musteriTakip;Integrated Security=true");

        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.KategorilerTableAdapter ta = new DataSet1TableAdapters.KategorilerTableAdapter();
            //Göstereceğin kategorinin adının gelmesi için :
            comboBox1.DisplayMember = "KategoriAdi";
            //Arka planda kategori numarası işlem yapsın :
            comboBox1.ValueMember = "KategoriNo";
            comboBox1.DataSource = ta.GetKategoriler();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            verilerigoster("Select *from tableUrun");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataSet1TableAdapters.tableUrunTableAdapter urun = new DataSet1TableAdapters.tableUrunTableAdapter();
            urun.YeniUrun(Convert.ToInt16(textBox1.Text),textBox2.Text, Convert.ToInt16(textBox4.Text), Convert.ToInt16(textBox3.Text), Convert.ToInt16(comboBox1.SelectedValue.ToString()));

            verilerigoster("Select * from tableUrun");

           /* baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into tableUrun (urunID,urunAdi,urunAdedi,urunFiyati,Kategori) values(@id,@adi,@adedi,@fiyati,@kategori)",baglanti);
            komut.Parameters.AddWithValue("@id",textBox1.Text);
            komut.Parameters.AddWithValue("@adi", textBox2.Text);
            komut.Parameters.AddWithValue("@adedi", textBox3.Text);
            komut.Parameters.AddWithValue("@fiyati", textBox4.Text);
            komut.Parameters.AddWithValue("@kategori",comboBox1.Text);
            //Gelen parametrelerin üzerinde değişiklik yapıp onları kullanıcıya göstermesi için :
            komut.ExecuteNonQuery();
            verilerigoster("Select * from tableUrun");
            baglanti.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();*/

           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE  FROM tableUrun WHERE urunAdi='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
           // MessageBox.Show("sildin");
            verilerigoster("Select *from tableUrun");
            baglanti.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tableUrun where urunAdi like '" + textBox5.Text + "%'", baglanti);
            //Sadece istediğimiz alanların gelmesi için :
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            //sıfırıncı değerden itibaren almak için : 
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tableUrun set urunID='" + textBox1.Text + "',urunAdi='" + textBox2.Text + "',urunFiyati='" + textBox4.Text + "',urunAdedi='" + textBox3.Text + "' where urunAdi='" + textBox2.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            verilerigoster("Select * from tableUrun");
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            //Seçili alanın sıfırıncı hücresindeki değeri string olarak ad isimli değişkende tutmak için:
            string urunID = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string urunAdi = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string urunAdedi = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string urunFiyati = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string Kategori = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();

            textBox1.Text = urunID;
            textBox2.Text = urunAdi;
            textBox4.Text = urunAdedi;
            textBox3.Text = urunFiyati;
            comboBox1.Text = Kategori;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Alış alış = new Alış();
           DataGridViewRow urun = dataGridView1.CurrentRow;
           alış.label1.Text = urun.Cells["urunAdi"].Value.ToString();
           alış.label2.Text = urun.Cells["urunID"].Value.ToString();
           alış.Show();

           verilerigoster("Select * from tableUrun");
           this.Close();
        }

       
        }
    }

