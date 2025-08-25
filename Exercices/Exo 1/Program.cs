using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre chiffre: ");
            int chiffre = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int chiffreProduit = chiffre * i;
                Console.WriteLine(chiffre + " x " + i + " = " + chiffreProduit);
            }
            

            Console.Read();
        }
    }
}
