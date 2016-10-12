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
    public partial class AdminSayfası : Form
    {

        public AdminSayfası()
        {
            InitializeComponent();
        }
        BolumB bolum = new BolumB();
        PersonelB per = new PersonelB();
        PersonelTipB perTip = new PersonelTipB();
        KontrolB kontrol = new KontrolB();
        İlacB ilac = new İlacB();
        private void AdminSayfası_Load(object sender, EventArgs e)
        {
            panelControl1.Visible = false;
        }

        private void Link_bolum_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Visible = true;
            btnEkle.Text = "Bolum Ekle";
            btnSil.Text = "Bolum Sil";
            gridView1.Columns.Clear();
            gridView1.OptionsFind.FindNullPrompt = "Bölüm aramak için giriniz...";
            gridControl1.DataSource = bolum.BolumListele();
            gridView1.Columns[0].Visible = false;
        }

        private void Link_ilac_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Visible = true;
            btnEkle.Text = "Ilac Ekle";
            btnSil.Text = "Ilac Sil";
            gridView1.Columns.Clear();
            gridView1.OptionsFind.FindNullPrompt = "Ilaç aramak için giriniz...";
            gridControl1.DataSource = ilac.IlacListe();
            gridView1.Columns[0].Visible = false;
        }

        private void link_personel_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Visible = true;
            btnEkle.Text = "Personel Ekle";
            btnSil.Text = "Personel Sil";
            gridView1.Columns.Clear();
            gridView1.OptionsFind.FindNullPrompt = "Personel aramak için giriniz...";
            gridControl1.DataSource = per.PersonelListe();
            gridView1.Columns[0].Visible = false;
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            if (btnEkle.Text=="Ilac Ekle")
            {
                IlacEkle ilac = new IlacEkle();
                ilac.Show();
            }
            else if (btnEkle.Text=="Personel Ekle")
            {
                PersonelEkle personel = new PersonelEkle();
                personel.Show();
            }
            else
            {
                BolumEkle bolum = new BolumEkle();
                bolum.Show();
            }
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (btnSil.Text=="Ilac Sil")
            {
                Ilaclar i = new Ilaclar();
                i.ilac_id = id;
                if (ilac.IlacSil(i))
                {
                    MessageBox.Show("İlaç Silindi");
                }
                else
                {
                    MessageBox.Show("Bir Hatayla Karsılasıldı");
                }
            }
            else if (btnSil.Text=="Personel Sil")
            {

                if ( per.PersonelSil(id))
                {
                    MessageBox.Show("Personel Başarıyla Silindi");
                }
                else
                {
                    MessageBox.Show("Silme İşlemi Gerçekleşmedi");
                }
            }
            else
            {
                if (bolum.BolumSil(id))
                {
                    MessageBox.Show("Bölüm Başarıyla Silindi");
                }
                else
                {
                    MessageBox.Show("Silme İşlemi Gerçekleşmedi");
                }
            }
        }
        static int id;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = e.FocusedRowHandle;
            if (index > 0)
            {
              id=int.Parse(gridView1.GetRowCellValue(index, gridView1.Columns[0]).ToString());
      
            }
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
