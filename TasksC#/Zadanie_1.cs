using System;

namespace Etap1
{
    public class Zadanie_1
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int firstNumber, secondNumber;

                Console.Write("Podaj liczbê ca³kowit¹ A: ");
                while (!int.TryParse(Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Proszê podaæ poprawn¹ liczbê ca³kowit¹ A: ");
                    continue;
                }

                Console.Write("Podaj liczbê ca³kowit¹ B: ");
                while (!int.TryParse(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Proszê podaæ poprawn¹ liczbê ca³kowit¹ B: ");
                    continue;
                }

                int result = CountAmountOfDifferentBits(firstNumber, secondNumber);
                Console.WriteLine("Liczba bitów, które nale¿y odwróciæ, aby przekszta³ciæ liczbê A na liczbê B wynosi: " + result);
                Console.ReadLine();
            }
        }

        //Metoda licz¹ca iloœæ bitów ró¿ni¹cych siê w dwóch liczbach ca³kowitych
        public static int CountAmountOfDifferentBits(int fNumber, int sNumber)
        {
            int counter = 0;

            //zak³adamy, ¿e liczby s¹ mniejsze od 2^31 
            for (int k = 0; k < 32; k++)
            {
                if (((fNumber >> k) & 1) != ((sNumber >> k) & 1))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
