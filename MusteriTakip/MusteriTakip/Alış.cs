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
    public partial class Alış : Form
    {
        public Alış()
        {
            InitializeComponent();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 uc = new Form3();
            DataSet1TableAdapters.tableUrunTableAdapter ta = new DataSet1TableAdapters.tableUrunTableAdapter();
            ta.AdetArtir(Convert.ToInt16(textBox1.Text), Convert.ToInt16(label2.Text));
            uc.Show();

           
        }

        private void Alış_Load(object sender, EventArgs e)
        {

        }
    }
}
