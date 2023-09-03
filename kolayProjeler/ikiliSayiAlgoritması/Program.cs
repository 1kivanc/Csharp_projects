using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikiliSayiAlgoritması
{
    internal class Program
    {

//Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran, sayılar aynıysa toplamının karesini ekrana yazdıran console uygulaması

//Örnek Input: 2 3 1 5 2 5 3 3

//Output: 5 6 7 81
        static void Main(string[] args)
        {
            Console.WriteLine("İkili Sayılar algortiması");
            Console.WriteLine("yan yana arada bir boşluk bırakarak sayılar giriniz (0 2 3 3 5 6) :");
            string sayilar = Console.ReadLine();
            string[] sayi = sayilar.Split(' ');

            for(int i =0; i<sayi.Length; i += 2)
            {
                int ilkSayi = int.Parse(sayi[i]);
                int ikinciSayi = int.Parse(sayi[i + 1]);
                int toplam = ilkSayi + ikinciSayi;

                if(ilkSayi != ikinciSayi)
                {
                    Console.Write(toplam + " ");
                }
                else
                {
                    int karesi = toplam * toplam;
                    Console.WriteLine(karesi + " ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
