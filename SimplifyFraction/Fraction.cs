using System;

namespace SimplifyFraction
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return Denominator == 1 ? Numerator.ToString() : $"{Numerator}/{Denominator}";
        }

        public Fraction Simplify()
        {
            if (Denominator == 0)
            {
                throw new DivideByZeroException("No se puede simplificar una fracción con denominador cero");
            }

            int gcd = FindGCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;

            return this;
        }

        private static int FindGCD(int numerator, int denominator)
        {
            // Euclidean algorithm
            return denominator == 0 ? numerator : FindGCD(denominator, numerator % denominator);
        }
    }
}
