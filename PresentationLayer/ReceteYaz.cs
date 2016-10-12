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
    public partial class ReceteYaz : Form
    {
        public ReceteYaz()
        {
            InitializeComponent();
        }
        PersonelB per = new PersonelB();
        static int receteId;
        static int hastaId;
        private void ReceteYaz_Load(object sender, EventArgs e)
        {
            int id = DoktorAnaSayfa.dr.personel_id;
            gridControl1.DataSource = per.DoktorHasta(id);
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].Visible = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                receteId = int.Parse(gridView1.GetRowCellValue(e.FocusedRowHandle, gridView1.Columns[0]).ToString());
                hastaId = int.Parse(gridView1.GetRowCellValue(e.FocusedRowHandle, gridView1.Columns[1]).ToString());
            }
        }

        private void btnRecete_Click(object sender, EventArgs e)
        {
            if (receteId >=0 && textBox1.Text != "")
            {
                Recete r = new Recete();
                r.HastaId = hastaId;
                r.PersonelId = DoktorAnaSayfa.dr.personel_id;
                r.Kayitli_Mi = true;
                r.VerilisTarih = DateTime.Now;
                r.Teshis = textBox1.Text;
                r.Randevu_id = receteId;
                if (ReceteB.ReceteYaz(r))
                {
                    MessageBox.Show("Başarılı");
                }
            }
        }
    }
}
