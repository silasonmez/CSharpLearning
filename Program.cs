using System;
class Program
{
    static void Main()
    {
        /*
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
        message = 10.703;  */


        string name = "Bob";
        int counter = 3;
        decimal celcius = 34.4m;

        Console.WriteLine("HEllo," + name + "You have" + counter + "message in your inbox. The temperature is" + celcius);



        Console.WriteLine("Hello\nWorld!");
        Console.WriteLine("Hello\tWorld!");
        Console.WriteLine("hello  \"world\" !");


        int firstNumber = 12;
        int secondNumber = 7;
        Console.WriteLine(firstNumber + secondNumber);


        string firstName = "Bob";
        int widgetsSold = 7;
        Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

        //önce sayıalr toplanır ardından stringe çevrilir
        string firstName1 = "Bob";
        int widgetsSold1 = 7;
        Console.WriteLine(firstName1 + " sold " + (widgetsSold1 + 7) + " widgets.");

        //sırayla işler
        string firstName2 = "Bob";
        int widgetsSold2 = 7;
        Console.WriteLine(firstName2 + " sold " + widgetsSold2 + 7 + " widgets.");

        // int i decimale çevirdik (decimal) ile
        int first = 7;
        int second = 5;
        decimal quotient = (decimal)first / (decimal)second;
        Console.WriteLine(quotient);


        //çıktı : 2  2 3 4 
        int value = 1;
        value++;
        Console.WriteLine("First: " + value);
        Console.WriteLine($"Second: {value++}");
        Console.WriteLine("Third: " + value);
        Console.WriteLine("Fourth: " + (++value));


        int fahrenheit = 94;
        decimal temperature = ((fahrenheit - 32m) * (5m / 9m));
        Console.WriteLine(temperature);



        int currentAssignments = 5;

        int sophia1 = 93;
        int sophia2 = 87;
        int sophia3 = 98;
        int sophia4 = 95;
        int sophia5 = 100;

        int nicolas1 = 80;
        int nicolas2 = 83;
        int nicolas3 = 82;
        int nicolas4 = 88;
        int nicolas5 = 85;

        int zahirah1 = 84;
        int zahirah2 = 96;
        int zahirah3 = 73;
        int zahirah4 = 85;
        int zahirah5 = 79;

        int jeong1 = 90;
        int jeong2 = 92;
        int jeong3 = 98;
        int jeong4 = 100;
        int jeong5 = 97;

        int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
        int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
        int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
        int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

        Console.WriteLine("Sophia:: " + sophiaSum);
        Console.WriteLine("Nicolas: " + nicolasSum);
        Console.WriteLine("Zahirah: " + zahirahSum);
        Console.WriteLine("Jeong: " + jeongSum);

        decimal sophiaScore;


        sophiaScore = (decimal)sophiaSum / currentAssignments;
        Console.WriteLine(sophiaScore);

        int[] array = new int[5];
        string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };


        Console.WriteLine(weekDays[0]);
        Console.WriteLine(weekDays[1]);
        Console.WriteLine(weekDays[2]);
        Console.WriteLine(weekDays[3]);
        Console.WriteLine(weekDays[4]);
        Console.WriteLine(weekDays[5]);
        Console.WriteLine(weekDays[6]);

        // 1. Dictionary oluşturma
        Dictionary<string, string> sozluk = new Dictionary<string, string>();

        // 2. Eleman ekleme
        sozluk.Add("elma", "apple");
        sozluk.Add("armut", "pear");
        sozluk["muz"] = "banana";  // Alternatif ekleme yöntemi

        // 3. Değer okuma
        Console.WriteLine("elma: " + sozluk["elma"]);

        // 4. Değer güncelleme
        sozluk["elma"] = "green apple";
        Console.WriteLine("Güncellenmiş elma: " + sozluk["elma"]);

        // 5. Eleman kontrolü
        if (sozluk.ContainsKey("armut"))
        {
            Console.WriteLine("Armut sözlükte var.");
        }

        // 6. Eleman silme
        sozluk.Remove("muz");

        // 7. Tüm sözlüğü yazdırma
        Console.WriteLine("\nSözlükteki tüm elemanlar:");
        foreach (var item in sozluk)
        {
            Console.WriteLine($"{item.Key} => {item.Value}");
        }

        // 8. Eleman sayısı
        Console.WriteLine($"\nSözlükte {sozluk.Count} eleman var.");


        string meyve = "Elma";
        Console.WriteLine(meyve.ToUpper());
        Console.WriteLine(meyve.ToLower());

        string kelime = "merhaba";
        Console.WriteLine(kelime.Substring(0, 3));

        Console.WriteLine("merhaba".IndexOf("a")); // 4


        int x = 21;
        do
        {
            Console.WriteLine("Koşul sağlanmamasına rağmen çalıştı");
            x++;
        } while (x < 20);
        // while ile
        int y = 21;
        while (y < 20)
        {
            // Koşul sağlanmadığı için buraya hiç girmeyecek
        }




        for (int i = 1; 1 <= 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            Console.WriteLine(i);
        }




        /*  sonsuz döngü var
                for (int i = 1; 1 <= 10; i++)
                {
                    if (i == 5)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }

        */



        Console.Write("Gün girin: ");
        string gun = Console.ReadLine()!; // "!" = null gelmeyecek, eminim


        switch (gun.ToLower())
        {
            case "cumartesi":
            case "pazar":
                Console.WriteLine("Hafta sonu");
                break;
            default:
                Console.WriteLine("Hafta içi");
                break;
        }



        List<string> sehirler = new List<string>();
        sehirler.Add("İstanbul");
        sehirler.Add("Ankara");

        foreach (var sehir in sehirler)
        {
            Console.WriteLine(sehir);
        }

        DateTime simdi = DateTime.Now;
        Console.WriteLine("Bugünün tarihi: " + simdi.ToString("dd.MM.yyyy"));
        Console.WriteLine("Saat: " + simdi.ToString("HH:mm"));
        Console.WriteLine("Gün: " + simdi.DayOfWeek);


    }
}


