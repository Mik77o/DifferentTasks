using System;

namespace Etap1
{
    public class Zadanie_3
    {
        public static int IsPrime { get; set; }

        public static void Main(string[] args)
        {
            while (true)
            {
                int amount;
                Console.WriteLine("Podaj liczbê testów > 0: ");

                while (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0 || amount >= 100)
                {
                    Console.WriteLine("Proszê podaæ poprawn¹ liczbê testów: ");
                    continue;
                }
                CheckPrimeNumbers(amount);
            }
        }

        public static void CheckPrimeNumbers(int numb)
        {
            int temp = 0, i;

            Random rand = new Random();

            for (int k = 0; k < numb; k++)
            {

                int randNumber = rand.Next(1, 1001);
                IsPrime = 0;

                temp = randNumber / 2;
                for (i = 2; i <= temp; i++)
                {
                    if (randNumber % i == 0)
                    {
                        Console.WriteLine(string.Concat(randNumber, " NIE"));
                        IsPrime = 1;
                        break;
                    }
                }
                if (IsPrime == 0)
                    Console.WriteLine(string.Concat(randNumber," TAK"));
            }
        }
    }
}
