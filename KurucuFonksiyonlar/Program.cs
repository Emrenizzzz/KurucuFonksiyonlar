using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurucuFonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Yunus";
            calisan1.Soyad = "Başer";
            calisan1.No = 12345678;
            calisan1.Departman = "Muhasebe";
            calisan1.CalisanBilgileri();

            Console.WriteLine("***********************************");

            Calisan calisan2 = new Calisan("Emre", "Sırakaya", 12345687, "İnsan Kaynakları");
            calisan2.CalisanBilgileri();
            
            Console.WriteLine("******************************************");

            Calisan calisan3 = new Calisan("Eylül", "Kaya");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad, Soyad, Departman;
        public int No;
        public Calisan()
        {

        }

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Soyad = soyad;
            this.Ad = ad;
            this.Departman = departman;
            this.No = no;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }   

        public void CalisanBilgileri()
        {
             Console.WriteLine("Çalışanın Adı: {0}",Ad);
             Console.WriteLine("Çalışanın Soyadı: {0}",Soyad);
             Console.WriteLine("Çalışanın Numarası: {0}",No);
             Console.WriteLine("Çalışanın Departmanı: {0}",Departman);
        }
    }
}
