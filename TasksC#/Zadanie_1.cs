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

                Console.Write("Podaj liczb� ca�kowit� A: ");
                while (!int.TryParse(Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Prosz� poda� poprawn� liczb� ca�kowit� A: ");
                    continue;
                }

                Console.Write("Podaj liczb� ca�kowit� B: ");
                while (!int.TryParse(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Prosz� poda� poprawn� liczb� ca�kowit� B: ");
                    continue;
                }

                int result = CountAmountOfDifferentBits(firstNumber, secondNumber);
                Console.WriteLine("Liczba bit�w, kt�re nale�y odwr�ci�, aby przekszta�ci� liczb� A na liczb� B wynosi: " + result);
                Console.ReadLine();
            }
        }

        //Metoda licz�ca ilo�� bit�w r�ni�cych si� w dw�ch liczbach ca�kowitych
        public static int CountAmountOfDifferentBits(int fNumber, int sNumber)
        {
            int counter = 0;

            //zak�adamy, �e liczby s� mniejsze od 2^31 
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
