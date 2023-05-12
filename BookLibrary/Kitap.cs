using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mbp_104_Proje
{
    class Kitap 
    {
        public string isim { get; set; } 
        public string yazar { get; set; }
        public int puan { get; set; }
        public int sayfaSayisi { get; set; }
        public string baslamaTarihi { get; set; } = "";
        public string bitirmeTarihi { get; set; } = "";

    }
    
}
