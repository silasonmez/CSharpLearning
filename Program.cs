using System;
class Program
{
    static void Main()
    {
        Console.WriteLine(3+3);
        Console.WriteLine("sila");
        Console.WriteLine("3+3");
        Console.WriteLine('s');
        Console.WriteLine(true);

        //string tanımladım.
        string firstName;
        firstName = "furkan";
        Console.Write(firstName);
        
        //Write-WriteLine farkı
        Console.Write('6');
        Console.WriteLine("sila");
        Console.Write('6');
        //Write(6) old. için 6 dan sonra alt satıra geçmedi 6 esra yazdı.
        string secondName = "esra";
        Console.WriteLine(secondName);
        
        // var değişken tanımlama
        var message = "iyi dersler";
        Console.WriteLine("message");
        Console.WriteLine(message);
        message = "seni seviyorum";
        Console.WriteLine(message);
        /* aşağıdaki hata verir çnk message değişkeni string olarak örtülrü 
        message = 10.703;    */


        string name = "Bob";
        int counter = 3;
        decimal celcius = 34.4m ; 

        Console.WriteLine("HEllo," + name + "You have" + counter + "message in your inbox. The temperature is" + celcius  );




    }
}