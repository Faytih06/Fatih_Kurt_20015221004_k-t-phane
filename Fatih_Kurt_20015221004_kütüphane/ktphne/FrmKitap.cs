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
    public partial class FrmKitap : Form
    {
        public FrmKitap()
        {
            InitializeComponent();
        }

        private void FrmKitap_Load(object sender, EventArgs e)
        {

        }
         public Kitap Kitap { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtKitapAD)) return;
            if (!ErrorControl(txtKitapYazar)) return;
            if (!ErrorControl(txtKitapYayın)) return;
            if (!ErrorControl(cbKitapDil)) return;
            if (!ErrorControl(cbKitapTür)) return;
            if(!ErrorControl(nmSayfa)) return;

            Kitap.Ad = txtKitapAD.Text;
            Kitap.Yazar= txtKitapYazar.Text;
            Kitap.Yayın = txtKitapYayın.Text;
            Kitap.Dil = cbKitapDil.Text;
            Kitap.Tür = cbKitapTür.Text;
            Kitap.Sayfa = (double)nmSayfa.Value;

            DialogResult = DialogResult.OK;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya Hatalı bilgi girmeyiniz");
                    c.Focus();
                    return false;

                }

                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }

            }
            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value== 0)
                {
                    errorProvider1.SetError(c, "Eksik veya Hatalı bilgi girmeyiniz");
                    c.Focus();
                    return false;

                }

                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }

            }
            return true;
        }
    }

}
