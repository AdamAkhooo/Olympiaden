using System;
using System.Security.Cryptography.X509Certificates;

class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in ett ord som ska upprepas");
         string ordet = Console.ReadLine();
        
        Console.WriteLine("hur många gånger ska ditt ord upprepas?");
        int gånger = int.Parse(Console.ReadLine());

        for(int i=0; i< gånger;i++)

        

        Console.WriteLine(ordet);

    }
}
