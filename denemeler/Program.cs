using System;

namespace denemeler
{
    class Program
    {

        static void Main(string[] args)
        {


            aile kucukKardes = new aile();
            kucukKardes.KisininAdi = "Oğuz Nihat";
            kucukKardes.KisininSoyadi = "Hacıabdurrahmanoğlu";
            kucukKardes.KisininYasi = 19;
            kucukKardes.KisininMeslegi = "Öğrenci";

            aile ortancaKardes = new aile();
            ortancaKardes.KisininAdi = "Sinan";
            ortancaKardes.KisininSoyadi = "Hacıabdurrahmanoğlu";
            ortancaKardes.KisininYasi = 26;
            ortancaKardes.KisininMeslegi = "Boş insan";

            aile buyukKardes = new aile();
            buyukKardes.KisininAdi = "Celile";
            buyukKardes.KisininSoyadi = "Çil";
            buyukKardes.KisininYasi = 31;
            buyukKardes.KisininMeslegi = "Ev Hanımı";

            aile baba = new aile();
            baba.KisininAdi = "Ahmet";
            baba.KisininSoyadi = "Hacıabdurrahmanoğlu";
            baba.KisininYasi = 61;
            baba.KisininMeslegi = "Emekli";

            aile anne = new aile();
            anne.KisininAdi = "Asiye";
            anne.KisininSoyadi = "Hacıabdurrahmanoğlu";
            anne.KisininYasi = 52;
            anne.KisininMeslegi = "Ev Hanımı";

            aile[] Bireyler = new aile[] { kucukKardes, ortancaKardes, buyukKardes, anne, baba };

            foreach (var aile in Bireyler)
            {
                Console.WriteLine(aile.KisininAdi+ " " + aile.KisininSoyadi+ " " + "yaşı" + ":" +aile.KisininYasi);
            }











        }



    }



    class aile
    {
        public string KisininAdi { get; set; }
        public string KisininSoyadi { get; set; }
        public string KisininMeslegi { get; set; }
        public int KisininYasi { get; set; }

    }
    



} 
