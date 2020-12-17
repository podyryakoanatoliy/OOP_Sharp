using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFraction_1
{
    class Fraction
    {
        int denominator = 0;
        public int Numerator { get; set; }
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value != 0)
                {
                    denominator = value;
                }
            }
        }
        public Fraction()
        {

        }
        public Fraction(int numerator, int denumerator)
        {
            Numerator = numerator;
            Denominator = denumerator;
        }
        public void FillFraction()
        {
            Console.Write("Enter numerator's value: ");
            Numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter denominator's value: ");
            Denominator = Convert.ToInt32(Console.ReadLine());
        }
        public void WriteFraction()
        {
            Console.WriteLine($"{Numerator}/{Denominator}");
        }
        public void AddFraction(Fraction fraction)
        {
            if (Denominator == fraction.Denominator)
            {
                Console.WriteLine($"{Numerator + fraction.Numerator}/{fraction.Denominator}");
            }
            else
            {
                Console.WriteLine($"{(Numerator * fraction.Denominator) + (fraction.Numerator * Denominator)}/{GetLeastCommonMultiple(Denominator, fraction.Denominator)}");
            }
        }
        public void SubtractFraction(Fraction fraction)
        {
            if (Denominator == fraction.Denominator)
            {
                Console.WriteLine($"{Numerator - fraction.Numerator}/{fraction.Denominator}");
            }
            else
            {
                Console.WriteLine($"{(Numerator * fraction.Denominator) - (fraction.Numerator * Denominator)}/{GetLeastCommonMultiple(Denominator, fraction.Denominator)}");
            }
        }
        public void MultiplyFraction(Fraction fraction)
        {
            Console.WriteLine($"{Numerator * fraction.Numerator}/{Denominator * fraction.Denominator}");
        }
        public void DivideFraction(Fraction fraction)
        {
            Console.WriteLine($"{Numerator * fraction.Denominator}/{Denominator * fraction.Numerator}");
        }
        int GetLeastCommonMultiple(int a, int b)
        {
            int gcd(int a, int b)
            {
                if (a == 0) return b;
                while (b != 0)
                {
                    int r = 0;
                    if (a > b)
                    {
                        r = a % b;
                    }
                    else
                    {
                        r = b % a;
                    }
                    a = b;
                    b = r;
                }
                return a;
            }

            return (a * b) / gcd(a, b);
        }

        public static Fraction operator ++(Fraction fraction)
        {
            return new Fraction() { Numerator = fraction.Numerator + fraction.Denominator, Denominator = fraction.Denominator };
        }

        public static Fraction operator --(Fraction fraction)
        {
            return new Fraction() { Numerator = fraction.Numerator - fraction.Denominator, Denominator = fraction.Denominator };
        }
    }
}
