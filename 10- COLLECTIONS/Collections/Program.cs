
using System;
using System.Collections;
using System.Net.Http.Headers;
using System.Collections.Generic;


namespace ConsoleApp{

    class Program{

        static void Main(string[] args)
        {

            // Array

            int[] sayilar = new int[5];
            sayilar[0]=10;

            // Collections

            // ArrayList
            // non-genetic => object
            // dinamik














            // ARRAYLIST
        
            ArrayList liste = new ArrayList();

            liste.Add(10);
            liste.Add("30");
            liste.Add(null);
            liste.Add(true);

            var liste2 = new ArrayList(){
                5,
                "Ahmet",
                4.5,
                null
            };

            

            int[] numbers = {10,20,30};
            liste.AddRange(numbers);

            var eleman = (int)liste[0];
            var name=liste[1].ToString();

            Console.WriteLine(name);

            Console.WriteLine(numbers);




            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }
            

            // INSERT
            liste.Insert(1,"sadık");
            // INSERTRANGE

            //2.indexten sonra liste2 ekle diyebiliriz.
            liste.InsertRange(2,liste2);

            // REMOVE
            // ilk bulduğu "null" değerini siler.
            liste.Remove(null);
            // verilen indexteki değeri siler.
            liste.RemoveAt(2);
            // belirli indexten sonra olan belirli sayıdaki değerleri siler.
            // 2.indexten sonra 3 tane değeri siler.
            liste.RemoveRange(2,3);
            
            // contains, indexOf
            // bunlarla bir değerin olup olmadığına bakabiliyoruz.
            Console.WriteLine(liste.Contains(100));   // True veya False döndürür.
            Console.WriteLine(liste.IndexOf(10));   // Index numarasını verir.

            foreach(var item in liste){
                Console.WriteLine(item);
            }













            // GENETIC LIST
            // belli bir tipe bağımlı bir liste


            List<int> informations = new List<int>();


            informations.Add(10);
            informations.Add(20);


            List<string> names = new List<string>() {"ali","ahmet","ayşe"};





            List<Product> urunler = new List<Product>();
            
            urunler.Add( new Product() {Id=1,Title="Iphone 14",Price=40000});
            urunler.Add( new Product() {Id=2,Title="Iphone 15",Price=50000});
            urunler.Add( new Product() {Id=3,Title="Iphone 16",Price=60000});


            urunler.Insert(urunler.Count,new Product() {Id=4,Title="Iphone 17",Price=70000}); 
            urunler.Insert(urunler.Count,new Product() {Id=5,Title="Iphone 18",Price=80000});

            urunler.RemoveAt(2);
            urunler.Remove(urunler[0]);

            foreach(var urun in urunler)
            {
                Console.WriteLine(urun.Title + " " + urun.Price);
            }


            


            // DICTIONARY

            // Key - value => plaka - şehir
            // dictionary  plakada şehir bilgisi gibi bir değişkenden diğer
            // bir değişken bilgisine ulaşmak için kullanılıyor.

            Dictionary<int,string> plakalar = new Dictionary<int,string>();
            // add girince girilen;
            //  ilk değer olan key =int olarak verdiğimiz için "int" olarak tanımlanıcaktır.
            // ikinci değer olan valu = string olarak verdiğimiz için "string" olarak tanımlanıcaktır.

            plakalar.Add(41,"Kocaeli");
            plakalar.Add(34,"İstanbul");
            plakalar.Add(53,"Rize");

            Dictionary<int,string> sayılar = new Dictionary<int, string>(){
                 {1,"bir"},
                 {2,"İki"},
                 {3,"Üç"}
            };


            Console.WriteLine(plakalar[41]);
            // eğer 34 bir key varsa yazdırır yoksa yazdırmaz.
            if(plakalar.ContainsKey(34)){
                Console.WriteLine(plakalar[34]);
            }

            










        }
    }

    class Product{
        public int Id { get; set;}
        public string Title { get; set;}
        public int Price { get; set;}

    }

}

