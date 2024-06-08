

// DOSYA YÖNETİMİ


// DOSYA OKUMA


StreamReader sr =File.OpenText("deneme.txt");

var s="";

while((s=sr.ReadLine()) != null){
    Console.WriteLine(s);
}


string answer=File.ReadAllText("deneme.txt");
Console.WriteLine(answer);



string[] ans=File.ReadAllLines("deneme.txt");
Console.WriteLine(ans[0]);
Console.WriteLine(ans[1]);


// DOSYA YAZMA VE EKLEME


//Dosya oluşturma ve yazma
using(StreamWriter sw=File.CreateText("dm.txt")){
    sw.WriteLine("mbs");
    sw.WriteLine("asoram");
}


// oluşturduğumuz dosyaya ekleme yaptık.
using(StreamWriter sws=File.AppendText("dm.txt")){
    sws.WriteLine("selam");
}

// File.WriteAllText("deneme.txt","mbs");
// File.WriteAllText("deneme.txt","bds");


// KLASÖRLERLE ÇALIŞMA

Directory.CreateDirectory("temp");
Directory.CreateDirectory("temp/dm1");
Directory.CreateDirectory("temp/dm2");

if(Directory.Exists("temp/dm2")){
        Directory.Delete("temp/dm2");
}else{
    Console.WriteLine("silmek istediğiniz klasör yok");
}


string path=@"C:\Users\gorke\Desktop\C# BTK\file_management\temp\dropna";
Directory.CreateDirectory(path);


// DOSYA VE KLASÖRLERLE ÇALIŞMA

string rootPath=Directory.GetCurrentDirectory();


//güncel path "rootpath" atadık.
// rootpath kasörleri çağırıyoruz.
// "*" iaşareti hepsini almamızı istiyor.
//SearchOption arama opsiyonları
//AllDirectories=Bütün klasörler gelsin.
// TopDirectoryOnly = sadece üst klasörler gelsin.


// klasörlere eriştik.
string[] dirs= Directory.GetDirectories(rootPath,"*",SearchOption.TopDirectoryOnly);

// bin,obj,temp geldi.
foreach(var dir in dirs){
    Console.WriteLine(dir);
}


// dosayalara erişelim.



string[] files=Directory.GetFiles(rootPath,"*.txt",SearchOption.AllDirectories);

foreach(var file in files){
    Console.WriteLine(file);
    Console.WriteLine(Path.GetExtension(file));
    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
    Console.WriteLine(Path.GetFileName(file));

    var info= new FileInfo(file);

    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length}");
}






string uzantı=@"C:\Users\gorke\Desktop\C# BTK\file_management\ımg";
string[] fil=Directory.GetFiles(uzantı,"*",SearchOption.AllDirectories);

foreach(var file in fil){
    Console.WriteLine(file);
    Console.WriteLine(Path.GetExtension(file));
    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
    Console.WriteLine(Path.GetFileName(file));

    var info= new FileInfo(file);

    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length}");
}




string source_path = @"C:\Users\gorke\Desktop\C# BTK\file_management\ımg";
string dest_path = @"C:\Users\gorke\Desktop\C# BTK\file_management\";

string[] dosya = Directory.GetFiles(source_path,"*",SearchOption.AllDirectories);

foreach(var ds in dosya){
    Console.WriteLine(Path.GetFileNameWithoutExtension(ds));

    var inf=new FileInfo(ds);
    Console.WriteLine($"{Path.GetFileName(ds)}: {inf.Length}");

    if(!Directory.Exists(dest_path)){
        Directory.CreateDirectory(dest_path);
    }

    // random isim oluşturur.
    string name=Path.GetRandomFileName() + Path.GetExtension(ds);

    File.Copy(ds,$"{dest_path}{name}");

}
















