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
    public partial class DoktorAnaSayfa : Form
    {
        public DoktorAnaSayfa()
        {
            InitializeComponent();
        }
        public static string girenDoktor;
        PersonelB per = new PersonelB();
        RandevularB randevu = new RandevularB();
        public static Personel dr = new Personel();
        private void DoktorAnaSayfa_Load(object sender, EventArgs e)
        {
          
            //dr = new Personel();
            DataTable doktor = per.DoktorBilgileri(girenDoktor);
            foreach (DataRow item in doktor.Rows)
            {
                dr.personel_id =Convert.ToInt32( item[0].ToString());
                dr.TC = item[1].ToString();
                dr.Adi = item[2].ToString();
                dr.Soyadi = item[3].ToString();
                dr.personelTip_id =Convert.ToInt32( item[4].ToString());
                dr.bolum_id = Convert.ToInt32(item[9].ToString());
                dr.Sifre = item[10].ToString();
                ilacDurum = false;
            }
           
        }

        private void link_Hastalarim_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridView1.Columns.Clear();
            gridView1.OptionsFind.FindNullPrompt = "Hasta aramak için giriniz...";
            gridControl1.DataSource = per.DoktorHasta(dr.personel_id);
            gridView1.Columns[0].Visible = false;
            ilacDurum = false;
        }

        private void link_Randevularim_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridView1.Columns.Clear();
            gridView1.OptionsFind.FindNullPrompt = "Randevu aramak için hasta adı,randevu tarihi ya da diğer bilgilerinden birini girebilirsiniz...";
            gridControl1.DataSource = randevu.DoktorRandevuları(dr.personel_id);
            gridView1.Columns[0].Visible = false;
            ilacDurum = false;
        }

        private void link_ReceteYaz_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ReceteYaz ryaz = new ReceteYaz();
            ryaz.Show();
            ilacDurum = false ;
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridView1.Columns.Clear();            
            gridControl1.DataSource =ReceteB.ReceteListele(dr.personel_id);
            gridView1.Columns[0].Visible = false;
            ilacDurum = true;
        }
        string ReceteId;
        bool ilacDurum;
        int index;
        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
            if (index > 0)
            {
                ReceteId = gridView1.GetRowCellValue(index, gridView1.Columns[0]).ToString();     
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (index>=0 && ilacDurum )
            {
                ReceteId = gridView1.GetRowCellValue(index, gridView1.Columns[0]).ToString();
                HastaIlacEkle h = new HastaIlacEkle(ReceteId);
                h.ShowDialog();
            }
              

        }
        
        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

    }
}
