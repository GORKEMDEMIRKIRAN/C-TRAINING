

// DÖNGÜLER (LOOPS)

/* 
    FOR
    WHILE
    DO-WHILE
    FOREACH
*/


// FOR LOOPS

for ( var i=1; i <=100; i++){
    Console.WriteLine("asd");
}



// WHILE LOOPS

var y =0;
while (y<10){
    Console.WriteLine(y);
    y++;
}


string[] names={"ali","veli","seda"};

var z=0;
while( z < names.Length){
    Console.WriteLine(names[z]);
    z++;
}



var select ="e";
var counter=1;
var total=0;

while(select == "e"){
    Console.Write($"{counter}. number: ");
    total = total + Convert.ToInt16(Console.ReadLine());

    Console.Write("Devam etmek istiyor musunuz ? (e/h)");
    select = Console.ReadLine();

    counter++;
}
Console.WriteLine($"{counter-1} adet sayının toplamı: {total}");




// BREAK & CONTINUE

string isim="srıoma";

for (var x = 0; i < isim.Length; x++){
    if(isim[x] == 'ı'){
        continue;
    }
    Console.WriteLine(isim[x]);
}
Console.WriteLine("döngü bitti");



int x=0;
while(e<5){
    e++;
    if(e==3)
        continue;
    Console.WriteLine(e);
}



// DO-WHILE LOOPS

int b=1;

do{
    Console.WriteLine(b);
    b++;
}while(false);


Console.Write("adet: ");
int piece = Convert.ToInt16(Console.ReadLine());

string[] products = new string[piece];
int n=0;
do{
    Console.Write("product name: ");
    products[n]=Console.ReadLine() ?? "";  // boş değer atadık.
    n++;
}while(piece != n);  //while her zaman true bir değer üreticek.
// burada piece = 5 desek n=5 gelince eşit  olacağı için bitecek.

Console.WriteLine("ürünler listeleniyor....");

for(var a=0; a<products.Length; a++){
    Console.WriteLine(products[a]);
}




// FOR EACH LOOPS

string nm="Arial";

foreach(var letter in nm){
    Console.WriteLine(letter);
}

int[] numbers={10,20,30,50,70};

foreach(var nb in numbers){
    if(nb==20){
        break;
    }
    Console.WriteLine(nb);
}








    
















