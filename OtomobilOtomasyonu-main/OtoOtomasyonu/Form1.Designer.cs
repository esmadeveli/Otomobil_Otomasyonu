namespace OtoOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            iptal = new PictureBox();
            lblAracMarkasi = new Label();
            lblAracModeli = new Label();
            lblYil = new Label();
            lblYakitTuru = new Label();
            lblVites = new Label();
            lblKilometre = new Label();
            lblRenk = new Label();
            lblFiyat = new Label();
            lblKasaTipi = new Label();
            lblDurumu = new Label();
            lblIlIlce = new Label();
            txtYakitTuru = new TextBox();
            txtKasaTipi = new TextBox();
            txtRenk = new TextBox();
            txtVites = new TextBox();
            txtAracMarkasi = new TextBox();
            txtAracModeli = new TextBox();
            cmbDurumu = new ComboBox();
            txtKilometre = new TextBox();
            txtYil = new TextBox();
            txtFiyat = new TextBox();
            txtIlIlce = new TextBox();
            txtAracBilgi = new TextBox();
            İlanKaydet = new Button();
            ilankapat = new Button();
            İlanekleme = new Label();
            Sayfakapat = new Label();
            Resim = new GroupBox();
            Linkkaldir = new LinkLabel();
            Linkekle = new LinkLabel();
            aracresim = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            Bilgi = new GroupBox();
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)iptal).BeginInit();
            Resim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)aracresim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // iptal
            // 
            iptal.BackColor = Color.HotPink;
            iptal.BackgroundImage = (Image)resources.GetObject("iptal.BackgroundImage");
            iptal.BackgroundImageLayout = ImageLayout.Stretch;
            iptal.Location = new Point(1, -5);
            iptal.Name = "iptal";
            iptal.Size = new Size(1277, 742);
            iptal.TabIndex = 1;
            iptal.TabStop = false;
            // 
            // lblAracMarkasi
            // 
            lblAracMarkasi.AllowDrop = true;
            lblAracMarkasi.AutoEllipsis = true;
            lblAracMarkasi.BackColor = Color.HotPink;
            lblAracMarkasi.Enabled = false;
            lblAracMarkasi.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAracMarkasi.ForeColor = SystemColors.InfoText;
            lblAracMarkasi.Location = new Point(39, 18);
            lblAracMarkasi.Name = "lblAracMarkasi";
            lblAracMarkasi.Size = new Size(116, 26);
            lblAracMarkasi.TabIndex = 4;
            lblAracMarkasi.Text = "Araç Markası";
            lblAracMarkasi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAracModeli
            // 
            lblAracModeli.AllowDrop = true;
            lblAracModeli.AutoEllipsis = true;
            lblAracModeli.BackColor = Color.HotPink;
            lblAracModeli.Enabled = false;
            lblAracModeli.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAracModeli.ForeColor = SystemColors.InfoText;
            lblAracModeli.Location = new Point(39, 71);
            lblAracModeli.Name = "lblAracModeli";
            lblAracModeli.Size = new Size(116, 26);
            lblAracModeli.TabIndex = 5;
            lblAracModeli.Text = "Araç Modeli";
            lblAracModeli.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblYil
            // 
            lblYil.AllowDrop = true;
            lblYil.AutoEllipsis = true;
            lblYil.BackColor = Color.HotPink;
            lblYil.Enabled = false;
            lblYil.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblYil.ForeColor = SystemColors.InfoText;
            lblYil.Location = new Point(339, 7);
            lblYil.Name = "lblYil";
            lblYil.Size = new Size(117, 31);
            lblYil.TabIndex = 7;
            lblYil.Text = "Yıl";
            lblYil.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblYakitTuru
            // 
            lblYakitTuru.AllowDrop = true;
            lblYakitTuru.AutoEllipsis = true;
            lblYakitTuru.BackColor = Color.HotPink;
            lblYakitTuru.Enabled = false;
            lblYakitTuru.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblYakitTuru.ForeColor = SystemColors.InfoText;
            lblYakitTuru.Location = new Point(687, 145);
            lblYakitTuru.Name = "lblYakitTuru";
            lblYakitTuru.Size = new Size(119, 24);
            lblYakitTuru.TabIndex = 8;
            lblYakitTuru.Text = "Yakıt Türü";
            lblYakitTuru.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVites
            // 
            lblVites.AllowDrop = true;
            lblVites.AutoEllipsis = true;
            lblVites.BackColor = Color.HotPink;
            lblVites.Enabled = false;
            lblVites.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVites.ForeColor = SystemColors.InfoText;
            lblVites.Location = new Point(687, 13);
            lblVites.Name = "lblVites";
            lblVites.Size = new Size(119, 25);
            lblVites.TabIndex = 9;
            lblVites.Text = "Vites";
            lblVites.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKilometre
            // 
            lblKilometre.AllowDrop = true;
            lblKilometre.AutoEllipsis = true;
            lblKilometre.BackColor = Color.HotPink;
            lblKilometre.Enabled = false;
            lblKilometre.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblKilometre.ForeColor = SystemColors.InfoText;
            lblKilometre.Location = new Point(1017, 18);
            lblKilometre.Name = "lblKilometre";
            lblKilometre.Size = new Size(119, 28);
            lblKilometre.TabIndex = 10;
            lblKilometre.Text = "Kilometre(KM)";
            lblKilometre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRenk
            // 
            lblRenk.AllowDrop = true;
            lblRenk.AutoEllipsis = true;
            lblRenk.BackColor = Color.HotPink;
            lblRenk.Enabled = false;
            lblRenk.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRenk.ForeColor = SystemColors.InfoText;
            lblRenk.Location = new Point(337, 132);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(119, 26);
            lblRenk.TabIndex = 11;
            lblRenk.Text = "Renk";
            lblRenk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFiyat
            // 
            lblFiyat.AllowDrop = true;
            lblFiyat.AutoEllipsis = true;
            lblFiyat.BackColor = Color.HotPink;
            lblFiyat.Enabled = false;
            lblFiyat.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiyat.ForeColor = SystemColors.InfoText;
            lblFiyat.Location = new Point(339, 71);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(117, 30);
            lblFiyat.TabIndex = 12;
            lblFiyat.Text = "Fiyat";
            lblFiyat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKasaTipi
            // 
            lblKasaTipi.AllowDrop = true;
            lblKasaTipi.AutoEllipsis = true;
            lblKasaTipi.BackColor = Color.HotPink;
            lblKasaTipi.Enabled = false;
            lblKasaTipi.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblKasaTipi.ForeColor = SystemColors.InfoText;
            lblKasaTipi.Location = new Point(1017, 79);
            lblKasaTipi.Name = "lblKasaTipi";
            lblKasaTipi.Size = new Size(119, 26);
            lblKasaTipi.TabIndex = 13;
            lblKasaTipi.Text = "Kasa Tipi";
            lblKasaTipi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDurumu
            // 
            lblDurumu.AllowDrop = true;
            lblDurumu.AutoEllipsis = true;
            lblDurumu.BackColor = Color.HotPink;
            lblDurumu.Enabled = false;
            lblDurumu.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDurumu.ForeColor = SystemColors.InfoText;
            lblDurumu.Location = new Point(687, 77);
            lblDurumu.Name = "lblDurumu";
            lblDurumu.Size = new Size(119, 24);
            lblDurumu.TabIndex = 16;
            lblDurumu.Text = "Durumu";
            lblDurumu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIlIlce
            // 
            lblIlIlce.AllowDrop = true;
            lblIlIlce.AutoEllipsis = true;
            lblIlIlce.BackColor = Color.HotPink;
            lblIlIlce.Enabled = false;
            lblIlIlce.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIlIlce.ForeColor = SystemColors.InfoText;
            lblIlIlce.Location = new Point(42, 127);
            lblIlIlce.Name = "lblIlIlce";
            lblIlIlce.Size = new Size(117, 29);
            lblIlIlce.TabIndex = 17;
            lblIlIlce.Text = "İl/İlçe";
            lblIlIlce.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtYakitTuru
            // 
            txtYakitTuru.Location = new Point(836, 145);
            txtYakitTuru.Multiline = true;
            txtYakitTuru.Name = "txtYakitTuru";
            txtYakitTuru.Size = new Size(127, 24);
            txtYakitTuru.TabIndex = 21;
            // 
            // txtKasaTipi
            // 
            txtKasaTipi.Location = new Point(1142, 79);
            txtKasaTipi.Multiline = true;
            txtKasaTipi.Name = "txtKasaTipi";
            txtKasaTipi.Size = new Size(127, 26);
            txtKasaTipi.TabIndex = 25;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(489, 132);
            txtRenk.Multiline = true;
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(139, 26);
            txtRenk.TabIndex = 26;
            // 
            // txtVites
            // 
            txtVites.Location = new Point(836, 15);
            txtVites.Multiline = true;
            txtVites.Name = "txtVites";
            txtVites.Size = new Size(127, 26);
            txtVites.TabIndex = 27;
            // 
            // txtAracMarkasi
            // 
            txtAracMarkasi.Location = new Point(182, 18);
            txtAracMarkasi.Multiline = true;
            txtAracMarkasi.Name = "txtAracMarkasi";
            txtAracMarkasi.Size = new Size(127, 26);
            txtAracMarkasi.TabIndex = 30;
            // 
            // txtAracModeli
            // 
            txtAracModeli.Location = new Point(182, 73);
            txtAracModeli.Multiline = true;
            txtAracModeli.Name = "txtAracModeli";
            txtAracModeli.Size = new Size(127, 26);
            txtAracModeli.TabIndex = 31;
            // 
            // cmbDurumu
            // 
            cmbDurumu.FormattingEnabled = true;
            cmbDurumu.Location = new Point(836, 77);
            cmbDurumu.Name = "cmbDurumu";
            cmbDurumu.Size = new Size(127, 28);
            cmbDurumu.TabIndex = 32;
            // 
            // txtKilometre
            // 
            txtKilometre.Location = new Point(1142, 19);
            txtKilometre.Multiline = true;
            txtKilometre.Name = "txtKilometre";
            txtKilometre.Size = new Size(127, 28);
            txtKilometre.TabIndex = 34;
            // 
            // txtYil
            // 
            txtYil.Location = new Point(489, 9);
            txtYil.Multiline = true;
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(139, 31);
            txtYil.TabIndex = 35;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(489, 69);
            txtFiyat.Multiline = true;
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(139, 30);
            txtFiyat.TabIndex = 36;
            // 
            // txtIlIlce
            // 
            txtIlIlce.Location = new Point(182, 130);
            txtIlIlce.Multiline = true;
            txtIlIlce.Name = "txtIlIlce";
            txtIlIlce.Size = new Size(127, 28);
            txtIlIlce.TabIndex = 37;
            // 
            // txtAracBilgi
            // 
            txtAracBilgi.BackColor = Color.AliceBlue;
            txtAracBilgi.BorderStyle = BorderStyle.None;
            txtAracBilgi.ForeColor = SystemColors.InactiveCaptionText;
            txtAracBilgi.Location = new Point(1035, 312);
            txtAracBilgi.Multiline = true;
            txtAracBilgi.Name = "txtAracBilgi";
            txtAracBilgi.Size = new Size(220, 135);
            txtAracBilgi.TabIndex = 41;
            // 
            // İlanKaydet
            // 
            İlanKaydet.FlatStyle = FlatStyle.Flat;
            İlanKaydet.ForeColor = SystemColors.WindowFrame;
            İlanKaydet.Image = (Image)resources.GetObject("İlanKaydet.Image");
            İlanKaydet.Location = new Point(1159, 515);
            İlanKaydet.Name = "İlanKaydet";
            İlanKaydet.RightToLeft = RightToLeft.Yes;
            İlanKaydet.Size = new Size(46, 37);
            İlanKaydet.TabIndex = 42;
            İlanKaydet.UseVisualStyleBackColor = true;
            İlanKaydet.Click += İlanKaydet_Click;
            // 
            // ilankapat
            // 
            ilankapat.FlatStyle = FlatStyle.Flat;
            ilankapat.ForeColor = SystemColors.Highlight;
            ilankapat.Image = (Image)resources.GetObject("ilankapat.Image");
            ilankapat.Location = new Point(1159, 577);
            ilankapat.Name = "ilankapat";
            ilankapat.Size = new Size(46, 37);
            ilankapat.TabIndex = 43;
            ilankapat.UseVisualStyleBackColor = true;
            ilankapat.Click += button2_Click;
            // 
            // İlanekleme
            // 
            İlanekleme.BackColor = Color.HotPink;
            İlanekleme.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            İlanekleme.ForeColor = Color.Black;
            İlanekleme.Location = new Point(1076, 515);
            İlanekleme.Name = "İlanekleme";
            İlanekleme.Size = new Size(60, 37);
            İlanekleme.TabIndex = 44;
            İlanekleme.Text = "İlan Ekle";
            İlanekleme.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Sayfakapat
            // 
            Sayfakapat.BackColor = Color.HotPink;
            Sayfakapat.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Sayfakapat.Location = new Point(1076, 577);
            Sayfakapat.Name = "Sayfakapat";
            Sayfakapat.Size = new Size(60, 37);
            Sayfakapat.TabIndex = 45;
            Sayfakapat.Text = "Kapat";
            Sayfakapat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Resim
            // 
            Resim.BackColor = Color.DeepPink;
            Resim.Controls.Add(Linkkaldir);
            Resim.Controls.Add(Linkekle);
            Resim.Controls.Add(aracresim);
            Resim.Font = new Font("Tahoma", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Resim.Location = new Point(42, 198);
            Resim.Name = "Resim";
            Resim.Size = new Size(267, 174);
            Resim.TabIndex = 46;
            Resim.TabStop = false;
            Resim.Text = "Araç Görseli";
            // 
            // Linkkaldir
            // 
            Linkkaldir.AutoSize = true;
            Linkkaldir.LinkColor = Color.White;
            Linkkaldir.Location = new Point(149, 148);
            Linkkaldir.Name = "Linkkaldir";
            Linkkaldir.Size = new Size(88, 21);
            Linkkaldir.TabIndex = 3;
            Linkkaldir.TabStop = true;
            Linkkaldir.Text = "Resim Sil";
            // 
            // Linkekle
            // 
            Linkekle.AutoSize = true;
            Linkekle.LinkColor = Color.White;
            Linkekle.Location = new Point(6, 148);
            Linkekle.Name = "Linkekle";
            Linkekle.Size = new Size(102, 21);
            Linkekle.TabIndex = 2;
            Linkekle.TabStop = true;
            Linkekle.Text = "Resim Ekle";
            Linkekle.LinkClicked += ResimSec;
            // 
            // aracresim
            // 
            aracresim.BackColor = SystemColors.Control;
            aracresim.Location = new Point(-3, 27);
            aracresim.Name = "aracresim";
            aracresim.Size = new Size(270, 108);
            aracresim.TabIndex = 0;
            aracresim.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Bilgi
            // 
            Bilgi.BackColor = Color.Crimson;
            Bilgi.Font = new Font("Tahoma", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Bilgi.Location = new Point(1035, 289);
            Bilgi.Name = "Bilgi";
            Bilgi.Size = new Size(220, 175);
            Bilgi.TabIndex = 48;
            Bilgi.TabStop = false;
            Bilgi.Text = "Bilgi";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 717);
            Controls.Add(txtAracBilgi);
            Controls.Add(Bilgi);
            Controls.Add(İlanKaydet);
            Controls.Add(Resim);
            Controls.Add(Sayfakapat);
            Controls.Add(İlanekleme);
            Controls.Add(ilankapat);
            Controls.Add(txtIlIlce);
            Controls.Add(txtFiyat);
            Controls.Add(txtYil);
            Controls.Add(txtKilometre);
            Controls.Add(cmbDurumu);
            Controls.Add(txtAracModeli);
            Controls.Add(txtAracMarkasi);
            Controls.Add(txtVites);
            Controls.Add(txtRenk);
            Controls.Add(txtKasaTipi);
            Controls.Add(txtYakitTuru);
            Controls.Add(lblIlIlce);
            Controls.Add(lblDurumu);
            Controls.Add(lblKasaTipi);
            Controls.Add(lblFiyat);
            Controls.Add(lblRenk);
            Controls.Add(lblKilometre);
            Controls.Add(lblVites);
            Controls.Add(lblYakitTuru);
            Controls.Add(lblYil);
            Controls.Add(lblAracModeli);
            Controls.Add(lblAracMarkasi);
            Controls.Add(iptal);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)iptal).EndInit();
            Resim.ResumeLayout(false);
            Resim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)aracresim).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iptal;
        private Label lblAracMarkasi;
        private Label lblAracModeli;
        private Label lblYil;
        private Label lblYakitTuru;
        private Label lblVites;
        private Label lblKilometre;
        private Label lblRenk;
        private Label lblFiyat;
        private Label lblKasaTipi;
        private Label lblilanTarihi;
        private Label lblDurumu;
        private Label lblIlIlce;
        private DateTimePicker dtpIlanTarihi;
        private TextBox txtYakitTuru;
        private TextBox txtKasaTipi;
        private TextBox txtRenk;
        private TextBox txtVites;
        private TextBox txtAracMarkasi;
        private TextBox txtAracModeli;
        private ComboBox cmbDurumu;
        private TextBox txtKilometre;
        private TextBox txtYil;
        private TextBox txtFiyat;
        private TextBox txtIlIlce;
        private TextBox txtAracBilgi;
        private Button İlanKaydet;
        private Button ilankapat;
        private Label İlanekleme;
        private Label Sayfakapat;
        private GroupBox Resim;
        private PictureBox aracresim;
        private LinkLabel Linkkaldir;
        private LinkLabel Linkekle;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
        private GroupBox Bilgi;
        private NotifyIcon notifyIcon1;
    }
}