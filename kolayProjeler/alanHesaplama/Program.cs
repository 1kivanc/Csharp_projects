
using System;
using System.Security.Cryptography;

namespace AlanHesaplama
{
  class Program
  {
    static void Main(string[] args)
    {
        bas:
        Console.WriteLine("Alan hesaplama programına hoşgeldiniz ");
        Console.WriteLine("1-) Daire alanı hesapla");
        Console.WriteLine("2-) Üçgen alanı hesapla");
        Console.WriteLine("3-) Kare Alanı hesapla");
        Console.WriteLine("4-) Dikdörtgen alanı hesapla");
        Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
        string islem = Console.ReadLine();
        if(int.TryParse(islem, out int secim)){
            switch(secim){
                case 1:
                    DaireHesapla();
                    break;
                case 2:
                    ucgenHesapla();
                    break;
                case 3: 
                    kareHesapla();
                    break;
                case 4: 
                    DikdortgenHesapla();
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem sectiniz");
                    return;                
            }
        }else{
            Console.WriteLine("lütfen yapmak istediğiniz işlem ile eşleşen sayıyı yazınız");
            goto bas;
        }

    }
    static void DaireHesapla() {
        Console.Write("Dairenin yarıçapını giriniz :");
        double yaricap = double.Parse(Console.ReadLine());
        
        double alan = Math.PI * Math.Pow(yaricap, 2);
        Console.WriteLine($"Dairenin alanı : {alan}");

    }
    static void ucgenHesapla() {
        Console.Write("Üçgeninin taban uzunluğunu giriniz: ");
        int taban = int.Parse(Console.ReadLine());
        Console.Write("Üçgenin yüksekliğini giriniz:");
        int yükseklik = int.Parse(Console.ReadLine());

        int alan = (taban * yükseklik) / 2;
        Console.WriteLine($"Üçgenin alanı: {alan}");

    }

    static void kareHesapla() {
        Console.Write("Bir kenarının uzunluğunu giriniz: ");
        int kenar = int.Parse(Console.ReadLine());

        int alan = kenar*kenar;
        Console.WriteLine($"Karenin alanı: {alan}");

    }
    static void DikdortgenHesapla(){
        Console.Write("Uzun kenarının uzunluğunu giriniz: ");
        int uzunKenar = int.Parse(Console.ReadLine());
        Console.Write("Kısa kenarının Uzunluğunu giriniz: ");
        int kisaKenar = int.Parse(Console.ReadLine());
        
        int alan = uzunKenar * kisaKenar;
        Console.WriteLine($"Dikdörtgenin alanı: {alan}");
    }
  }
}