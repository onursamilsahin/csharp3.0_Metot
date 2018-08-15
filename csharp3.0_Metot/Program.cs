using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp3._0_Metot
{
    class Program
    {
        static void Main(string[] args)
        {


            IlkMetot();
            EkranaYAz("Merhaba dünya");

            Console.WriteLine(Topla(1, 2));
            Console.WriteLine(Topla("onur","şahin"));
            Console.ReadLine();


        }
        //Metotlar classlar içerisine yazılır .
        //private :class içerisinde erişilebilir.
        //Public:Class ın dışında örneklendiğinde veya  static is çağırıldığında gelir.


        private static  void IlkMetot()
        {

            Console.WriteLine("Mehaba dünya");
        }


        static void EkranaYAz(string Metin)
        {
            Console.WriteLine(Metin);


        }

        //Aşırı yükleme aynı isimli birden fazla metot, Topla metotu aşırı yüklenmiştir.
        static int Topla(int sayi1,int sayi2)
        {

            int sonuc = sayi1 + sayi2;

            return sonuc;

        }
        //Aynı isimli iki adet metot yazılmıştır ancak parametleri ve geri dönüş tipleri farklı olduğu için aynı isimli olması bir problem yaratmaz.
        static string Topla(string metin1, string metin2)
        {

            string sonuc = metin1 +" şamil "+ metin2;

            return sonuc;

        }



        //Aşırı yükleme



    }
    //burayada class yazabiliriz. 
}
