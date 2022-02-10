using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorClass
    {
        public CalculatorClass()
        {

        }

        public double Accumulator { get; set; } = 0;

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {

            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentOutOfRangeException("Der kan ikke devideres med 0");
            }
            Accumulator = dividend / divisor;

            // der kan ikke devideres med nul

            return Accumulator;
        }

        public double Add(double addend)
        {
            Accumulator = addend + Accumulator;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator = Accumulator - subtractor;
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            Accumulator = multiplier * Accumulator;
            return Accumulator;
        }

        public double Divide(double divisor)
        {

            if (divisor == 0)
            {
                throw new ArgumentOutOfRangeException("Der kan ikke devideres med 0");
            }

            Accumulator = Accumulator / divisor;
            return Accumulator;
        }

        public double Power(double exponent)
        {
            Accumulator =  Math.Pow(Accumulator, exponent);
            return Accumulator;
        }



    }
}
