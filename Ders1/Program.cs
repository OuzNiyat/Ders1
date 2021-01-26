using System;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {//type safety = tip güvenliği
            string kategoriEtiketi = "Kategoriler"; 
            int ogrenciSayısı = 32000; // tam sayıların veri tipi
            double faizOrani = 1.45; //ondalikli veri tipi
            bool sistemeGirisYapmısMı = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu Göster");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu Göster");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }

            if (sistemeGirisYapmısMı == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
