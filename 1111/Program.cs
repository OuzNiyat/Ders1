using System;

namespace _1111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1-10] arasında bir sayı seçiniz:");
            int sayi = int.Parse(Console.ReadLine());
            string cevap = "";
            cevap += sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap verdiniz";
            Console.WriteLine(cevap);

        }
    }
}
