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
    public partial class FrmKiralama : Form
    {
        public FrmKiralama()
        {
            InitializeComponent();
        }

        public Uyeler Uyeler { get; set; }

        public Kitap Kitap { get; set; }

        public Kiralama Kiralama { get; set; }

        private void FrmKiralama_Load(object sender, EventArgs e)
        {
            txtID.Text = Kiralama.ID.ToString();
            txtUye.Text = Uyeler.ToString();
            txtKitap.Text = Kitap.ToString();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if(nmKiralamaGün.Value== 0)
            {
                errorProvider1.SetError(nmKiralamaGün, "Lütfen kitabın kiralayan üyede kalacağı gün sayısını belirtiniz");
                nmKiralamaGün.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmKiralamaGün, "");
            }

            Kiralama.Tarih = dtpKiralamaTarihi.Value;
            Kiralama.GünSayısı = (double)nmKiralamaGün.Value;

            DialogResult = DialogResult.OK;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
    }

}
