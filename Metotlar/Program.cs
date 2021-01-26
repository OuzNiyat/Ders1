using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            ///string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "Amasya Elmasi";

            string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            ///type safe- tip güvenli 
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("----------Metotlar----------");


            //instance-Örnek
            //encapsulation= kapsülleme

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            ///sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            ///sepetManager.Ekle2("Elma", "Yeşil elma", 12, 12);
            ///sepetManager.Ekle2("Armut", "Diyarbakır karpuz", 12, 15);
        }
    }
}
// tekrar tekrar kod bloklarini kullanabilme metodudur.
//dont not yourself- kendini tekrar etme.