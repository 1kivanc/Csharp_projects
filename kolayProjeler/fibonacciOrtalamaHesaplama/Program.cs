using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciOrtalamaHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fibonacci serisi derinliğini giriniz: ");
            int derinlik = Convert.ToInt32(Console.ReadLine());

            FibonacciSerisi fibonacciSerisi = new FibonacciSerisi();
            double ortalama = fibonacciSerisi.HesaplaOrtalama(derinlik);

            Console.WriteLine($"Fibonacci serisinin derinliği {derinlik} olan rakamlarının ortalaması: {ortalama}");
            Console.ReadLine();
        }
    }
    class FibonacciSerisi
    {
        public double HesaplaOrtalama(int derinlik)
        {
            int[] fibonacciRakamlari = FibonacciHesaplayici.FibonacciSerisiAl(derinlik);

            double toplam = 0;
            foreach (int rakam in fibonacciRakamlari)
            {
                toplam += rakam;
            }

            double ortalama = toplam / derinlik;
            return ortalama;
        }
    }

    class FibonacciHesaplayici
    {
        public static int[] FibonacciSerisiAl(int derinlik)
        {
            int[] fibonacciRakamlari = new int[derinlik];
            for (int i = 0; i < derinlik; i++)
            {
                if (i <= 1)
                {
                    fibonacciRakamlari[i] = i;
                }
                else
                {
                    fibonacciRakamlari[i] = fibonacciRakamlari[i - 1] + fibonacciRakamlari[i - 2];
                }
            }
            return fibonacciRakamlari;
        }
    }

}
