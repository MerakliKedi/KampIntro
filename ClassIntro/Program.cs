using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Abdullah Yayar";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.KursunEgitmeni = "Zehra Yayar";
            kurs2.IzlenmeOrani = 88;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.KursunEgitmeni = "Fatma Nur Yayar";
            kurs3.IzlenmeOrani = 98;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "React";
            kurs4.KursunEgitmeni = "Muhammed Ali Yayar";
            kurs4.IzlenmeOrani = 100;


           // Console.WriteLine(kurs1.KursAdi+ ":" + kurs1.KursunEgitmeni);

            Kurs[] kurslar= new Kurs[] {kurs1, kurs2,kurs3,kurs4 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ ":"+kurs.KursunEgitmeni);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
