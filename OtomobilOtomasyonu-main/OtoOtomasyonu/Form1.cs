﻿using OtoAlımDDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resimlinki;

        private void ResimSec(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                aracresim.Load(openFileDialog1.FileName);
                resimlinki = openFileDialog1.FileName;
            }
        }


        private void ResimKaldir(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aracresim.Image = null;
            resimlinki = null;
        }

        public Oto otomobil { get; set; }

        private bool KontrolEt(Control c)
        {
            if (c is TextBox)
            {
                if ((c as TextBox).Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatali bilgi");
                    return false;
                }
                else
                    errorProvider1.SetError(c, "");
            }
            else if (c is MaskedTextBox)
            {
                if (!(c as MaskedTextBox).MaskCompleted)
                {
                    errorProvider1.SetError(c, "Eksik veya hatali bilgi !");
                    return false;
                }
                else
                    errorProvider1.SetError(c, "");
            }
            else if (c is ComboBox)
            {
                if ((c as ComboBox).SelectedItem == null)
                {
                    errorProvider1.SetError(c, "Eksik veya hatali bilgi !");
                    return false;
                }
                else
                    errorProvider1.SetError(c, "");
            }

            return true;
        }
        private void OtoBilgileriniGüncelle()
        {

            otomobil.IlanTarihi = dtpIlanTarihi.Value;
            otomobil.AracMarkasi = txtAracMarkasi.Text;
            otomobil.AracModeli = txtAracModeli.Text;
            otomobil.YakitTuru = txtYakitTuru.Text;
            otomobil.Vites = txtVites.Text;
            otomobil.Durumu = cmbDurumu.Text;
            otomobil.Renk = txtRenk.Text;
            otomobil.Kilometre = txtKilometre.Text;
            otomobil.KasaTipi = txtKasaTipi.Text;
            otomobil.Fiyat = txtFiyat.Text;
            otomobil.IlIlce = txtIlIlce.Text;

        }
        public void OtoBilgileriniYükle(Oto otomobil)
        {
            dtpIlanTarihi.Value = otomobil.IlanTarihi;
            txtAracMarkasi.Text = otomobil.AracMarkasi;
            txtAracModeli.Text = otomobil.AracModeli;
            txtYakitTuru.Text = otomobil.YakitTuru;
            txtVites.Text = otomobil.Vites;
            txtRenk.Text = otomobil.Renk;
            txtKilometre.Text = otomobil.Kilometre;
            txtKasaTipi.Text = otomobil.KasaTipi;
            txtFiyat.Text = otomobil.Fiyat;
            txtIlIlce.Text = otomobil.IlIlce;
            cmbDurumu.SelectedItem = otomobil.Durumu;

            if (!string.IsNullOrEmpty(otomobil.Resim))
                aracresim.Load(otomobil.Resim);


        }
        private void IlanKaydetClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = MessageBox.Show("Formu Kapatmak Istediginizden Emin Misiniz?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tus == DialogResult.Yes)
            {
                Close();
            }
        }



        private void İlanKaydet_Click(object sender, EventArgs e)
        {
            otomobil = new Oto() { ID = Guid.NewGuid() };


            if (!KontrolEt(dtpIlanTarihi)) return;
            if (!KontrolEt(txtAracMarkasi)) return;
            if (!KontrolEt(txtAracModeli)) return;
            if (!KontrolEt(txtYakitTuru)) return;
            if (!KontrolEt(txtVites)) return;
            if (!KontrolEt(cmbDurumu)) return;
            if (!KontrolEt(txtRenk)) return;
            if (!KontrolEt(txtYil)) return;
            if (!KontrolEt(txtKilometre)) return;
            if (!KontrolEt(txtKasaTipi)) return;
            if (!KontrolEt(txtFiyat)) return;
            if (!KontrolEt(txtIlIlce)) return;
            OtoBilgileriniGüncelle();
            DialogResult = DialogResult.OK;
        }
    }

}



