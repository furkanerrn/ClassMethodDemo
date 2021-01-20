using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class MusteriManager
    {
        public void musteriekle(Musteri m)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0} {1} adlı müşterinin kayıt işlemi başarıyla tamamlandı. Detaylı bilgi aşağıdadır", m.ad, m.soyad);
            Console.WriteLine("*****");



        }

        public void listele(Musteri m)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ad: " + m.ad);
            Console.WriteLine("Soyad: " + m.soyad);
            Console.WriteLine("Kayıt Tarihi: " + m.kayıttarih);
            Console.WriteLine("Aktif mi: " + m.aktifmi);
            Console.WriteLine("Yaş: " + m.yas);
            Console.WriteLine("Meslek: " + m.Job);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("Listeleme işlemi başarıyla tamamlandı");
            Console.WriteLine("****");
            Console.WriteLine("***");
            Console.WriteLine("**");
            Console.WriteLine("*");
            Console.WriteLine("");
        }
        public void musterisil(Musteri m)
        {
            Console.WriteLine(" {0} kodlu  {1} adlı müşteri  silindi", m.musteriıd, m.ad);

        }
    }
}
