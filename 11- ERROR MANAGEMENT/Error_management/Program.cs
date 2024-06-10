

// BU BÖLÜMDE HATA YÖNETİMİNİ ÖĞRENİCEZ ??


using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp{

    class Program{
        static void Main(string[] args)
        {

           //EXCEPTION

           // Yaptığımız uygulamada çıkan hatalar.

           // System.FormatException           // girilen format hatası
           // System.DivideByZeroException     // 0"a bölünme hatası
           // System.NullReferenceException    // null hatası

        
        // oluşabilecek hata kodunu "try" blogu içine aldık.
        // "catch" ile oluşabilecek hataları tanımladık.


        try{
           Console.WriteLine("first number: ");
           int sayi1=Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("second number: ");
           int sayi2=Convert.ToInt32(Console.ReadLine());     //TryParse   bunu kullanarak burada hata olup olmadığını bulabiliriz.

           var sonuc= sayi1/ sayi2;
        }


        // // oluşabilecek hataları tek tek tanımladık.




        // catch(FormatException){
        //     Console.WriteLine("sayısal bilgileri düzgün giriniz.");
        // }
        // catch(DivideByZeroException){
        //     Console.WriteLine("girilen sayı 0'a bölünemez.");
        // }





        // hataları genel olarak tanımlayabiliriz.
        // exception burada ex olarak tanımladık.
        catch(Exception ex){
            Console.WriteLine("bir hata oluştu.");
            // kayıtlı ex çekerek burada hatanın nereden kaynaklandığını görebiliriz.
            Console.WriteLine(ex.Message);

        }



        //    Urun urun=null;
        //    Console.WriteLine(urun.UrunAdi);


           // EXCEPTION HANLING



        }
        
    }
    class Urun{
        public string UrunAdi  { get; set; }
    }
}



