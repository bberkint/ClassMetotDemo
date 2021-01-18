using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Burak";
            musteri1.Soyad = "Aslan";
            musteri1.KimlikNo = 15423616242;
            musteri1.HesapNo = 10012004;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Batın Berkin";
            musteri2.Soyad = "Topaloğlu";
            musteri2.KimlikNo = 45686253523;
            musteri2.HesapNo = 14523655;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ahmet";
            musteri3.Soyad = "Bozkurt";
            musteri3.KimlikNo = 45286373266;
            musteri3.HesapNo = 45216892;

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Sude";
            musteri4.Soyad = "Karagöz";
            musteri4.KimlikNo = 57899653233;
            musteri4.HesapNo = 78567756;


            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new[] { musteri1,musteri2,musteri3,musteri4}; 


            foreach (Musteri customer in musteriler)
            {
                musteriManager.Ekle(customer);
            }

            Console.WriteLine("\n\n*****BANKAMIZDAKİ MÜŞTERİLER*****\n\n");

            foreach (Musteri customer in musteriler)
            {
                musteriManager.List(customer);
            }

            Console.WriteLine("\n\n---------------------------\n\n");
            foreach (Musteri customer in musteriler)
            {
                musteriManager.Silme(customer);
            }

            
        }
    }
}
