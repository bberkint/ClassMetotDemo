using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Bankamıza Hoşgeldiniz!" + musteri.Ad +" " + musteri.Soyad);
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "  " + musteri.Soyad + "  " + "  " + musteri.KimlikNo + "  " + musteri.HesapNo);
        }


        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Bankamızı tercih ettiğiniz için teşekkürler!" + musteri.Ad + " " + musteri.Soyad);
        }

      
    }
}
