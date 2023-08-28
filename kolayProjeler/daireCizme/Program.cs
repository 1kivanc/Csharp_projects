using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daireCizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cizilecek dairenin yarıçapını giriniz: ");
            double yaricap = Convert.ToDouble(Console.ReadLine());

            DaireCizici dairecizici = new DaireCizici();
            dairecizici.DaireCiz(yaricap);
            Console.ReadLine();
        }
    }

    class DaireCizici
    {
        public void DaireCiz(double yaricap)
        {
            int daireMerkezi = (int)yaricap;
            for(int i = 0; i<= 2* yaricap; i++)
            {
                for(int j= 0; j<= 2*yaricap; j++)
                {
                    // iki nokta arası uzaklık hasaplamaya yarar 
                    double uzaklik = Math.Sqrt((i - yaricap) * (i - yaricap) + (j - yaricap) * (j - yaricap));
                    if(uzaklik>yaricap-0.5 && uzaklik < yaricap + 0.5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
  
}
