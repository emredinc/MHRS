using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        KontrolB kontrol = new KontrolB();     
        private void linkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum sifre = new SifremiUnuttum();
            sifre.Show();
            this.Hide();
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            if (kontrol.AdminMi(txtTC.Text, txtSifre.Text))
            {
                AdminSayfası admin = new AdminSayfası();
                admin.Show();
                this.Hide();
            }
            else if (kontrol.DoktorMu(txtTC.Text))
            {
                if (kontrol.TcSifreUyuyorMuDr(txtTC.Text, txtSifre.Text))
                {
                    DoktorAnaSayfa.girenDoktor = txtTC.Text;
                    DoktorAnaSayfa dr = new DoktorAnaSayfa();
                    dr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifre Hatalı");
                }

            }
            else
            {
                if (kontrol.HastaKayitVarMi(txtTC.Text))
                {
                    if (kontrol.TcSifreUyuyorMu(txtTC.Text, txtSifre.Text))
                    {
                        UyeAnaSayfa.girilen = txtTC.Text;
                        UyeAnaSayfa uye = new UyeAnaSayfa();
                        uye.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Şifre Hatalı");
                    }
                }
                else
                {
                    MessageBox.Show("Böyle Bir Kayıt Bulunmamaktadır..");
                }
            }
        }
        private void btnKayit_Click(object sender, EventArgs e)
        {
            KayitOl kayıt = new KayitOl();
            kayıt.Show();
            this.Hide();
        }
    }
}
