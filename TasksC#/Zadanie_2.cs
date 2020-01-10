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

                Console.Write("Podaj ³añcuch znaków, który bêdzie skompresowany (mo¿e zawieraæ tylko litery z alfabetu angielskiego): ");
                stringToBeCompressed = Console.ReadLine();
                if (!string.IsNullOrEmpty(stringToBeCompressed) && Regex.IsMatch(stringToBeCompressed, @"^[a-zA-Z]+$"))
                {
                    result = CompressString(stringToBeCompressed);
                    Console.WriteLine("Wynik: " + result);
                }
                else
                {
                    Console.WriteLine("Proszê podaæ poprawny ³añcuch znaków");
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
            //zwrócenie odpowiedniego ³añcucha znaków w zale¿noœci od d³ugoœci
            return stringBuffer.Length == tempString.Length ? tempString : stringBuffer.ToString();
        }
    }
}