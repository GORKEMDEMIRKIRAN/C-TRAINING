

// KOŞULLU BLOKLAR 

/*
   if/else
   if/else if / else
   switch/case
   ternary(?:)
*/

// IF-ELSE

string username="brm";
string password="234";

if (username=="brown"){
    if (password=="234"){
        Console.WriteLine("Giriş başarılı");
    }else{
        Console.WriteLine("parola hatalı");
    }
}else{
    Console.WriteLine("Kullanıcı ismi hatalı");
}


// IF-ELSE IF -ELSE

int x=20;
int y=20;

if(x>y){
    Console.WriteLine("x y 'den büyüktür.");
}
else if(x==y){
    Console.WriteLine("x y eşittir.");
}
else{
    Console.WriteLine("x y'den küçüktür.");
}


// SWITCH - CASE

int month=12;

switch(month){
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar");
        break;
    default:
        Console.WriteLine("Hatalı ay bilgisi");
        break;

}


// TERNARY

int number=-9;

var answer = (number %2 ==0) ?
              (number>0) ? "sayı çift ve pozitiftir.":"sayı çift ve negatiftir.":
              (number>0) ? "sayı tek ve pozitiftir.":"sayı tek ve negatiftir.";
Console.WriteLine(answer);














