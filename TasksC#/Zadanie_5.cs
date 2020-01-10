using System;

namespace Etap1
{
    public class Zadanie_5
    {
        //ostatnie niezerowe cyfry dla silni obliczonej przy (n=1..10)
        static readonly int[] nonZeroDigits = { 1, 1, 2, 6, 4, 2, 2, 4, 2, 8 };

        public static int FindLastNonZeroDigit(int n)
        {
            if (n < 10)
                return nonZeroDigits[n];

            //wzory na podstawie https://math.stackexchange.com/questions/130352/last-non-zero-digit-of-a-factorial

            /*Zak�adaj�c, �e D(n) to ostatnia niezerowa cyfra dla n! to: 
              - je�li cyfra dziesi�tek (lub druga ostatnia cyfra) jest nieparzysta
                D(n) = 4 * D(floor(n / 5)) * D(cyfra jedno�ci z n)
              - je�li cyfra dziesi�tek (lub druga ostatnia cyfra) jest parzysta
              //D(n) = 6 * D(floor(n / 5)) * D(cyfra jedno�ci z n)*/

            if (((n / 10) % 10) % 2 == 0)
                return (6 * FindLastNonZeroDigit(n / 5) *
                        nonZeroDigits[n % 10]) % 10;

            else
                return (4 * FindLastNonZeroDigit(n / 5) *
            nonZeroDigits[n % 10]) % 10;
        }

        public static void Main(string[] args)
        {
            Random rand = new Random();
            while (true)
            {
                int amount;
                int[] tab;

                Console.WriteLine("Podaj liczb� test�w > 0: ");

                while (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0 || amount > 100)
                {
                    Console.WriteLine("Prosz� poda� poprawn� liczb� test�w: ");
                    continue;
                }

                tab = new int[amount];

                Console.WriteLine("Wej�cie");
                for (int k = 0; k < amount; k++)
                {
                    int randNumber = rand.Next(1, 101);
                    tab[k] = randNumber;
                    Console.WriteLine(tab[k]);
                }

                Console.WriteLine("\nWyj�cie");
                foreach (int t in tab)
                {
                    Console.WriteLine(FindLastNonZeroDigit(t));
                }
            }
        }
    }
}

