using System;

class Program
{
    static void Main(string[] args)
    {
        
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 10);
            Console.WriteLine(number);

            Console.Write("What is the magic number? ");
            string inputnumber = Console.ReadLine();
            int stringnumber = int.Parse(inputnumber);

            int magicnumber = number;

            while (stringnumber != magicnumber){
                if (stringnumber > magicnumber){
                    Console.WriteLine("Higher");
                    Console.Write("What is the magic number? ");
                     inputnumber = Console.ReadLine();
                    stringnumber = int.Parse(inputnumber);
                } else if (stringnumber < magicnumber){
                    Console.WriteLine("Lower");
                    Console.Write("What is the magic number? ");
                     inputnumber = Console.ReadLine();
                    stringnumber = int.Parse(inputnumber);
                }
                else if (stringnumber == magicnumber){

                    Console.WriteLine("You discovered the magic number");
                    break;
                }
                
            
            
    }
}}
