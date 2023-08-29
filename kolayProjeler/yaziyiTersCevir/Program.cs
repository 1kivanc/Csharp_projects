using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yaziyiTersCevir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir string ifade girin:");
            string input = Console.ReadLine();

            string swappedText = SwapCharacters(input);
            Console.WriteLine("Sonuç: " + swappedText);
            Console.ReadLine();
        }

        static string SwapCharacters(string input)
        {
            char[] charArray = input.ToCharArray();

            for (int i = 0; i < charArray.Length - 1; i += 2)
            {
                char temp = charArray[i];
                charArray[i] = charArray[i + 1];
                charArray[i + 1] = temp;
            }

            return new string(charArray);
        }



    }
}
