using System;
using System.Text.RegularExpressions;

namespace ValidateNames
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name;
            bool isValid;
            do
            {
                Console.Write("Porfavor ingresa un Nombre: ");
                name = Console.ReadLine();
                if (IsValidName(name))
                {
                    Console.WriteLine("Nombre Válido");
                    isValid = false;
                }
                else
                {
                    Console.WriteLine("Nombre Inválido");
                    isValid = true;
                }
            } while (isValid);
        }

        public static bool IsValidName(string name)
        {
            // We divide the name into three terms separated by spaces
            string[] terms = name.Split(' ');

            // If there are not two or three terms, the name is invalid
            if (terms.Length != 2 && terms.Length != 3) return false;

            // We check if the first term is an initial
            bool isFirstTermInitial = Regex.IsMatch(terms[0], @"^[A-Z]\.$");

            // If the first term is not an initial, it must be a complete word
            if (!isFirstTermInitial && !Regex.IsMatch(terms[0], @"^[A-Z][a-z]+$")) return false;

            if (terms.Length == 2)
            {
                // If the first term is an initial, the second is not an initial
                if (isFirstTermInitial && !Regex.IsMatch(terms[1], @"^[A-Z]\.$|^[A-Z][a-z]+$")) return false;

                // If the first term is not an initial, the second must be a whole word
                if (!isFirstTermInitial && !Regex.IsMatch(terms[1], @"^[A-Z][a-z]+$")) return false;
            }

            if (terms.Length == 3)
            {
                // If the first is an initial, the second must be an initial
                if (isFirstTermInitial && !Regex.IsMatch(terms[1], @"^[A-Z]\.$")) return false;

                // The third term must be a complete word
                if (!Regex.IsMatch(terms[2], @"^[A-Z][a-z]+$")) return false;
            }

            // Success
            return true;
        }
    }
}
