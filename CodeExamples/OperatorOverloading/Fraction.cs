using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// This structure overloads some of the arithmetic operators :

namespace OperatorOverloading
{
    public  struct Fraction
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction(int num, int den)
        {
            if (den == 0)
                throw new ArgumentException("Denominator can't be Zero ." ,nameof(den));
            numerator = num;
            denominator = den;
        }

        // using lambda expression here 

        public static Fraction operator +(Fraction a) => a;   //Use the operator keyword to declare an operator
        public static Fraction operator -(Fraction a) => new Fraction(-a.numerator,a.denominator);

        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);

        public static Fraction operator -(Fraction a, Fraction b) => a + (-b);

        public static Fraction operator *(Fraction a, Fraction b) 
            => new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);


        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.numerator == 0)
            {
                throw new DivideByZeroException();
            }

            return new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
        }

        public override string ToString() => $"{numerator} / {denominator}";

    }
}
