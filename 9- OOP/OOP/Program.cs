

// OOP -NESNE TABANLI PROGRAMLAMA



// 1- Class Nedir ?

// class yapılarını göreceğiz.
// projelerimizde gruplamayı ve karışıklığı azaltmaktadır.


// namespace - class gruplayan bir kavramdır.
//console class ait olduğu namespace "system" namespace'dir.
// console aslında "system.console" şeklinde ulaşmalıyım.
// aslında console altta verilen örnek ile ulaşılıyor.

// namespace System{
//     class console()
// }
// .net 6 ve sonrasında system içerisinde tanımlanmış yazmasak bile "system" class altında geliyor.

// altta veridimizde system namespace altında olan herhangi bir sınıfa erişebilirim diyoruz.


//csproj içindeki alttaki eklenti "disable" olursa
// <ImplicitUsings>enable</ImplicitUsings>

// namespacelerdir.
using System;
using System.IO;


// yeni bir class oluşturduğumuzda class farklı bir namespace içinde ise
// using namespace adı; şeklinde belirtmemiz lazım

// Directory sınıfı Sytem.IO  altında
// namespaceler class barındırıyor.


namespace ConsoleApp{

    class Program{
        static void Main(string[] args){
            System.Console.WriteLine("hello");

            // class => object(ogr1,ogr2)
            student ogr1=new student();
            ogr1.Student_no="100";
            ogr1.name_surname="ali ataç";
            ogr1.lesson="6/A";
            student ogr2=new student();
            ogr2.Student_no="101";
            ogr2.name_surname="nura dikeç";
            ogr2.lesson="6/A";
            student ogr3=new student();
            ogr3.Student_no="102";
            ogr3.name_surname="fikret aran";
            ogr3.lesson="6/A";


            Console.WriteLine($"{ogr1.Student_no} numaralı öğrencinin adı soyadı {ogr1.name_surname} ve şubesi {ogr1.lesson}");
            Console.WriteLine($"{ogr2.Student_no} numaralı öğrencinin adı soyadı {ogr2.name_surname} ve şubesi {ogr2.lesson}");
            Console.WriteLine($"{ogr3.Student_no} numaralı öğrencinin adı soyadı {ogr3.name_surname} ve şubesi {ogr3.lesson}");

            
            student[] ogrencıler=new student[3];
            ogrencıler[0]=ogr1;
            ogrencıler[1]=ogr2;
            ogrencıler[2]=ogr3;
 
            foreach(var std in ogrencıler){
                Console.WriteLine($"{std.Student_no} numaralı öğrencinin adı soyadı {std.name_surname} ve şubesi {std.lesson}");
            }

        // üstte yazdıklarımızı daha kısa hale getirelim.

        // ogrc1 içinde alt alta yazdığını düşün. aklın karışmasın.
        student ogrc1=new student(){Student_no="100",name_surname="ali fırma",lesson="6/B"};
        student ogrc2=new student(){Student_no="200",name_surname="ali fırma",lesson="7/B"};
        student ogrc3=new student(){Student_no="1300",name_surname="ali fırma",lesson="8/B"};
        student[] kabuklar=new student[3]{ogrc1,ogrc2,ogrc3};
        foreach(var st in kabuklar){
            Console.WriteLine($"{st.Student_no} numaralı öğrencinin adı soyadı {st.name_surname} ve şubesi {st.lesson}");
        }


        // buradan sonra yazdığımız method kullanarak yazdırma işlemi yapalım.
        // ınformation_print() ile yazırdık.
        student og1=new student(){Student_no="100",name_surname="ali fırma",lesson="6/B"};
        student og2=new student(){Student_no="200",name_surname="ali fırma",lesson="7/B"};
        student og3=new student(){Student_no="1300",name_surname="ali fırma",lesson="8/B"};
        student[] projeler=new student[3]{ogr1,og2,og3};
        foreach(var pr in projeler){
            pr.Information_print();
        }

        // ınformation_print_2() ile geriye dönen bir değer ile yazdıralım.
        foreach(var cs in projeler){
            //1.yol ile yazdırma
                //string dönen bir değer direkt yazdırdık.
            Console.WriteLine(cs.Information_print_2());
            //2.yol ile yazdırma
            string snc=cs.Information_print_2();
            Console.WriteLine(snc);




        }
    }
    }

    class student{
        // Property => srting,int   // class bünyesinde bunlara property denmektedir.

        //"prop" yazıp tab tuşuna basarak çağırabiliriz.
        // bunları kullanmayınca altını çizerek kullanılmadı uyarısı verir.
        // bu uyarı kaldırmak isteden "oop.csproj" dan <Nullable>enable</Nullable> "disable" yazarak devre dışı bırakabiliriz.
        public string Student_no { get; set; }
        public string name_surname { get; set; }
        public string lesson { get; set; }

        //methods => bilgileriyazdır()   // property kullanarak işlem yaptırdığım metodlardır.

        // method tanımlayalım.
        // void bize geri bir değer döndürmüyor.
        public void Information_print(){
            Console.WriteLine($"{this.Student_no} numaralı öğrencinin adı soyadı {this.name_surname} ve şubesi {this.lesson}");
        }
        // geriye bir değer döndüreni yazalım.
        public string Information_print_2(){
            // bu satır string bir değer olduğu için string olarak tanımladık.
            return $"{this.Student_no} numaralı öğrencinin adı soyadı {this.name_surname} ve şubesi {this.lesson}";
        }

    }
}

// sistem ilk çalıştığı anda projenin başında olan main metodu altındakiler çalışır.
// yani main metodunu eklemem lazım ki class tanımlayabileyim.
// namespace ve altlarında barındırdıkları sınıflarır örnek olarak gösterelim.

//ConsoleApp => Program,Öğrenci
//System => Console
//System.IO=> File,Directory,PaTH

// Program ilk çalıştığında ilk çalışan method program class altındaki
// static main metodudur.Programın başlangıç yeridir.
// main blogunu bu şekilde ekledik .Class tanımlaya bilmek içinç
// python class hatırla üstte belirtmemiz gerekiyordu.



// METHODS

// ögrenci sınıfı oluşturup bunları doldurarak kullanabilirim.
// class tanımladığımız property yani özellikler dışında classların method özellikleri var.
// bunlara örnek olarak "bilgileriyazdır()" metodu


// buradan sonra oop_application uygulama örneği yaptık.



// ACCESS MODIFIERS ( STATİK METHOD)



// random bir instance sınıftır.
// random bir instance class
// Math bir örnek oluşturunca random gibi tanımlamıyorum.
// math statik bir sınıftır.
// "." koyarak sınıf üzerinden eriştiğimiz metodlara statik methodlar diyoruz.
// nesne üzerinden değilde, doğrudan sınıf üzerinden erişilen metodlara statik metodlar denir.
// bunu yardımcı bir metod olarak düşünebilirsiniz.



// program - main ( program sınıfına özel main bir statik methoddur.)

namespace CNS{

    class Program{
        static void Main(string[] args){
            Random rnd=new Random();
            Console.WriteLine(rnd.Next(1,100));

            Math.Min(1,6);
            

            var snc=HelperMethods.KarakterDüzelt("ölçme ultra direkt");
            Console.WriteLine(snc);
     
        }

    class HelperMethods{
         public static string KarakterDüzelt(string str){
            return
                 str.Replace("ö","o")
                 .Replace("ü","u")
                 .Replace("ı","i")
                 .Replace("ç","c");
         }
    }

    }
}  
        






