using BusinessLayer;
using EntityLayer;
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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        KontrolB kontrol = new KontrolB();
        private void btnKayit_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            if (!kontrol.HastaKayitVarMi(txtTC.Text))
            {
                hasta.TC = txtTC.Text;
                hasta.Adi = txtad.Text;
                hasta.Soyadi = txtsoyad.Text;
                hasta.DogumTarihi = dtpDogumTarihi.Value;
                if (rbBay.Checked){
                    hasta.Cinsiyet ="Bay";
                }
                else
                {
                    hasta.Cinsiyet = "Bayan";
                }
                string sifre1 = txtsifre.Text;
                string sifre2 = txtsifreTekrar.Text;
                if (kontrol.SifreKontrol(sifre1, sifre2))
                {
                    hasta.Sifre = txtsifre.Text;
                    hasta.KayitTarihi = DateTime.Now;
                    hasta.KayitliMi = true;
                    HastalarB hasta2 = new HastalarB();
                    hasta2.HastaEkle(hasta);
                    MessageBox.Show("Kayıt Başarııyla Gerçekleşti..");
                    Giris giris = new Giris();
                    giris.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifreler Aynı Değil..");
                }
            }
            else
            {
                MessageBox.Show("Bu Kimlik Numarasına Ait Kayıt Var..");
            }
            
            
           
           
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }
    }
}
