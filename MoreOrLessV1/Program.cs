using System;

namespace MoreorLess
{
    public class MoreorLess
    {

        static void Main(string[] args)
        {
            int myValeur = 0;
            int max = 101;
            Random Rand = new Random();

            int rand_numb = Rand.Next(max);


            while (myValeur != rand_numb)
            {
                Console.WriteLine("entré un chiffre compris entre 0 et 100: ");

                string myInput = Console.ReadLine();
                int.TryParse(myInput, out myValeur);
                if (int.TryParse(myInput, out myValeur))
                {
                    if (myValeur < rand_numb)
                    {
                        Console.WriteLine(myValeur + " est plus petit que le nombre a trouvé");
                    }
                    else if (myValeur > rand_numb)
                    {
                        Console.WriteLine(myValeur + " est plus grand que le nombre a trouvé");
                    }
                    else
                    {
                        Console.WriteLine("Félicitation tu as trouvé le bon numéro, le nombre mystère était : {0}", rand_numb);
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez entré une valeur comprise entre 0 et 100 en respectant le format numbre");

                }

            }


        }


    }

}
