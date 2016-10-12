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
    public partial class IlacEkle : Form
    {
        public IlacEkle()
        {
            InitializeComponent();
        }
        İlacB ilacc = new İlacB();
        
        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
           
                if (txtIlac.Text != "")
                {
                    Ilaclar ilac = new Ilaclar();
                    ilac.ilac_Ad = txtIlac.Text;
                    if (ilacc.IlacEkle(ilac))
                    {
                        MessageBox.Show("İlaç Eklendi");
                    }
                    else
                    {
                        MessageBox.Show("bir sorunla karsılasıldı");
                    }
                }
                else
                {
                    MessageBox.Show("İlaç girişi yapılmadı");
                } 
           
         

        }
    }
}
