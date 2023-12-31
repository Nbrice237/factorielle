﻿/**
* titre : denombrements
* description : calcul de permutation, arragement et combinaison
* auteur : Makebel Noel Brice
* date création : 03/07/2023
* date dernière modification : 04/07/2023
*/
using System;

namespace Factorielle
{
    class Program
    {
        /// <summary>
        /// Calcul du produit de plusieurs entiers successifs, de valeurDepart à valeurArrivee
        /// </summary>
        /// <param name="valeurDepart">valeur de départ du calcul</param>
        /// <param name="valeurArrivee">valeur d'arrivée du calcul</param>
        /// <returns>résultat du produit ou 0 si dépassement de capacité</returns>
        static long ProduitEntiers(int valeurDepart, int valeurArrivee)
        {
            long produit = 1;
            for (int k = valeurDepart; k <= valeurArrivee; k++)
            {
                produit *= k;
            }
            return produit;
        }
        static void Main(string[] args)
        {
            string choix = "1";
            while (choix != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = Console.ReadLine();
                // choix correct excluant le choix de quitter
                if (choix == "1" || choix == "2" || choix == "3")
                {
                    try
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int nbTotal = int.Parse(Console.ReadLine());
                        // choix : permutation
                        if (choix == "1")
                        {
                            long permutation = ProduitEntiers(1, nbTotal);
                            Console.WriteLine(nbTotal + "! = " + permutation);
                        }
                        else
                        {
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            int nbSousEnsenble = int.Parse(Console.ReadLine());
                            // calcul de l'arrangement qui sert aussi au calcul de la combinaison
                            long arrangement = ProduitEntiers(nbTotal - nbSousEnsenble + 1, nbTotal);
                            // choix : arrangement
                            if (choix == "2")
                            {
                                Console.WriteLine("A(" + nbTotal + "/" + nbSousEnsenble + ") = " + arrangement);
                            }
                            // choix : combinaison
                            else
                            {
                                long combinaison = arrangement / ProduitEntiers(1, nbSousEnsenble);
                                Console.WriteLine("C(" + nbTotal + "/" + nbSousEnsenble + ") = " + combinaison);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Calcul impossible : valeur(s) incorrecte(s) ou trop grande(s).");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
