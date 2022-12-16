using System;
using System.Text.RegularExpressions;

namespace SimplifyFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numerator = 0;
                int denominator = 0;
                string inputNumerator;
                string inputDenominator;
                string pattern = "^[0-9]*$"; // only number
                bool isNumber = false;

                Regex regex = new Regex(pattern);

                do
                {
                    Console.Write("Por favor ingresa un Numerador: ");
                    inputNumerator = Console.ReadLine();

                    Console.Write("Por favor ingresa un Denominador: ");
                    inputDenominator = Console.ReadLine();

                    if (regex.IsMatch(inputNumerator) && regex.IsMatch(inputDenominator))
                    {
                        numerator = Int32.Parse(inputNumerator);
                        denominator = Int32.Parse(inputDenominator);

                        Fraction fraction = new Fraction(numerator, denominator);

                        fraction.Simplify();

                        Console.Write($"Fracción simplificada {fraction}");

                        isNumber = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Por favor ingresa un número entero");
                        isNumber = true;
                    }

                } while (isNumber);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}
