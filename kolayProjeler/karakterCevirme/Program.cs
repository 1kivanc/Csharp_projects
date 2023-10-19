using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterCevirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Karakter ters çevirme");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Lütfen bir metin giriniz: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string metin = Console.ReadLine();

                if(metin == "")
                {
                    Console.WriteLine("Hiçbir metin girmediniz");
                    continue;
                }
                string sonuc = karakterCevirme(metin);
                Console.WriteLine(sonuc);

            }


        }
        
        static string karakterCevirme(string input)
        {
            char ilkKarakter = input[0];

            char sonKarakter = input[input.Length - 1];


            char[] metinKarakter = input.ToCharArray();

            metinKarakter[0] = sonKarakter;
            metinKarakter[input.Length - 1] = ilkKarakter;

            return new string(metinKarakter);


           
        }



    }
}
