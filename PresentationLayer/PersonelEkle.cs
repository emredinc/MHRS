using BusinessLayer;
using EntityLayer;
using FacadeLayer;
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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        BolumB b = new BolumB();
        PersonelTipB pertip = new PersonelTipB();
        KontrolB kontrol = new KontrolB();
        PersonelB per = new PersonelB();
        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            DataTable table = pertip.PersonelTipGetir();
            lookUpEdit1.Properties.DataSource = table;
            lookUpEdit1.Properties.ValueMember = "PersonelTipId";
            lookUpEdit1.Properties.DisplayMember = "Ad";
            lookUpEdit1.Properties.PopulateColumns();
            lookUpEdit1.Properties.Columns[0].Visible = false;

            DataTable table1 = b.BolumListele();
            lookUpEdit2.Properties.DataSource = table1;
            lookUpEdit2.Properties.ValueMember = "BolumId";
            lookUpEdit2.Properties.DisplayMember = "BolumAd";
            lookUpEdit2.Properties.PopulateColumns();
            lookUpEdit2.Properties.Columns[0].Visible = false;
        }
        static int PerTipID;
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
             PerTipID = int.Parse(lookUpEdit1.GetColumnValue("PersonelTipId").ToString());
     
        }
        static int bolumID;
        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
             bolumID = int.Parse(lookUpEdit2.GetColumnValue("BolumId").ToString());
         
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            if (!kontrol.PersonelKayitVarMi(txttc.Text))
            {
                personel.TC = txttc.Text;
                personel.Adi = txtad.Text;
                personel.Soyadi = txtsoyad.Text;
                personel.personelTip_id = PerTipID;
                personel.bolum_id = bolumID;
                if (kontrol.SifreKontrol(txtsifre.Text,txtsifreTekrar.Text))
                {
                    personel.Sifre = txtsifre.Text;
                    personel.KayitliMi = true;
                    if (per.PersonelEkle(personel))
                    {
                        MessageBox.Show("Kayıt Başarıyla Gerçeklestı");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Sırasında Bir Hata Olustu");
                    }

                }
                else
                {
                    MessageBox.Show("Şifreler Uyusmuyor");
                }
            }
            else
            {
                MessageBox.Show("Bu TC ye zaten ait kayıt var");
            }
            

        }
    }
}