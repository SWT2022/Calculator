// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator
{


    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;

            var calc = new CalculatorClass();

            result = calc.Add(4, 5);

            if (result == 9)
            {
                Console.WriteLine($"Resultatet af add funktionen er som forventet {result}");
            }
            else if (result != 9)
            {
                Console.WriteLine($"Add funktionen gav det forkerte resultat {result}");
            }



            result = calc.Multiply(5, 5);

            if (result == 25)
            {
                Console.WriteLine($"Resultatet af Multiply funktionen er som forventet {result}");
            }
            else if (result != 25)
            {
                Console.WriteLine($"Multiply funktionen gav det forkerte resultat {result}");
            }



            result = calc.Subtract(20, 5);
            if (result == 15)
            {
                Console.WriteLine($"Resultatet af Substract funktionen er som forventet {result}");
            }
            else if (result != 15)
            {
                Console.WriteLine($"Subtract funktionen gav det forkerte resultat {result}");
            }
           

            result = calc.Power(3,2);

            if (result == 9)
            {
                Console.WriteLine($"Resultatet af Power funktionen er som forventet {result}");
            }
            else if (result != 9)
            {
                Console.WriteLine($"Power funktionen gav det forkerte resultat {result}");
            }

            



        }
    }
}

