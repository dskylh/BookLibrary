using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mbp_104_Proje
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static string sayfaSayisi(List<Kitap> kitaplar)
        {
            int sayfaSayisi = 0;
            foreach (var item in kitaplar)
            {
                sayfaSayisi += item.sayfaSayisi;
            }
            return sayfaSayisi.ToString();

        }
        public static string ortalamaPuan(List<Kitap> kitaplar)
        {
            double toplamPuan = 0;

            foreach (Kitap item in kitaplar)
            {
                toplamPuan += item.puan;
            }
            double ortalamaPuan = toplamPuan / kitaplar.Count;

            return ortalamaPuan.ToString();

        }

    }
}
