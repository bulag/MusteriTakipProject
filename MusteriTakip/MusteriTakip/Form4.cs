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
    public partial class Form4 : Form
    {
        int iSlide = 0;
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = ımageList1.Images[0];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            iSlide = iSlide + 1;
            {
                switch (iSlide)
                {
                    case 1:
                        iSlide = 1;
                        pictureBox1.Image = ımageList1.Images[1];
                        break;
                    case 2:
                        iSlide = 2;
                        pictureBox1.Image = ımageList1.Images[2];
                        break;
                    case 3:
                        iSlide = 3;
                        pictureBox1.Image = ımageList1.Images[3];
                        break;
                    case 4:
                        iSlide = 4;
                        pictureBox1.Image = ımageList1.Images[4];
                        break;
                    case 5:
                        iSlide = 5;
                        pictureBox1.Image = ımageList1.Images[5];
                        break;
                    case 6:
                        iSlide = 6;
                        pictureBox1.Image = ımageList1.Images[6];
                        break;
                    case 7:
                        iSlide = 7;
                        pictureBox1.Image = ımageList1.Images[7];
                        break;
                    case 8:
                        iSlide = 8;
                        pictureBox1.Image = ımageList1.Images[8];
                        break;
                    case 9:
                        iSlide = 9;
                        pictureBox1.Image = ımageList1.Images[9];
                        break;
                    case 10:
                        iSlide = 10;
                        pictureBox1.Image = ımageList1.Images[10];
                        break;
                    case 11:
                        iSlide = 11;
                        pictureBox1.Image = ımageList1.Images[11];
                        break;
                    case 12:
                        iSlide = 12;
                        pictureBox1.Image = ımageList1.Images[12];
                        break;
                    case 13:
                        iSlide = 1;
                        pictureBox1.Image = ımageList1.Images[13];
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iSlide = iSlide + 1;
            {
                switch (iSlide)
                {
                    case 1:
                        iSlide = 1;
                        pictureBox1.Image = ımageList1.Images[13];
                        break;
                    case 2:
                        iSlide = 2;
                        pictureBox1.Image = ımageList1.Images[12];
                        break;
                    case 3:
                        iSlide = 3;
                        pictureBox1.Image = ımageList1.Images[11];
                        break;
                    case 4:
                        iSlide = 4;
                        pictureBox1.Image = ımageList1.Images[10];
                        break;
                    case 5:
                        iSlide = 5;
                        pictureBox1.Image = ımageList1.Images[9];
                        break;
                    case 6:
                        iSlide = 6;
                        pictureBox1.Image = ımageList1.Images[8];
                        break;
                    case 7:
                        iSlide = 7;
                        pictureBox1.Image = ımageList1.Images[7];
                        break;
                    case 8:
                        iSlide = 8;
                        pictureBox1.Image = ımageList1.Images[6];
                        break;
                    case 9:
                        iSlide = 9;
                        pictureBox1.Image = ımageList1.Images[5];
                        break;
                    case 10:
                        iSlide = 10;
                        pictureBox1.Image = ımageList1.Images[4];
                        break;
                    case 11:
                        iSlide = 11;
                        pictureBox1.Image = ımageList1.Images[3];
                        break;
                    case 12:
                        iSlide = 12;
                        pictureBox1.Image = ımageList1.Images[2];
                        break;
                    case 13:
                        iSlide = 1;
                        pictureBox1.Image = ımageList1.Images[1];
                        break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
