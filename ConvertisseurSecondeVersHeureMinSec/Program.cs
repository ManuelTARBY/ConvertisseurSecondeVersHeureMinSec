using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertisseurSecondeVersHeureMinSec
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclarations
            int nombre = 0;
            bool saisieCorrecte = false;
            int h, m, s;
            string heure = "";

            // Saisie
            do
            {
                while (!saisieCorrecte)
                {
                    try
                    {
                        Console.Write("Entrez un nombre de secondes (entre 0 et 86.400) : ");
                        nombre = int.Parse(Console.ReadLine());
                        saisieCorrecte = true;
                    }
                    catch
                    {
                        Console.WriteLine("Veuillez saisir une valeur correcte (entre 0 et 86.400).");
                    }
                }
                saisieCorrecte = false;
            } while (nombre < 0 || nombre > 86400);

            // Calculs
            h = nombre / 3600;
            m = (nombre % 3600) / 60;
            s = (nombre % 3600) % 60;

            // Préparation de l'affichage
            if (h < 10)
            {
                heure += "0";
            }
            heure += h + "h";
            if (m < 10)
            {
                heure += "0";
            }
            heure += m + "m";
            if (s < 10)
            {
                heure += "0";
            }
            heure += s + "s";

            // Affichage
            Console.WriteLine("Durée : " + heure);
            Console.ReadLine();
        }
    }
}
