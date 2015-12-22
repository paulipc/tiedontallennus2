using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.IO.File;



namespace TiedonTallennus2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = @"C:\temp\lämpötila.txt";
            // luetaan tiedostosta aiemmin asetettu lämpötila
            if (File.Exists(tiedosto))
            {
                string aiempiArvo = ReadAllText(tiedosto);
                Console.WriteLine("Aiemmin asetettu arvo: " + aiempiArvo);

            }
            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);

            // tiedostoon kirjoittaminen

            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu.");
            Console.ReadLine();


        }
    }
}
