

// ARİTMATİK OPERATÖRLER

int a = 10;
int b = 20;
float c = a/b;
Console.WriteLine(c);


// ATAMA OPERATÖRLERİ

a=a+b;

// KARŞILAŞTIRMA OPERATÖRLERİ

int x=5,y=10;



// Ternary Operatörü
var answer=(a>b) ? "a büyük":"b büyük";
var answer1=(a>b) ? "a büyük": (a==b) ? "a b eşit":"b büyük";

Console.WriteLine(answer);
Console.WriteLine(answer1);

// MANTIKSAL OPERATÖRLER

var v= true;
var u= false;

var sonuc =(v && u);
var sonuc1 =(v || u);
var sonuc2 =(v =! u);

Console.WriteLine(sonuc);
Console.WriteLine(sonuc1);
Console.WriteLine(sonuc2);
