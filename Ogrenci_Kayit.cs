using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öğrenci_Otomasyonu
{
    public class Ogrenci_Kayit
    {

        public int OgrenciNumarasi { get; set; }
        public string OgrenciAdiSoyadi { get; set; }
        public short OgrenciVizeNotu { get; set; }
        public short OgrenciFinalNotu { get; set; }
        public string OgrenciDersDurum { get; set; }


        public Ogrenci_Kayit(int OgrenciNumarasi)
        {
            this.OgrenciNumarasi = OgrenciNumarasi;
        }


        public void OgrenciEkle(int OgrenciNumarasi, string OgrenciAdiSoyadi, short OgrenciVizeNotu, short OgrenciFinalNotu, string OgrenciDersDurum)
        {
            Console.WriteLine(OgrenciNumarasi + " " + OgrenciAdiSoyadi + " " + OgrenciVizeNotu + " " + OgrenciFinalNotu + " " + OgrenciDersDurum + " " + "eklendi... ");
        }










    }
}
