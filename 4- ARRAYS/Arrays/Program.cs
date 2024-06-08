


// Arrays( DİZİLER)

var names=".net 7 ile C# programlama dersleri".Split(' ');

// string array boyutunu 5 olarak belirledik.

String[] isimler=new string[5];

isimler[0]="Ahmet";
isimler[1]="Ali";
isimler[2]="Canan";
isimler[3]="Esra";
isimler[4]="Cınar";

String[] musk={"Ahmet","Ali","Canan","Çınar","Esra"};

int[] numaralar=new int[5];
numaralar[0]=100;
numaralar[1]=200;
numaralar[2]=300;
numaralar[3]=400;
numaralar[4]=500;

int[] num={100,200,300,400,500};

Console.WriteLine($"{numaralar[0]} numaralı öğrencinin adı {isimler[0]}");
Console.WriteLine($"{numaralar[1]} numaralı öğrencinin adı {isimler[1]}");

Console.WriteLine($"{num[0]} numaralı öğrencinin adı {musk[0]}");





// Dizi Metotları(Array Methods)

string[] cities={"zonguldak","rize","kocaeli"};
int[] plakalar={63,41,34};

Console.WriteLine(cities.GetValue(1));
Console.WriteLine(cities.Length);
Console.WriteLine(Array.IndexOf(cities,"rize"));

Array.Sort(cities);
Array.Sort(plakalar);

Array.Reverse(plakalar);
Array.Clear(cities);

Console.WriteLine(plakalar.GetValue(0));
Console.WriteLine(cities.GetValue(1));

// int[] plakalar=new int[3] dersek ve değer atamassak 3 tane 0'dan oluşan array oluşturur.




//  ARRAY SLICING

// siling 0'dan 2 indexse kadar seç gibi işlemleri temsil etmektedir.

string[] city ={"istanbul","izmir","manisa","ankara","salihli"};


var answer = city[0..3];

Console.WriteLine(answer);
Console.WriteLine(answer.Length);

foreach(var ct in city){
    Console.WriteLine(ct);
    }

foreach(var rn in city[2..]){
    Console.WriteLine(rn);
}

string il="Kocaeli";
Console.WriteLine(il[..5]);



// DİZİ UYGULAMA

// Öğrenciler ve notlar isminde 2 tane dizi oluşturunuz ve dizi
// elemanlarını kullanıcıdan aldığınız değerlerle doldurunuz.(3 öğrenci)

// öğrenciler dizisi kaç elemanlıdır,yazdırınız.
// ilk 2 öğrencinin ad ve not bilgisini yazdırınız.
// tüm öğrencilerin not ortalaması nedir ?

// değer eklemeden "students" ve "notes" yazdırırsam students ekrana birşey gelmez.
// ama "int" 3 tane 0 değeri gelir.
var students = new string[3];
var notes=new float[3];

Console.WriteLine(students[0]);
Console.WriteLine(notes[0]);


// "??" işareti console değişkenine girilen değer "string" olduğu için 
// "" boş değer ata diyoruz. Console dönen değerde hata yok , readline
// altı çizileceği için bunu görmezden gel demek için koyduk.
// "tostring koyarak deniyelim.
// burada console değer girmezze "null" değer ataması yapıcaktır.
// bunu kaldırmak için "??" eğer null değer ise "" boş bırak dedik.

Console.WriteLine("1.Öğrencinin adı: ");
students[0]=Console.ReadLine().ToString();

Console.WriteLine("2.Öğrencinin adı: ");
students[1]=Console.ReadLine() ?? "";

Console.WriteLine("3.Öğrencinin adı: ");
students[2]=Console.ReadLine() ?? "";


Console.WriteLine("1.öğrecinin notu: ");
notes[0]=Convert.ToInt16(Console.ReadLine());

Console.WriteLine("1.öğrecinin notu: ");
notes[1]=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("1.öğrecinin notu: ");
notes[2]=Convert.ToInt32(Console.ReadLine());



Console.WriteLine(students[0]);
Console.WriteLine(students[1]);
Console.WriteLine(students[2]);

Console.WriteLine(notes[0]);
Console.WriteLine(notes[1]);
Console.WriteLine(notes[2]);

foreach(var st in students){
    Console.WriteLine(st);
}

float total=0;
foreach(var nt in notes){
    Console.WriteLine(nt);
    total=total + nt;
}
float average=0;
average=total/3;

Console.WriteLine("öğrenciler dizisinin eleman sayısı: "+students.Length);
Console.WriteLine("Öğrencilerin not ortalaması: "+average);




// ÇOK BOYUTLU DİZİLER

string[] student ={"ali","ahmet","canan"};
int[,] note = new int[3,3];

note[0,0]=50;
note[0,1]=60;
note[0,2]=70;

note[1,0]=60;
note[1,1]=80;
note[1,2]=90;

note[2,0]=50;
note[2,1]=70;
note[2,2]=30;

var average1=(note[0,0]+note[0,1]+note[0,2])/3;
var average2=(note[1,0]+note[1,1]+note[1,2])/3;
var average3=(note[2,0]+note[2,1]+note[2,2])/3;

Console.WriteLine($"{student[0]} öğrencinin ortalaması {average1}");
Console.WriteLine($"{student[1]} öğrencinin ortalaması {average2}");
Console.WriteLine($"{student[2]} öğrencinin ortalaması {average3}");



