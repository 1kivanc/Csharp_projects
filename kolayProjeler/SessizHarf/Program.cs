using System;

class Program{
    static void Main(){

        Console.Write("Metini Gitiniz: ");
        string metin = Console.ReadLine();

        string sessizHarfler = "bcçdfgğhjklmnprsştvyz";

        for(int i = 0; i< metin.Length -1; i++){

            char karakter1 = char.ToLower(metin[i]);
            char karakter2 = char.ToLower(metin[i+1]);

            if(sessizHarfler.Contains(karakter1.ToString()) && sessizHarfler.Contains(karakter2.ToString())){
                Console.WriteLine("true");
            }else{
                Console.WriteLine("false");
            }
        }
        Console.WriteLine();
    }
}
