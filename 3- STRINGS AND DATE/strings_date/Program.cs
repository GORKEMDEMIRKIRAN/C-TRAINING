




/*
   String Methods
*/

// Console.WriteLine("Name: ");
// var name=Console.ReadLine();

// Console.WriteLine("Surname: ");
// var surname=Console.ReadLine();

// Console.WriteLine("Old: ");
// var old=Console.ReadLine();

// String concat
// string message= name + " " + surname + " isimli kişi " + old + " yaşindadir.";

// // String interpolation
// string mesaj=$" {name} {surname} isimli kişi {old} yaşindadir.";

// Console.WriteLine(message);
// Console.WriteLine(mesaj);





string menager= "Ahmet turan isimli kişi 20 yaşındadır.";

var sonuc =menager.Length;
//hepsini küçük yapar.
var sonuc1 =menager.ToLower();
// hepsini büyük harf yapar.
var sonuc2 =menager.ToUpper();
// Trim baştaki ve sondaki boşlukları alır.
var sonuc3 =menager.Trim();


var sonuc4=menager.Split(" ")[0];      // ilk boşluğa kadar olan 0 index alıyor
var sonuc5=menager[0];                 // ilk index alıyor.
var sonuc6=menager.StartsWith("B");    //Başlangıçta "B" string var mı yoksa "false"
var sonuc7=menager.EndsWith(".");      //"." ile mi bitiyor doğruysa "true"

var sonuc8=menager.Contains("Ali");    //"ALİ" string var mı 

var sonuc9=menager.IndexOf("kişi");     // kişi index konumunu buluyor.
var sonuc10=menager.IndexOf("abc");     // konumunu bulmak için "-1" gelirse içinde yoktur.

var sonuc11=menager.Substring(6,5);     // başlangıç ve son index  girerek string getirmemizi sağlar.



Console.WriteLine(sonuc);
Console.WriteLine(sonuc1);
Console.WriteLine(sonuc2);
Console.WriteLine(sonuc3);

Console.WriteLine(sonuc4);
Console.WriteLine(sonuc5);
Console.WriteLine(sonuc6);
Console.WriteLine(sonuc7);
Console.WriteLine(sonuc8);
Console.WriteLine(sonuc9);
Console.WriteLine(sonuc10);
Console.WriteLine(sonuc11);

Console.WriteLine(new string('-', 50));




/*
    STRING UYGULAMASI
*/

string course_name=".NET 7 ile C# Programlama Dili";

// 1-kaç karaktere sahiptir?
// 2-Hepsini küçük harf yapınız.
// 3- '.' ile mi başlamaktadır?
// 4-  C# bilgisi hangi konumda bulunmaktadır ?
// 5- String 'C#' bilgisini içeriyor mu ?
// 6- "Dili" kelimesi yerine "Dersleri" yazınız. (replace)




var line=course_name.Length;
Console.WriteLine(line);
var lower=course_name.ToLower();
Console.WriteLine(lower);
var question=course_name.StartsWith(".");
Console.WriteLine(question);
var cell=course_name.IndexOf("C");
Console.WriteLine(cell);
var rb=course_name.Contains("C#");
Console.WriteLine(rb);
var nbr=course_name.Replace("Dili","Dersleri");
Console.WriteLine(nbr);




Console.WriteLine(new string('-', 50));
/* 
    DATA TİME
*/

var simdi=DateTime.Now;

Console.WriteLine(simdi);
Console.WriteLine(simdi.Year);
Console.WriteLine(simdi.Month);
Console.WriteLine(simdi.Day);
Console.WriteLine(simdi.DayOfWeek);
Console.WriteLine(simdi.Hour);
Console.WriteLine(simdi.Minute);
Console.WriteLine(simdi.Second);

DateTime dt=new DateTime(2022,6,10,12,23,56);

DateTime dt2= dt.AddYears(1);
DateTime dt3= dt.AddMonths(3);

Console.WriteLine(dt2.Year);
Console.WriteLine(dt3.Month);
Console.WriteLine(dt3);

var different=simdi-dt;
// güncel tarihin saat ve gün farkları
Console.WriteLine(different.TotalDays);
Console.WriteLine(different.TotalHours);