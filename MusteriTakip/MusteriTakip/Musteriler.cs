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
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;


namespace MusteriTakip
{

    public partial class Musteriler : Form
    {

        public Musteriler()
        {
            InitializeComponent();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listele();

        }
        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=musteriTakip;Integrated Security=true");
        Form2 frm2 = new Form2();

        void listele()
        {
            bag.Open();
            //Veritabanından tüm bilgileri getirmek için
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT *FROM SonMusteri", bag);
            DataSet ds = new DataSet();
            System.Data.DataTable tablo = new System.Data.DataTable();

            //Tüm tabloyu kaplayacak şekilde yazar
            adptr.Fill(tablo);
            //Tabloyu Datagridview'e aktararak gridview'i tablo gibi gösterir
            dataGridView1.DataSource = tablo;
            bag.Close();
        }


        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, bag);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }






        private void button2_Click_1(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("DELETE  FROM SonMusteri WHERE MusteriNo='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            //MessageBox.Show("sildin");
            listele();


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand komut = new SqlCommand("UPDATE SonMusteri SET MusteriAdi='" + textBox2.Text + "',MusteriSoyadi='" + textBox3.Text + "',borc='" + textBox7.Text + "',eposta='" + textBox5.Text + "',telefon='" + maskedTextBox1.Text + "',aldigiürün='" + comboBox1.Text + "',Tarih='" + textBox4.Text + "' where MusteriAdi='" + textBox2.Text + "'", bag);
            komut.ExecuteNonQuery();
            //textBox10.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            //comboBox1.Clear();
            textBox7.Clear();

            verilerigoster("Select * from SonMusteri");
            bag.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            string MusteriNo = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            string MusteriAdi = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            string MusteriSoyadi = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            string borc = dataGridView1.Rows[secili].Cells[3].Value.ToString();
            string eposta = dataGridView1.Rows[secili].Cells[4].Value.ToString();
            string telefon = dataGridView1.Rows[secili].Cells[5].Value.ToString();


            string aldigiürün = dataGridView1.Rows[secili].Cells[6].Value.ToString();
            string Tarih = dataGridView1.Rows[secili].Cells[7].Value.ToString();



            //textBox10.Text = MusteriNo;
            textBox2.Text = MusteriAdi;
            textBox3.Text = MusteriSoyadi;
            textBox7.Text = borc;
            textBox4.Text = Tarih;
            maskedTextBox1.Text = telefon;
            textBox5.Text = eposta;
            comboBox1.Text = aldigiürün;
            //dateTimePicker1.Text = Tarih;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //Veritabanından tüm bilgileri getirmek için
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT *FROM SonMusteri WHERE MusteriAdi LIKE '" + textBox1.Text + "%'", bag);
            System.Data.DataTable tablo1 = new System.Data.DataTable();
            tablo1.Clear();
            bag.Open();
            //Tüm tabloyu kaplayacak şekilde yazar
            adtr.Fill(tablo1);
            //Tabloyu Datagridview'e aktararak gridview'i tablo gibi gösterir
            dataGridView1.DataSource = tablo1;
            bag.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Borç_ekle brç = new Borç_ekle();
            brç.Show();


        }



        private void button4_Click_2(object sender, EventArgs e)
        {

            //Veritabanından tüm bilgileri getirmek için
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT *FROM MusteriDetay  WHERE MusteriNo LIKE '" + textBox6.Text + "%'", bag);
            System.Data.DataTable tablo1 = new System.Data.DataTable();
            tablo1.Clear();
            bag.Open();
            //Tüm tabloyu kaplayacak şekilde yazar
            adtr.Fill(tablo1);
            //Tabloyu Datagridview'e aktararak gridview'i tablo gibi gösterir
            dataGridView1.DataSource = tablo1;
            bag.Close();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible=true;
            //ws.Cells[1, 1] = "  MusteriNo";
            ws.Cells[1, 2] = "EklenenTutar";
            ws.Cells[1, 3] = "OdenenTutar";
            ws.Cells[1, 4] = "Acıklama";
            ws.Cells[1, 5] = "Tarih";

            for (int j = 2; j <= dataGridView1.Rows.Count; j++)
            {
                for (int i = 2; i <= 5; i++)
                {
                    ws.Cells[j,i]=dataGridView1.Rows[j-2].Cells[i-1].Value;
                }
            
            }
            
        }
       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}