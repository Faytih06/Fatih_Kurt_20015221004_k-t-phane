using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatih_Kurt_20015221004_kütüphane
{
    public class  Uyeler
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }


    }

    public class Kitap
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string Yayın { get; set; }
        public string Dil { get; set; }
        public string Tür { get; set; }
        public double Sayfa { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Yazar}";
        }

    }

    public class Kiralama
    {
        public Guid ID { get; set; }
        public Uyeler Uyeler { get; set; } 
        public Kitap Kitap { get; set; }
        public DateTime Tarih { get; set; }
        public double GünSayısı { get; set; }

    }
    
    public class Teslim
    {
        public Guid ID { get; set; }
        public Uyeler Uyeler { get; set; }
        public DateTime Tarih { get; set; }
        public double Fiyat { get; set; }
        public string Acıklama { get; set; }

    }

}
