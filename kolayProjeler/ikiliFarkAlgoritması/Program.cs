using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikiliFarkAlgoritması
{
    internal class Program
    {
        //Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan. Küçük olanların farklarının toplamını, büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulaması.

        //Örnek: Input: 56 45 68 77

        //Output: 33 101
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı algoritması Girilen sayılar eğer 67 küçükse farkı alınır büyükse mutlak kareleri");
            Console.WriteLine("Aralarında bir boşluk bırakarak sayıları giriniz :");
            string sayilar = Console.ReadLine();
            string[] sayi = sayilar.Split(' ');

            int farktoplam = 0;
            int mutlakToplam = 0;

            foreach (string x in sayi)
            {
                int number = int.Parse(x);

                if (number < 67)
                {
                    farktoplam += (67 - number); 
                }
                else
                {
                    int fark = number - 67;
                    mutlakToplam += (number * number);
                }
            }
            Console.WriteLine("Küçük olanların farklarının toplamı: " + farktoplam);
            Console.WriteLine("Büyük olanların farklarının mutlak karelerinin toplamı: " + mutlakToplam);
            Console.ReadLine();
        }
    }
}
