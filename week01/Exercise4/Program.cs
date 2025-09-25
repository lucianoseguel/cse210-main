using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
            //Creating a list
        List<int> numbers;
            //Using a list
        numbers = new List<int>();
        
        
        Console.Write("Write a number (0 to stop): "); //Starter
        string inputnumber = Console.ReadLine();
        int stringnumber = int.Parse(inputnumber);
        
        while (stringnumber != 0){ //Ask for a number
            numbers.Add(stringnumber);
            Console.Write("Write a number ");
            inputnumber = Console.ReadLine();
            stringnumber = int.Parse(inputnumber);
            
            
        }

        int sum = numbers.Sum(); //sum numbers
        numbers.Sort(); //Function sort
        double average = numbers.Average(); //Give the average
        
//Sort numbers 
        foreach (int num in numbers)
        {
            Console.Write(num + ", ");
        }
        
        Console.WriteLine($" ");
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"And the average is {average}");



    }
}

