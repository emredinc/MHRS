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
using BusinessLayer;
namespace PresentationLayer
{
    public partial class HastaIlacEkle : Form
    {
        public HastaIlacEkle()
        {
            InitializeComponent();
        }
       
        public HastaIlacEkle(string rId)
        {
            // TODO: Complete member initialization
            ReceteId = rId;
            InitializeComponent();
        }
        string ReceteId;
        static ReceteIlacB recete = new ReceteIlacB();
        private void button1_Click(object sender, EventArgs e)
        {
            if(recete.ReceteIlacEkle(Convert.ToInt32(ReceteId), Convert.ToInt32(ilacId)))
            {
                MessageBox.Show("Başarılı");
            }
        }

        private void HastaIlacEkle_Load(object sender, EventArgs e)
        {
            İlacB ilac=new İlacB();
            cmbIlac.Properties.DataSource = ilac.IlacListe();
            cmbIlac.Properties.ValueMember = "IlacId";
            cmbIlac.Properties.DisplayMember = "Ad";
            cmbIlac.Properties.PopulateColumns();
            cmbIlac.Properties.Columns[0].Visible = false;
        }
        string ilacId;
        private void cmbIlac_EditValueChanged(object sender, EventArgs e)
        {
            ilacId = cmbIlac.GetColumnValue("IlacId").ToString();
        }
    }
}
