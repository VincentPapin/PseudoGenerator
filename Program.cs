using System;
using System.Collections.Generic;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace TestCSharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //GENERATEUR DE PSEUDO
            bool saisieNbreCarac = false;
            int nbreCarac = 0;
            string saisie;
            string pseudo = "";
            Random rand = new Random();
            int indiceRand = 0;

            //tableau des voyelles
            List<Char> listeVoyelle = new List<char>{'a','e','i','o','u','y'};
            //tableau des consonnes
            List<Char> listeConsonne = new List<char>{'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','z'};

            //Saisie du nbre de caractère
            while (!saisieNbreCarac)
            {
                Console.WriteLine("Saisie nombre de caractères : ");
                saisie = Console.ReadLine();

                if (!int.TryParse(saisie, out nbreCarac))
                {
                    Console.WriteLine("Vous devez saisir un entier");
                }else
                {
                    if (nbreCarac > 0)
                    {
                        saisieNbreCarac = true;
                    }
                }
            }

            for (int i = 0; i < nbreCarac; i++)
            {
                //Si i est paire alors c'est voyelle
                if (i%2 == 0)
                {
                    indiceRand = rand.Next(0, listeVoyelle.Count);
                    pseudo += listeVoyelle[indiceRand].ToString();
                }else
                {
                    indiceRand = rand.Next(0, listeConsonne.Count); 
                    pseudo += listeConsonne[indiceRand].ToString();  
                }
             }

            pseudo = Char.ToUpper(pseudo[0])+pseudo.Substring(1);

             Console.WriteLine($"Ton pseudo : {pseudo}");

            
            // List<Test> listeTest = new List<Test>();
            // Random rand = new Random();
            // int nbreRand = rand.Next(1,100);
            // bool trouve = false;
            // int nbreSaisie;
            // string sNbreSaisie;
            // int nbreEssai = 0;

            // while (!trouve)
            // {
            //     nbreEssai++;
            //     Console.WriteLine("Veuillez saisir un nombre entre 1 et 100");
            //     sNbreSaisie = Console.ReadLine();
            //     if (!int.TryParse(sNbreSaisie, out nbreSaisie))
            //     {
            //         Console.WriteLine("Mauvaise saisie");
            //     }else
            //     {
            //         if (nbreSaisie == nbreRand)
            //         {
            //             trouve = true;
            //         }else if (nbreSaisie < nbreRand)
            //         {
            //             Console.WriteLine("C'est plus");
            //         }else
            //         {
            //             Console.WriteLine("C'est moins");
            //         }
            //     }

            // }

            // Console.WriteLine($"GG tu as trouvé le nombre mystère en {nbreEssai} essais");


            // for (int i = 0; i < 10; i++)
            // {
            //     listeTest.Add(new Test(){nom = "Toto "+i, age = i});
            // }

            
            // foreach (var item in listeTest)
            // {
            //     Console.WriteLine($"Nom : {item.nom} Age : {item.age}"); 
            // }

        } 
      
    }
}
