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
    public partial class BolumEkle : Form
    {
        public BolumEkle()
        {
            InitializeComponent();
        }
        BolumB bolum = new BolumB(); 
        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            Bolum b = new Bolum();
            b.BolumAd = txtBolum.Text;
            if ( bolum.BolumEkle(b))
            {
                MessageBox.Show("Bölüm Ekleme İşlemi Gerçekleşti");
            }
            else
            {
                MessageBox.Show("Bölüm Eklenemedi");
            }
        }
    }
}
