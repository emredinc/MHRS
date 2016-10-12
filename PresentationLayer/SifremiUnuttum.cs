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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        KontrolB kontrol = new KontrolB();
        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string tc = txtTC.Text;
            if (kontrol.HastaKayitVarMi(tc))
            {
                string mesaj = kontrol.SifremiUnuttum(tc);
                MessageBox.Show("Şifreniz :" + mesaj);
                Giris form = new Giris();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik Numarasına Ait Kayıt Bulunamadı");
            }
        }
    }
}
