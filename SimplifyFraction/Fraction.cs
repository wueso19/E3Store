using System;

namespace SimplifyFraction
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public int Numerator { get => numerator; set => numerator = value; }
        public int Denominator { get => denominator; set => denominator = value; }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public override string ToString()
        {
            string result;


            if (this.denominator != 0)
            {
                result = this.denominator == 1 ? this.numerator.ToString() : this.numerator + "/" + this.denominator;

            }
            else
            {
                result = "¡No se permite la división por 0!";
            }

            return result;
        }

        public Fraction Simplify()
        {
            int mcd = FindGCD(this.numerator, this.denominator);
            if (mcd != this.numerator)
            {
                this.numerator /= mcd;
                this.denominator /= mcd;
            }

            return this;
        }

        private static int FindGCD(int a, int b)
        {
            if (b == 0)
            {
                return Math.Abs(a);
            }

            return FindGCD(b, a % b);
        }
    }
}
