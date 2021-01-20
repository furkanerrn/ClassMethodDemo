using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    public class Musteri
    {
        public Guid musteriıd { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }

        public int yas { get; set; }

        public string Job { get; set; }
        public DateTime kayıttarih { get; set; }
        public bool aktifmi { get; set; }
    }
}
