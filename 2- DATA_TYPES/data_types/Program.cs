

/*
   C#  Data types

    Value Types:
        TAM SAYI(INTEGER):         byte,short,int,long
        ONDALIK SAYILAR(FLOAT):    float,double,decimal
        OTHER DATA TYPES:          char,boolean,struct

    Reference Types:
        String,Class,Array,Interface
*/

int sayi=200;
double kdvorani=1.18d;
float kdvorani2=1.24f;

decimal kdv_oran =1.18m;
char cinsiyet ='K';
string cinsiyet2 = "Kadın";
string product_namee="Samsung S23";
var payment_situation = false;



// Veri tipi dönüşümüne neden ihtiyaç duyarız ?

Console.Write("1.number: ");
var number1=Convert.ToInt32(Console.ReadLine());

Console.Write("2.number: ");
var number2=Convert.ToInt32(Console.ReadLine());

var total=number1 + number2;
Console.Write(total);





/*
    Veri Tipi Dönüşümü
    // implicit cashing => bilinçsiz tür dönüşümü
    // explicit cashing => bilinçli tür dönüşümü
*/
// Büyük kapı küçük kaba aktarıyoruz.
long d=20;
int e=d;
// Bunu bilinçli olarak yapıyorum "int" yaparak atıyorum.
long v=20;
int b=(int)v;

// value types bir değer alıyor.
// nullable types bir değer almadan "null" olabiliyor.
// örneğin data base aldığım maas değişkenine atıyorum.
// eğer yoksa "maas" null alıcak ama "int maas" value types
// olduğu için atamaz bu value type null olduğunu anlatmak için
// basına "?" koyarız.


// NULLABLE TYPES

int? maas=default;
bool? isActive=null;

int? maas2=20;


Console.WriteLine(new string('-', 50));
// hasvalue bir değer olup olamdığını söyler "true" veya "false"
Console.WriteLine(maas.HasValue);
// getvalueordefalut bir değer varsa değeri ve "true" verir yoksa "false" verir ve 0 değerini atar.
Console.WriteLine(maas.GetValueOrDefault());
Console.WriteLine(new string('-', 50));
Console.WriteLine(maas2.HasValue);
Console.WriteLine(maas2.GetValueOrDefault());

Console.WriteLine(new string('-', 50));
// bool bir değer olduğu için sadece "false" atar.
Console.WriteLine(isActive.GetValueOrDefault());
