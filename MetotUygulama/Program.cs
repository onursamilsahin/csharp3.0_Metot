using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MetotUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            //console üzerinde Hesap makinesi yapımı
            while (true)
            {

                Console.WriteLine("Seçim Yapınız.");
                Console.WriteLine("1-Toplama");
                Console.WriteLine("2-çıkarma");
                Console.WriteLine("3-çarpma");
                Console.WriteLine("4-bölme");
                Console.WriteLine("5-çıkış");
                int secim = int.Parse(Console.ReadLine());

                switch (secim)
                {

                    case 1:
                        Console.WriteLine("toplanıcak değerleri giriniz(5+5+5):");
                        string topla = Console.ReadLine();
                        ToplamSonuc(topla);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Çıkarılacak değerleri giriniz(5-5-5):");
                        string cikar = Console.ReadLine();
                        CikarmaSonuc(cikar);
                        Console.ReadLine();
                        //************************
                        break;
                    case 3:
                        Console.WriteLine("******************Çarpma yapılacak değerleri giriniz(5*5*5):");
                        string carpma = Console.ReadLine();
                        Carpma(carpma);
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Bölünecek değerleri giriniz(5/5/5):");
                        string Bol = Console.ReadLine();
                        Bolme(Bol);
                        Console.ReadLine();
                        break;
                    case 5:
                        Environment.Exit(0);

                        break;
                    default:
                        Console.WriteLine("Yanlış tuşlama yaptınız çıkış yapmak istiyormusunuz?(Evet:E,Hayır:H)");
                        string cevap = Console.ReadLine();
                        if (cevap == "E")
                        {
                            Environment.Exit(0);
                        }

                        break;


                }
            }
        }

        private static  void ToplamSonuc(string deger)
        {
            int AraDeger = 0;


            string[] sayilar = deger.Split('+');


            foreach (var item in sayilar)
            {
                
                AraDeger = AraDeger + Topla(0, item);
            }

            Console.WriteLine("Sonuç:{0}", AraDeger);
        }
        private static int Topla(int sayi1,string sayi2)
        {
            int deger = sayi1 + int.Parse(sayi2);


            return deger;

        }

        private static void CikarmaSonuc(string deger)    
        {
            int sayac = 0;
            int AraDeger = 0;

            string[] sayilar = deger.Split('-');

            foreach (var item in sayilar)
            {

                AraDeger =AraDeger  -int.Parse(item);
                if (sayac == 0)
                {
                    AraDeger = AraDeger * (-1);
                }

                sayac++;
            }



            Console.WriteLine("Sonuç:{0}",AraDeger);


        }

        private static void Bolme(string deger)
        {
            string[] sayilar = deger.Split('/');

            decimal Aradeger = 1;
            int sayac = 0;
            foreach (var item in sayilar)
            {
                Aradeger = Aradeger/ decimal.Parse(item);
                if (sayac==0)
                {
                    Aradeger = decimal.Parse(item);
                }

                sayac++;
            }



            Console.WriteLine("Sonuç:{0}", Aradeger);


        }


        private static void Carpma(string Deger)
        {
            string[] Sayilar = Deger.Split('*');

            int AraDeger = 1;

            foreach (var item in Sayilar)
            {

                AraDeger = AraDeger * int.Parse(item);

            }


            Console.WriteLine("Sonuç:{0}",AraDeger);

        }

       




    }
}
