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
    public partial class HESAP : Form
    {
        double value = 0;
        String operation="";
        bool operation_pressed = false;
        public HESAP()
        {
            InitializeComponent();
        }

        private void HESAP_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operation_pressed))
                textBox1.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void ce_click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(textBox1.Text);
            operation_pressed = true;



        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case"+":
                    textBox1.Text=(value+double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            value = 0;
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text==" ")|(textBox1.Text.EndsWith(".")))
            {
                textBox1.Text += " ";
            }
            else
            {
                textBox1.Text += ".";
            }
        }

       
    }
}
