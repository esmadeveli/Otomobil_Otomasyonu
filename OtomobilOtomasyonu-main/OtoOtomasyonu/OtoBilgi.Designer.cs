namespace OtoOtomasyonu
{
    partial class OtoBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtoBilgi));
            toolStrip1 = new ToolStrip();
            iLanEkle = new ToolStripButton();
            İlanDüzenle = new ToolStripButton();
            İlanSil = new ToolStripButton();
            dosyakaydet = new ToolStripButton();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            saveFileDialog1 = new SaveFileDialog();
            toolStripSplitButton1 = new ToolStripSplitButton();
            hakkındaToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AllowItemReorder = true;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { iLanEkle, İlanDüzenle, İlanSil, dosyakaydet, toolStripSplitButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1020, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // iLanEkle
            // 
            iLanEkle.Image = (Image)resources.GetObject("iLanEkle.Image");
            iLanEkle.ImageTransparentColor = Color.Magenta;
            iLanEkle.Name = "iLanEkle";
            iLanEkle.Size = new Size(88, 24);
            iLanEkle.Text = "İlan Ekle";
            iLanEkle.Click += iLanEkle_Click;
            // 
            // İlanDüzenle
            // 
            İlanDüzenle.Image = (Image)resources.GetObject("İlanDüzenle.Image");
            İlanDüzenle.ImageTransparentColor = Color.Magenta;
            İlanDüzenle.Name = "İlanDüzenle";
            İlanDüzenle.Size = new Size(115, 24);
            İlanDüzenle.Text = "İlan Düzenle";
            İlanDüzenle.Click += IlanDuzenle_Click;
            // 
            // İlanSil
            // 
            İlanSil.Image = (Image)resources.GetObject("İlanSil.Image");
            İlanSil.ImageTransparentColor = Color.Magenta;
            İlanSil.Name = "İlanSil";
            İlanSil.Size = new Size(77, 24);
            İlanSil.Text = "İlan Sil";
            İlanSil.Click += IlanSil_Click;
            // 
            // dosyakaydet
            // 
            dosyakaydet.Image = (Image)resources.GetObject("dosyakaydet.Image");
            dosyakaydet.ImageTransparentColor = Color.Magenta;
            dosyakaydet.Name = "dosyakaydet";
            dosyakaydet.Size = new Size(135, 24);
            dosyakaydet.Text = "Dosyayı Kaydet";
            dosyakaydet.Click += dosyakaydet_Click;
            // 
            // listView1
            // 
            listView1.AccessibleRole = AccessibleRole.None;
            listView1.AllowColumnReorder = true;
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            listView1.GridLines = true;
            listView1.HoverSelection = true;
            listView1.LabelEdit = true;
            listView1.LabelWrap = false;
            listView1.Location = new Point(0, 32);
            listView1.Margin = new Padding(5);
            listView1.Name = "listView1";
            listView1.RightToLeft = RightToLeft.No;
            listView1.Scrollable = false;
            listView1.ShowGroups = false;
            listView1.Size = new Size(1020, 481);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.UseWaitCursor = true;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "İlan Tarihi";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Araç Markası";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Araç Modeli";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Yıl";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Renk";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "KM";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "İl/İlçe";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Bilgi";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Json dosyası|*.json|Xml dosyası|*.xml|Csv dosyası|*.csv|binary dosya|*.bin";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { hakkındaToolStripMenuItem, yardımToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(39, 24);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // hakkındaToolStripMenuItem
            // 
            hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            hakkındaToolStripMenuItem.Size = new Size(224, 26);
            hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // yardımToolStripMenuItem
            // 
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            yardımToolStripMenuItem.Size = new Size(224, 26);
            yardımToolStripMenuItem.Text = "Yardım";
            // 
            // OtoBilgi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 515);
            Controls.Add(listView1);
            Controls.Add(toolStrip1);
            Name = "OtoBilgi";
            Text = "OtoBilgi";
            Load += OtoBilgi_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton İlanEkle;
        private ToolStripButton dosyakaydet;
        private ToolStripButton İlanE;
        private ToolStripButton İlanDüzenle;
        private ToolStripButton İlanSil;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private SaveFileDialog saveFileDialog1;
        private ToolStripButton iLanEkle;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem hakkındaToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
    }
}