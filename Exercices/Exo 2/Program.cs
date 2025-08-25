using System;

namespace Exo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean tailleEntre2et20 = true;
            while (tailleEntre2et20 == true)
            {
                Console.WriteLine("Entrez la taille du tableau: ");
                int taille = Convert.ToInt32(Console.ReadLine());
                if (taille >= 2 && taille <= 20)
                {
                    tailleEntre2et20 = false;
                    int nombrePlusGrand = int.MinValue;
                    int nombrePlusPetit = int.MaxValue;
                    int[] nombres = new int[taille];
                    int i = 0;
                    foreach (int nombre in nombres)
                    {
                        Console.WriteLine("Entrez votre chiffre: ");
                        int chiffre = Convert.ToInt32(Console.ReadLine());
                        nombres[i] = chiffre;

                        if (nombres[i] < nombrePlusPetit)
                        {
                            nombrePlusPetit = nombres[i];
                        }

                        if (nombres[i] > nombrePlusGrand)
                        {
                            nombrePlusGrand = nombres[i];
                        }
                        i++;
                    }
                    Console.WriteLine("Le nombre le plus grand est: " + nombrePlusGrand + ", le nombre le plus petit est: " + nombrePlusPetit + ", dans le tableux: ");
                    foreach (int nombre in nombres)
                    {
                        Console.WriteLine(nombre);
                    }

                }
                else
                {
                    Console.WriteLine("La taille est invalide ");
                    tailleEntre2et20 = true;
                }
            }


            Console.Read();
        }
    }
}
