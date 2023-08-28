using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucgenCizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cizlecek üçgenin boyutu ne kadar olsun: ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            UcgenCizme ucgenCizme = new UcgenCizme();
            ucgenCizme.UcgenCiz(boyut);
            Console.ReadLine();
        }
    }

    class UcgenCizme 

    {
        public void UcgenCiz(int boyut)
        {
            for(int i = 1; i<=boyut; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
        }


    }
}
