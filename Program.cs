using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            MusteriManager mm = new MusteriManager(); 
            // Musteri m4 = new Musteri();
            // m4.musteriıd = new Guid();
            // m4.ad = "Max";
            // m4.soyad = "Weber";
            // m4.yas = 21;
            // m4.kayıttarih = DateTime.Now;
            // m4.Job = "E-Ticaret Analisti";
            // m4.aktifmi = true;

            // mm.musteriekle(m4);

            // Musteri m1 = new Musteri();

            // m1.musteriıd = new Guid();
            // m1.ad = "Furkan";
            // m1.soyad = "Eren";
            // m1.yas = 21;
            // m1.kayıttarih = DateTime.Now;
            // m1.Job = "İş analisti";
            // m1.aktifmi = true;
            // mm.musteriekle(m1);

            // Musteri m2 = new Musteri();

            // m2.musteriıd = new Guid();
            // m2.ad = "Fatih ";
            // m2.soyad = "Eren";
            // m2.yas = 26;
            // m2.kayıttarih = DateTime.Now;
            // m2.Job = "Test Uzmanı";
            // m2.aktifmi = true;
            // mm.musteriekle(m2);


            // Musteri m3 = new Musteri();

            // m3.musteriıd = new Guid();
            // m3.ad = "Erhan";
            // m3.soyad = "Yılmaz";
            // m3.yas = 41;
            // m3.kayıttarih = DateTime.Now;
            // m3.Job = "Dijital Pazarlama Uzmanı";
            // m3.aktifmi = false;


            // mm.musteriekle(m3);


            Musteri m5 = new Musteri();
            m5.musteriıd = new Guid();
            m5.ad = "Ayşe";
            m5.soyad = "Mızrak";
            m5.yas = 28;
            m5.kayıttarih = DateTime.Now;
            m5.Job = "İnsan Kaynakları Uzmanı";
            m5.aktifmi = false;
            mm.musteriekle(m5);
            mm.listele(m5);


            Musteri m6 = new Musteri();
            m6.musteriıd = new Guid();
            m6.ad = "Ali";
            m6.soyad = "Yüce";
            m6.yas = 40;
            m6.kayıttarih = DateTime.Now;
            m6.Job = "Senior Web Developer";
            m6.aktifmi = false;
            mm.musteriekle(m6);
            mm.listele(m6);

            Musteri m7 = new Musteri();
            m7.musteriıd = new Guid();
            m7.ad = "Mertay";
            m7.soyad = "Aslan";
            m7.yas = 34;
            m7.kayıttarih = DateTime.Now;
            m7.Job = " SEO Uzmanı";
            m7.aktifmi = true;
            mm.musteriekle(m7);
            mm.listele(m7);
            mm.musterisil(m7);


            //Musteri[] musteriler = new Musteri[] { m1, m2, m3 };
            //foreach (Musteri m in musteriler)
            //{
            //    Console.ForegroundColor = ConsoleColor.Cyan;
            //    Console.WriteLine(m.ad);
            //    Console.WriteLine(m.soyad);
            //    Console.WriteLine(m.yas);
            //    Console.WriteLine(m.kayıttarih);
            //    Console.WriteLine(m.Job);
            //    Console.WriteLine(m.aktifmi);
            //    Console.WriteLine("");
            //    Console.WriteLine("****");
            //}

           

            

    }
}
}
