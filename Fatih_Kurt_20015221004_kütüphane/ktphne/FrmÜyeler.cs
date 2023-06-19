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
    public partial class FrmÜyeler : Form
    {
        public FrmÜyeler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Uyeler Uyeler { get; set; }

        public bool Güncelleme { get; set; } = false;
        private void btnİptal_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAD)) return;
            if (!ErrorControl(txtSoy)) return;
            if (!ErrorControl(txtTel)) return;
            if (!ErrorControl(txtMail)) return;

            Uyeler.Ad = txtAD.Text;
            Uyeler.Soyad = txtSoy.Text;
            Uyeler.Telefon= txtTel.Text;
            Uyeler.Mail = txtMail.Text;

            DialogResult = DialogResult.OK;
        }

      

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
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
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
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

        private void FrmÜyeler_Load(object sender, EventArgs e)
        {
            txtID.Text = Uyeler.ID.ToString();

            if (Güncelleme)
            {
                 txtAD.Text = Uyeler.Ad;
                 txtSoy.Text =  Uyeler.Soyad;
                 txtTel.Text = Uyeler.Telefon;
                 txtMail.Text = Uyeler.Mail;
            }
        }
    }

}
