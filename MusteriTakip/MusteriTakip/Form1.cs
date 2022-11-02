using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MusteriTakip
{
    public partial class Form1 : Form
    {
        Form2 frm = new Form2();
        Form3 frm1= new Form3();
        Mail m = new Mail();
        Musteriler mus = new Musteriler();
        public Form1()
        {
            InitializeComponent();
        }
        public OleDbConnection baglanti = new OleDbConnection();
        public OleDbCommand komut = new OleDbCommand();
        public OleDbDataAdapter adapter = new OleDbDataAdapter();
        public DataSet dtst = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            mus.Show();
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\new joy.png");
            timer1.Start();
            timer2.Start();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Height += 15;
            button1.Width += 15;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Height -= 15;
            button1.Width -= 15;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Height += 10;
            button2.Width += 10;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Height -= 10;
            button2.Width -= 10;
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Height += 10;
            button3.Width += 10;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Height -= 10;
            button3.Width -= 10;
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Height += 10;
            button4.Width += 10;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Height -= 10;
            button4.Width -= 10;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
        }
        private void kampanyaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m.Show();
            this.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }

            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }

            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox1.Visible = true;
            }
        }
        private void gençodasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }
        private void bebekodasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bebek baby = new bebek();
            baby.Show();
            this.Hide();
        }
        private void çocukodasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cocuk ç = new cocuk();
            ç.Show();
            this.Hide();
        }
        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkımızda hakkı = new Hakkımızda();
            hakkı.Show();
            this.Hide();
        }
        private void topluEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mail m = new Mail();
            m.Show();
            this.Hide();
        }
        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HESAP hsp = new HESAP();
            hsp.Show();
        }
        private void tahsilatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tahsilat tahsilat = new Tahsilat();
            tahsilat.Show();
            this.Hide();  
        }
        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kategori_Ekle ke = new Kategori_Ekle();
            ke.Show();
            this.Hide();  
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToShortDateString();
        }
    }
}
