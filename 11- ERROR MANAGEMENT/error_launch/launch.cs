

// ERROR LAUNCH  -  HATA FIRLATMA

// Bu kısımda kendi hatalarımızı oluşturucaz.
// Buna hata fırlatma deniyor.



using System;

// arraylist collectionunu aktif etmek için
using System.Collections;

// generic collevtioununu aktif etmek için
using System.Collections.Generic;

// any metodunu aktif etmek için
using System.Linq;

namespace ConsoleApp{

    class Program{

        // sınıf içerisinden kendi static void oluşturabiliriz.
        static void parola_kontrol(string password){

            if(password.Length<6 || password.Length >10){
                throw new Exception("Parola 6-10 karakter aralığında olmalıdır.");
            }
            // char.IsDigit  = her bir karakterin rakam olup olmadığını sorgular.
            if(!password.Any(char.IsDigit)){
                throw new Exception("Parola en az bir rakam içermelidir.");
            }
            // char.IsLetter = her bir karakterin harf olup olmadığını sorgular.
            if(!password.Any(char.IsLetter)){
                throw new Exception("Parola en az bir harf içermelidir.");
            }
        }





        static void Main(string[] args)
        {
            Console.Write("password: ");
            string parola=Console.ReadLine();

            try{
                parola_kontrol(parola);
                Console.WriteLine("rapola geçerli");
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }

        }
        
    }

}








