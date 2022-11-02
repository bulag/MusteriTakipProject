namespace MusteriTakip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gençodasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çocukodasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bebekodasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahsilatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topluEMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "müsteriBilgileri.jpg");
            this.ımageList1.Images.SetKeyName(1, "yeniKayit.png");
            this.ımageList1.Images.SetKeyName(2, "cikis.jpg");
            this.ımageList1.Images.SetKeyName(3, "kayıt.jpg");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünİşlemleriToolStripMenuItem,
            this.tahsilatToolStripMenuItem,
            this.hesapMakinesiToolStripMenuItem,
            this.topluEMailToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gençodasıToolStripMenuItem,
            this.çocukodasıToolStripMenuItem,
            this.bebekodasıToolStripMenuItem,
            this.kategoriEkleToolStripMenuItem});
            this.ürünİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(141, 25);
            this.ürünİşlemleriToolStripMenuItem.Text = "Ürün Kategorisi";
            // 
            // gençodasıToolStripMenuItem
            // 
            this.gençodasıToolStripMenuItem.Name = "gençodasıToolStripMenuItem";
            this.gençodasıToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.gençodasıToolStripMenuItem.Text = "Genç Odası";
            this.gençodasıToolStripMenuItem.Click += new System.EventHandler(this.gençodasıToolStripMenuItem_Click);
            // 
            // çocukodasıToolStripMenuItem
            // 
            this.çocukodasıToolStripMenuItem.Name = "çocukodasıToolStripMenuItem";
            this.çocukodasıToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.çocukodasıToolStripMenuItem.Text = "Çocuk Odası";
            this.çocukodasıToolStripMenuItem.Click += new System.EventHandler(this.çocukodasıToolStripMenuItem_Click);
            // 
            // bebekodasıToolStripMenuItem
            // 
            this.bebekodasıToolStripMenuItem.Name = "bebekodasıToolStripMenuItem";
            this.bebekodasıToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.bebekodasıToolStripMenuItem.Text = "Bebek Odası";
            this.bebekodasıToolStripMenuItem.Click += new System.EventHandler(this.bebekodasıToolStripMenuItem_Click);
            // 
            // kategoriEkleToolStripMenuItem
            // 
            this.kategoriEkleToolStripMenuItem.Name = "kategoriEkleToolStripMenuItem";
            this.kategoriEkleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.kategoriEkleToolStripMenuItem.Text = "Kategori Ekle";
            this.kategoriEkleToolStripMenuItem.Click += new System.EventHandler(this.kategoriEkleToolStripMenuItem_Click);
            // 
            // tahsilatToolStripMenuItem
            // 
            this.tahsilatToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tahsilatToolStripMenuItem.Name = "tahsilatToolStripMenuItem";
            this.tahsilatToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.tahsilatToolStripMenuItem.Text = "Tahsilat";
            this.tahsilatToolStripMenuItem.Click += new System.EventHandler(this.tahsilatToolStripMenuItem_Click);
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(142, 25);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            this.hesapMakinesiToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinesiToolStripMenuItem_Click);
            // 
            // topluEMailToolStripMenuItem
            // 
            this.topluEMailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topluEMailToolStripMenuItem.Name = "topluEMailToolStripMenuItem";
            this.topluEMailToolStripMenuItem.Size = new System.Drawing.Size(131, 25);
            this.topluEMailToolStripMenuItem.Text = "E-Mail Gönder";
            this.topluEMailToolStripMenuItem.Click += new System.EventHandler(this.topluEMailToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MusteriTakip.Properties.Resources.image;
            this.pictureBox6.Location = new System.Drawing.Point(344, 44);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(300, 102);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MusteriTakip.Properties.Resources.Angel;
            this.pictureBox5.Location = new System.Drawing.Point(247, 152);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(611, 255);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MusteriTakip.Properties.Resources.Bella;
            this.pictureBox4.Location = new System.Drawing.Point(247, 152);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(611, 255);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MusteriTakip.Properties.Resources.Jasmin;
            this.pictureBox3.Location = new System.Drawing.Point(247, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(611, 255);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MusteriTakip.Properties.Resources.Laura;
            this.pictureBox2.Location = new System.Drawing.Point(247, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(611, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusteriTakip.Properties.Resources.Summer;
            this.pictureBox1.Location = new System.Drawing.Point(247, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.ImageKey = "cikis.jpg";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(28, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 78);
            this.button4.TabIndex = 3;
            this.button4.Text = "Çıkış";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageKey = "kayıt.jpg";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(28, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 78);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ürün Kayıt";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageKey = "yeniKayit.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(28, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "Müşteri Kayıt";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "müsteriBilgileri.jpg";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(28, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Müşteri Bilgileri";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(692, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(677, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(911, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Takip Newjoy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gençodasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çocukodasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bebekodasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topluEMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tahsilatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriEkleToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
    }
}

