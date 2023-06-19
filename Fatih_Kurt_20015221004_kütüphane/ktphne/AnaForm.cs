using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fatih_Kurt_20015221004_kütüphane.BL;
using Fatih_Kurt_20015221004_kütüphane.ktphne;

namespace Fatih_Kurt_20015221004_kütüphane
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnÜyeEkle_Click(object sender, EventArgs e)
        {
            FrmÜyeler frmÜyeler = new FrmÜyeler()
            {
                Text = "Üye Ekle",
                Uyeler = new Uyeler() { ID = Guid.NewGuid() },

            };
        tekrar:
            var sonuc = frmÜyeler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Blogic.ÜyeEkle(frmÜyeler.Uyeler);
                if (b)
                {

                    DataSet ds = Blogic.ÜyeGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }

        }

        private void btnÜyeDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            FrmÜyeler frmÜyeler = new FrmÜyeler()
            {
                Text = "Üye Güncelle",
                Güncelleme = true,
                Uyeler = new Uyeler()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                },
            };

            var sonuc = frmÜyeler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Blogic.ÜyeGüncelle(frmÜyeler.Uyeler);
                if (b)
                {
                    row.Cells[1].Value = frmÜyeler.Uyeler.Ad;
                    row.Cells[2].Value = frmÜyeler.Uyeler.Soyad;
                    row.Cells[3].Value = frmÜyeler.Uyeler.Telefon;
                    row.Cells[4].Value = frmÜyeler.Uyeler.Mail;
                }
            }


        }

        private void btnÜyeAra_Click(object sender, EventArgs e)
        {
            DataSet ds = Blogic.ÜyeGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds1 = Blogic.ÜyeGetir("");
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];

            DataSet ds2 = Blogic.KitapGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }
    

        private void btnÜyeSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

           

            var sonuc = MessageBox.Show("Seçtiğiniz Kayıt Silinsin Mi ?", "Silmeyi Onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = Blogic.ÜyeSil(ID );
                if (b)
                {

                    DataSet ds = Blogic.ÜyeGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            FrmKitap frmKitap = new FrmKitap()
            {
                Text = "Kitap Ekle",
                Kitap = new Kitap() { ID = Guid.NewGuid() },

            };
        tekrar:
            var sonuc = frmKitap.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Blogic.KitapEkle(frmKitap.Kitap);
                if (b)
                {

                    DataSet ds = Blogic.KitapGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }

        }

        private void btnKitapAra_Click(object sender, EventArgs e)
        {
            DataSet ds = Blogic.KitapGetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnKitapDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            FrmKitap frmKitap = new FrmKitap()
            {
                Text = "Kitap Güncelleme",
                Güncelleme = true,
                Kitap = new Kitap()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Yazar = row.Cells[2].Value.ToString(),
                    Yayın = row.Cells[3].Value.ToString(),
                    Dil = row.Cells[4].Value.ToString(),
                    Tür = row.Cells[5].Value.ToString(),
                    Sayfa = double.Parse(row.Cells[6].Value.ToString()),

                },
            };

            var sonuc = frmKitap.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Blogic.KitapGüncelle(frmKitap.Kitap);
                if (b)
                {
                    row.Cells[1].Value = frmKitap.Kitap.Ad;
                    row.Cells[2].Value = frmKitap.Kitap.Yazar;
                    row.Cells[3].Value = frmKitap.Kitap.Yayın;
                    row.Cells[4].Value = frmKitap.Kitap.Dil;
                    row.Cells[4].Value = frmKitap.Kitap.Tür;
                    row.Cells[4].Value = frmKitap.Kitap.Sayfa;

                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

