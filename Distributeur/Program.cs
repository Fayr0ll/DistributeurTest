﻿namespace Distributeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //     int stock1 = 5; 
        //     int stock2 = 2; 
        //     int stock3 = 0; 
        //     int choix;

        //     Console.WriteLine("Veuillez sélectionner une boisson :");
        //     Console.WriteLine("1. Eau");
        //     Console.WriteLine("2. Soda");
        //     Console.WriteLine("3. Orangeade");
        //     int.TryParse(Console.ReadLine(""), out in choix);

        //     switch(choix)
        //         case 1:
        //             if(stock1 != 0)
        //             {
        //                 Console.WriteLine("Voici votre eau !");
        //                 stock1 -= 1;
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Stock épuisé !");
        //             }
        //             break;
        //             switch(choix)
        //         case 2:
        //             if(stock2 != 0)
        //             {
        //                 Console.WriteLine("Voici votre eau !");
        //                 stock1 -= 1;
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Stock épuisé !");
        //             }
        //             break;
        //         case 3:
        //             if(stock3 != 0)
        //             {
        //                 Console.WriteLine("Voici votre eau !");
        //                 stock1 -= 1;
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Stock épuisé !");
        //             }
        //             break;
        //         default:
        //             Console.WriteLine("Choix indisponible !")
        //             break;
    
    int stock1 = 0;
    int stock2 = 2;
    int stock3 = 3;
    string choix;

    do
    {
        Console.WriteLine("Choisissez une boisson. Boisson1: 1, Boisson2: 2, Boisson3: 3, FINIR : 4")
        Console.ReadLine(choix);
        if (choix == 1)
        {
            if (stock1 > 0)
            {
                Console.WriteLine("Voici votre boisson1 , santé!");
                stock1 -= 1;
            }
            else Console.WriteLine("Plus de boisson1");
        }
        else if (choix == 2)
        {
            if (stock2 > 0)
            {
                Console.WriteLine("Voici votre boisson2 , santé!");
                stock2 -= 1;
            }
            else Console.WriteLine("Plus de boisson2");
        }
        else if (choix == 3)
        {
            if (stock3 > 0)
            {
                Console.WriteLine("Voici votre boisson3 , santé!");
                stock3 -= 1;
            }
            else Console.WriteLine("Plus de boisson3");
        }
    }while((stock1 + stock 2 + stock 3) > 0) ET (choix != 4);

    Console.WriteLine("Merci d'utiliser distributeur 3000!")
    }
}

