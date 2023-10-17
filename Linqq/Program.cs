using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
// Linq ile 5in katlarını yazdırıyoruz

namespace Linqq
{
    class ABC
    {
        //static void Main(string[] args)
        //{
        //    IEnumerable<int> result = ((ParallelQuery<int>)ParallelEnumerable.Range(3, 20)).Where(n => n%5 == 0).Select(res => res);

        //    Console.WriteLine("sayılar");
        //    foreach (int sayilar in   result) { Console.WriteLine( sayilar); }
        //}
        //static void Main()
        //{
        //    IEnumerable<int> veri = ((ParallelQuery<int>)ParallelEnumerable.Range(
        //        10, 30)).Where(i => i % 2 == 0).Select(deger => deger);
        //    foreach (int cift in veri)
        //    {
        //        Console.WriteLine(cift);

        //    }

        //static void Main()
        //{

        //    int[] Yas = { 27, 24, 22, 24, 25, 27, 20, 23, 24, 22, 23, 26, 31 };
        //    int toplam = Yas.Sum();
        //    int ort = toplam / Yas.Length;
        //    var oay = from yaslar in Yas where yaslar < ort select yaslar;
        //    Console.WriteLine("Ortalama yaslar :" + ort);
        //    Console.WriteLine("ortalamanın altında kalan yaslarr:");
        //    foreach (int i in oay) { Console.WriteLine(i + ""); }
        //    Console.WriteLine( );
        //}
       
        //static void Main()
        //{
        //    string[] isimler = { "Mira", "Berfin", "Gönül", "Kübra", "İnanç", "Pelin", "Enes","Ali" };
        

        //    IEnumerable<string> sonuc = isimler.Where(harf=> harf.Length > 4);
        //    foreach ( var i  in sonuc )
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        static void Main()
        {
            string[] Isimler = { "Berfin", "Gönül", "Kübra", "İnanç", "Pelin", "Enes", "Reyyan", "Mira", "Burak" };
         
            IEnumerable<string> sonuc = Isimler.Where(rhb =>rhb.Contains("r"));
            foreach(string s in sonuc)
            {
                    Console.WriteLine(s);
            }

        }
    }
    
 
	}

