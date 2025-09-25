using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the cinema, for today acording to your age, will reciebe a discount");
        Console.Write("What is your age: ");
        string ageinput = Console.ReadLine();
        int age = int.Parse(ageinput);
        float price = 20.6f;
        //calculate age and percent: 
        Console.WriteLine("The normal ticket cost is $20");
        if (age <= 12){
            float discount = 0.7f;
            float result = price-(price * discount);
            
            Console.WriteLine($"But do you have a {discount*100}% of discount for have {age}, and you will pay ${result:F2}, have a nice day");

        }
        else if(age <= 18){
            float discount = 0.5f;
            float result = price-(price * discount);
            
            Console.WriteLine($"But do you have a {discount*100}% of discount for have {age}, and you will pay ${result:F2}, have a nice day");

        }

        else if(age <= 35){
            float discount = 0.4f;
            float result = price-(price * discount);
            
            Console.WriteLine($"But do you have a {discount*100}% of discount for have {age}, and you will pay ${result:F2}, have a nice day");

        }

        else if(age <= 55){
            float discount = 0.35f;
            float result = price-(price * discount);
            
            Console.WriteLine($"But do you have a {discount*100}% of discount for have {age}, and you will pay ${result:F2}, have a nice day");

        }

        else if(age <= 65){
            float discount = 1f;
            float result = price-(price * discount);
            
            Console.WriteLine($"But do you have a {discount*100}% of discount for have {age}, and you will pay ${result:F2}, have a nice day");

        }
        
    }
}