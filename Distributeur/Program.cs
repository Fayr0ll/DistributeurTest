namespace Distributeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stock1 = 5; 
            int stock2 = 2; 
            int stock3 = 0; 
            int choix;

            Console.WriteLine("Veuillez sélectionner une boisson :");
            Console.WriteLine("1. Eau");
            Console.WriteLine("2. Soda");
            Console.WriteLine("3. Orangeade");
            int.TryParse(Console.ReadLine(""), out in choix);

            switch(choix)
                case 1:
                    if(stock1 != 0)
                    {
                        Console.WriteLine("Voici votre eau !");
                        stock1 -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Stock épuisé !");
                    }
                    break;
                    switch(choix)
                case 2:
                    if(stock2 != 0)
                    {
                        Console.WriteLine("Voici votre eau !");
                        stock1 -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Stock épuisé !");
                    }
                    break;
                case 3:
                    if(stock3 != 0)
                    {
                        Console.WriteLine("Voici votre eau !");
                        stock1 -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Stock épuisé !");
                    }
                    break;
                default:
                    Console.WriteLine("Choix indisponible !")
                    break;
        }
    }
}

