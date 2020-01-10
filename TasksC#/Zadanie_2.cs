using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Etap1
{
    public static class Zadanie_2
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string stringToBeCompressed, result;

                Console.Write("Podaj �a�cuch znak�w, kt�ry b�dzie skompresowany (mo�e zawiera� tylko litery z alfabetu angielskiego): ");
                stringToBeCompressed = Console.ReadLine();
                if (!string.IsNullOrEmpty(stringToBeCompressed) && Regex.IsMatch(stringToBeCompressed, @"^[a-zA-Z]+$"))
                {
                    result = CompressString(stringToBeCompressed);
                    Console.WriteLine("Wynik: " + result);
                }
                else
                {
                    Console.WriteLine("Prosz� poda� poprawny �a�cuch znak�w");
                    continue;
                }
            }
        }

        public static string CompressString(string entryString)
        {
            var stringBuffer = new StringBuilder();
            string tempString = entryString;

            //zastosowanie kolejki
            var queue = new Queue<char>(entryString);
            uint counter = 0;

            while (queue.Count > 0)
            {
                char character = queue.Dequeue();
                counter++;

                if (queue.Count == 0 || character != queue.Peek())
                {
                    stringBuffer.Append(character);
                    stringBuffer.Append(counter);
                    counter = 0;
                }
            }
            //zwr�cenie odpowiedniego �a�cucha znak�w w zale�no�ci od d�ugo�ci
            return stringBuffer.Length == tempString.Length ? tempString : stringBuffer.ToString();
        }
    }
}