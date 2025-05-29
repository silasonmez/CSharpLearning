using System;

class Program
{
    static void Main()
    {
        Console.Write("HOŞGELDİNİZ! ");
        Console.Write("Adınızı girin: ");
        string? kullaniciAdi = Console.ReadLine();
        bool devam = true;

        while (devam)
        {

            Console.Clear(); // ekranı temizle
            Console.WriteLine($"Merhaba, {kullaniciAdi}!");
            Console.WriteLine("\n===== MENÜ =====");
            Console.WriteLine("[1] Toplama");
            Console.WriteLine("[2] Çıkarma");
            Console.WriteLine("[3] Çarpma");
            Console.WriteLine("[4] Bölme");
            Console.WriteLine("[5] Yaş Hesapla");
            Console.WriteLine("[7] Tahmin Oyunu");
            Console.WriteLine("[6] Çıkış");
            Console.Write("Seçiminizi yapın: ");

            string secim = Console.ReadLine()!;

            switch (secim)
            {
                case "1":
                    ToplamaYap();
                    break;
                case "2":
                    CikarmaYap();
                    break;
                case "3":
                    CarpmaYap();
                    break;
                case "4":
                    BolmeYap();
                    break;
                case "5":
                    YasHesapla();
                    break;
                case "6":
                    devam = false;
                    Console.WriteLine("Programdan çıkılıyor...");
                    break;
                case "7":
                    TahminOyunu();
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;

            }
                if (devam)
            {
                Console.Write("\nDevam etmek için bir tuşa basın...");
                Console.ReadKey();
            }
        }
    }

    static void ToplamaYap()
    {
        int a = SayiAl("Birinci");
        int b = SayiAl("İkinci");
        Console.WriteLine("Toplam: " + (a + b));
    }

    static void CikarmaYap()
    {
        int a = SayiAl("Birinci");
        int b = SayiAl("İkinci");
        Console.WriteLine("Fark: " + (a - b));
    }

    static void CarpmaYap()
    {
        int a = SayiAl("Birinci");
        int b = SayiAl("İkinci");
        Console.WriteLine("Çarpım: " + (a * b));
    }

    static void BolmeYap()
    {
        int a = SayiAl("Bölünen");
        int b;
        do
        {
            b = SayiAl("Bölen (0 olamaz)");
        } while (b == 0);
        double sonuc = (double)a / b;
        Console.WriteLine($"Bölüm: {Math.Round(sonuc, 2)}");
    }

    static void YasHesapla()
    {
        Console.Write("Doğum yılınızı girin: ");
        int dogumYili = Convert.ToInt32(Console.ReadLine());
        int yas = DateTime.Now.Year - dogumYili;
        Console.WriteLine("Yaşınız: " + yas);
    }
        static void TahminOyunu()
        {
            Random rnd = new Random();
            int rastgeleSayi = rnd.Next(1, 101); // 1-100 arası
            int tahmin;
            int denemeSayisi = 0;

            Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Tahmin etmeye çalış!");

            do
            {
                tahmin = SayiAl("Tahmin");
                denemeSayisi++;

                if (tahmin < rastgeleSayi)
                    Console.WriteLine("Daha büyük bir sayı girin.");
                else if (tahmin > rastgeleSayi)
                    Console.WriteLine("Daha küçük bir sayı girin.");
                else
                    Console.WriteLine($"Tebrikler! {denemeSayisi}. denemede doğru tahmin ettiniz.");

            } while (tahmin != rastgeleSayi);
        }

    // Ortak sayı alma fonksiyonu
    static int SayiAl(string siralama)
    {
        int sayi;
        while (true)
        {
            Console.Write($"{siralama} sayıyı girin: ");
            string? giris = Console.ReadLine();

            if (int.TryParse(giris, out sayi))
                return sayi;
            else
                Console.WriteLine("Geçersiz giriş! Lütfen bir tam sayı girin.");
        }
    }

}
