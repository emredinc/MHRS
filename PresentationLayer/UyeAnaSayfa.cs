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
    public partial class UyeAnaSayfa : Form
    {
        public static string girilen;
        public UyeAnaSayfa()
        {
            InitializeComponent();
        }
        static Hasta hasta = new Hasta();
        static HastalarB h = new HastalarB();
        KontrolB kontrol = new KontrolB();
        RandevularB randevu = new RandevularB();
        BolumB bolum = new BolumB();
        SaatB sat=new SaatB();
     
        private void UyeAnaSayfa_Load(object sender, EventArgs e)
        {
            gridControl1.Visible = false;
           
            DataTable table = h.HastaBilgileri(girilen);
            foreach (DataRow item in table.Rows)
            {
                hasta.Hasta_id = Convert.ToInt32(item[0].ToString());
                hasta.TC = item[1].ToString();
                hasta.Adi = item[2].ToString();
                hasta.Soyadi = item[3].ToString();
                hasta.DogumTarihi = Convert.ToDateTime(item[4].ToString());
                hasta.Cinsiyet = item[5].ToString();
                hasta.Sifre = item[6].ToString();

            }
            lbltc.Text = hasta.TC;
            lblad.Text = hasta.Adi;
            lblsoyad.Text = hasta.Soyadi;
            lbldogumTarihi.Text = Convert.ToDateTime(hasta.DogumTarihi).ToString();
            lblCinsiyet.Text = hasta.Cinsiyet;
            lblSifre.Text = hasta.Sifre;

        }
       

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            txtTC.Text = hasta.TC;
            txtad.Text = hasta.Adi;
            txtsoyad.Text = hasta.Soyadi;
            txtcinsiyet.Text = hasta.Cinsiyet;
            txtsifre.Text = hasta.Sifre;
            txtsifreTekrar.Text = hasta.Sifre;
        }

      

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {

                gridControl2.DataSource= h.HastaRandevuListele(hasta.Hasta_id);
            }
            if (tabControl1.SelectedIndex == 3)
            {
                DataTable table = bolum.BolumListele();
                comboBox1.DisplayMember = "BolumAd";
                comboBox1.ValueMember = "BolumId";
                comboBox1.DataSource = table;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolumID = int.Parse(comboBox1.SelectedValue.ToString());
            DataTable doktorlar = bolum.DoktorBolum(bolumID);
            if (doktorlar.Rows.Count != 0)
            {
                cmbDoktor.DisplayMember = "DoktorAdSoyad";
                cmbDoktor.ValueMember = "PersonelId";
                cmbDoktor.DataSource = doktorlar;
            }
            else
            {
                cmbDoktor.DataSource = null;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
            if (monthCalendar1.SelectionRange.Start >= DateTime.Now.Date)
            {
                gridControl1.Visible = true;
                DataTable saat = sat.SaatGetir(monthCalendar1.SelectionRange.Start);
                gridControl1.DataSource = saat;
                gridView1.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("Geçmiş Tarihe Randevu Alınamaz");
                monthCalendar1.SelectionRange.Start = DateTime.Now.Date;
            }
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            int per_id =Convert.ToInt32( cmbDoktor.SelectedValue.ToString());
            DateTime tarih = monthCalendar1.SelectionRange.Start;
            int saat_id = id;
            if (kontrol.RandevuVarMi(tarih,saat_id))
            {
                if (randevu.RandevuAl(hasta.Hasta_id, per_id, tarih, saat_id))
                {
                    MessageBox.Show("randevu basarıyla alındı");
                }
                else
                {
                    MessageBox.Show("hataaaaa");
                }
            }
            else
            {
                MessageBox.Show("Randevu saati dolu");
            }
           
        }
        static int id;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = e.FocusedRowHandle;
            if (index>=0)
            {
                id = int.Parse(gridView1.GetRowCellValue(index, gridView1.Columns[0]).ToString());
            }
        }

        private void SbtnGuncelle_Click(object sender, EventArgs e)
        {
            hasta.Adi = txtad.Text;
            hasta.Soyadi = txtsoyad.Text;
            hasta.Cinsiyet = txtcinsiyet.Text;
            string sifre = txtsifre.Text;
            string sifre1 = txtsifreTekrar.Text;
            if (kontrol.SifreKontrol(sifre, sifre1))
            {
                hasta.Sifre = txtsifre.Text;
                h.HastaGuncelle(hasta);
                MessageBox.Show("Güncelleştirme işlemi Başarıyla Gerçekleştirildi..");
            }
            else
            {
                MessageBox.Show("Şifreler Aynı Değil.Lütfen Tekrar Deneyiniz..");
            }
        }
    }
}
