using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //DO NOT REPEAT YOURSELF
            //degiskenler veri tutuculardır.
            //type safety= tip güvenliği
            
            string kategoriEtiketi = "Kategoriler!";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisyapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisyapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Menüsü");

            }
            else
            {
                Console.WriteLine("Giriş Yap Menüsü");
            }
            
            Console.WriteLine(kategoriEtiketi);
            
        }
    }
}
