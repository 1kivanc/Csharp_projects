using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Örnek: Input: Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0

            //Output: Algritma Algortma Algoritma lgoritma
            Console.Write("lütfen bir ifade girin örnek format(yazi,2): ");
            string input = Console.ReadLine();

            string[] parts = input.Split(',');
            if(parts.Length != 2)
            {
                Console.WriteLine("Girdiğiniz ifade geçersiz tekrar deneyiniz");
            }

            string text = parts[0].Trim();
            if(int.TryParse(parts[1], out int index))
            {
                if(index >= 0 && index < text.Length)
                {
                    string modifiedText = text.Remove(index, 1);
                    Console.WriteLine("Sonuç: " + modifiedText);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("girilen değer geçersiz");
                }
            }
            else
            {
                Console.WriteLine("Bir integer değerde bekleniyordu");
            }

        }
    }
}
