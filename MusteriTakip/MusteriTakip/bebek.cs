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
    public partial class bebek : Form
    {
        public bebek()
        {
            InitializeComponent();
        }
        // . beni Data sourcenin olduğu yere götürür
        SqlConnection bag = new SqlConnection("Data Source=.;Initial Catalog=musteriTakip;Integrated Security=true");
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();

       


        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bebek_Load(object sender, EventArgs e)
        {

        }

     
    }
}
