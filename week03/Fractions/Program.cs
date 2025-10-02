using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Console.Write("Please set your numerator: ");
        string text_numerator = Console.ReadLine();
        int numerator = int.Parse(text_numerator);



        Console.Write("Please set your denominator: ");
        string text_denominator = Console.ReadLine();
        int denominator = int.Parse(text_denominator);

        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFraction());
        Console.WriteLine(fraction.GetDecimal(numerator, denominator));
        Console.WriteLine(fraction.GetWhole(numerator));
     
        

       

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

        public string GetFraction()
        {
            return $"{_numerator}/{_denominator}";

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

