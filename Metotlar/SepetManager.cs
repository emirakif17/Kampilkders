using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
     class SepetManager
     {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Ürününüz sepete eklenmiştir. : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Ürününüz sepete eklenmiştir : " + urunAdi);
        }
     }
}
