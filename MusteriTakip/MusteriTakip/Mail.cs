using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;
using System.Net;
using System.Net.Mail;


namespace MusteriTakip
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            MailMessage mesajım = new MailMessage();
            mesajım.From = new MailAddress(textBox5.Text);
            mesajım.To.Add(textBox1.Text);
            mesajım.Subject = textBox2.Text;
            mesajım.Body = textBox3.Text;
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("magazabudur@gmail.com", "123456987*.");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            object userstate = mesajım;
            istemci.Send(mesajım);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();

        }
       /* private void button2_Click_1(object sender, EventArgs e)
        {
            MailMessage mesajım = new MailMessage();
            string dosya;
            openFileDialog1.Title = "Eklenecek dosyayı seç";
            openFileDialog1.ShowDialog();
            dosya = openFileDialog1.FileName;
            mesajım.Attachments.Add(new Attachment(dosya));
            textBox4.Text = dosya.ToString();
        }*/
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
