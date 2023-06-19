using Fatih_Kurt_20015221004_kütüphane.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatih_Kurt_20015221004_kütüphane.BL
{
   public static class Blogic
    {
        public static bool ÜyeEkle(Uyeler m)
        {
            try {
                int res = DataLayer.ÜyeEkle(m);


                return (res > 0);
            } catch (Exception ex)
            { 
                MessageBox.Show("Hata oluştu:"+ ex.Message);
                return false;
            }
        }

        internal static bool KitapEkle(Kitap kitap)
        {
            try
            {
                int res = DataLayer.KitapEkle(kitap);


                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet KitapGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.KitapGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool KitapGüncelle(Kitap kitap)
        {
            try
            {
                int res = DataLayer.KitapGüncelle(kitap);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet ÜyeGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.ÜyeGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool ÜyeGüncelle(Uyeler m)
        {
            try
            {
                int res = DataLayer.ÜyeGüncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool ÜyeSil(string id)
        {
            try
            {
                int res = DataLayer.ÜyeSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }
    }
}
