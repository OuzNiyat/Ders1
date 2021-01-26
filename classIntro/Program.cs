using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "oguz";
            int yas = 19;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.KursunEgitmeni = "Kerem Varış";
            kurs2.İzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Berkay Bilgin";
            kurs3.İzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursunEgitmeni);
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.KursunEgitmeni);
            }
            //Console.WriteLine("Hello World!");
        }
    }


    class Kurs
    {

        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int İzlenmeOrani { get; set; }

    }
}
