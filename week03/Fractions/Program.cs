using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Console.Write("Please set your numerator: ");
        
       

    }

    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        public string GetFraction(int numerator, int denominator)
        {
            return $"{numerator}/{denominator}";

        }

        public float GetDecimal(int numerdator, int denominator)
        {
            return (float)(numerdator / denominator);
        }

        public int GetWhole(int numerator)
        {
            int denominator = 1;
            int whole = numerator / denominator;
            return whole;


        }

    }

    
}

