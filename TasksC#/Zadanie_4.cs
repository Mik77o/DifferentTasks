using System;
using System.Collections.Generic;

namespace Etap1
{
    public class Zadanie_4
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int amount;
                Console.WriteLine("WprowadŸ iloœæ liczb do wylosowania z zakresu -10, 10: ");

                while (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0)
                {
                    Console.WriteLine("Proszê podaæ poprawn¹ liczbê: ");
                    continue;
                }
                GenereateHistogram(amount);
            }
        }

        public static void GenereateHistogram(int amount)
        {
            Random rand = new Random();

            //wykorzystanie s³ownika w celu grupowania iloœci wyst¹pieñ
            var dict = new Dictionary<int, int>();

            for (int i = -10; i <= 10; i++)
                dict.Add(i, 0);

            for (int k = 0; k < amount; k++)
            {
                int numb = rand.Next(-10, 11);
                dict[numb]++;
                Console.WriteLine(numb);
            }

            foreach (int i in dict.Keys)
            {
                Console.Write("{0,4}:|", i);
                for (int j = 0; j < 30; j++)
                {
                    if (dict[i] > j && j >= 29)
                    {
                        Console.Write("+");
                        break;
                    }
                    else if (dict[i] > j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.Write("|" + Environment.NewLine);
            }
        }
    }
}
