using System;

namespace Arrays1_0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Övning 1
Ditt program behöver följande inledande funktion:
Programmet ska skapa en array med 100 slumpade heltal. Du får själv välja mellan vilka
värden slumptalen ska skapas (ex 1 - 100).
Programmet ska sedan leta efter ett specifikt tal (ex 53) i arrayen och skriv ut ett meddelande
om det finns och ett annat meddelande om det inte finns. 
            !!#!#!#!!#!#!*/
            //joel was not here
            /*
             
             Övning 2
Använd samma array som i övning 3:0 men nu ska programmet skriva ut alla tal som finns
lagrade med udda index i en array dvs index= 1, 3, 5 … 
            */

            Random rnd = new Random();
            int[] heltal = new int[100];
            //bool finns99 = false;
            //int s = 62;

            for (int i = 0; i < 100; i++)
            {
                heltal[i] = rnd.Next(50, 150);
                if (i % 2 == 1)
                {
                    Console.WriteLine($"Index: {i} equals number = {heltal[i]}  ");
                    //finns99 = true;
                }

            }
/*
            if (finns99)
            {
                Console.Write($"{s}  Finns i arrayen!!!1 ");
            }
            else
            {
                Console.Write($"{s} finns INTE i arrayen");
            }
*/




            Console.ReadKey();        
        }


        
    }
}
