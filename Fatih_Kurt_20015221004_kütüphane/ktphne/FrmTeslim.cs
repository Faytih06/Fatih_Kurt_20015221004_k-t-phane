using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatih_Kurt_20015221004_kütüphane.ktphne
{
    public partial class FrmTeslim : Form
    {
        public FrmTeslim()
        {
            InitializeComponent();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Teslim Teslim { get; set; }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (txtAcıklama.Text == "")
            {
                errorProvider1.SetError(txtAcıklama, "Açıklama kısmı boş olamaz!"); 
                txtAcıklama.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtAcıklama, "");
            }
            
            Teslim.Tarih = dtTeslimTarihi.Value;
            Teslim.Fiyat = (double)nmÜcret.Value;
            Teslim.Acıklama = txtAcıklama.Text;
            

                DialogResult = DialogResult.OK;
        }

        private void FrmTeslim_Load(object sender, EventArgs e)
        {

        }
    }
}
