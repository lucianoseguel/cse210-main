using System;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();

        string username = PromptUserName();
        int age = PromptUserNumber(); 
        double square = SquareNumber(age);
        DisplayResult(username,age,square);


    
    }
// Display Initial message 
static void DisplayWelcome (){
    Console.WriteLine("Welcome to the Program!");
}
// Ask for username 
static string PromptUserName(){
    Console.Write("Please enter your name: ");
    string name =  Console.ReadLine();

    return name;
}
//Ask to user for a number
static int PromptUserNumber(){
    Console.Write("What is your age? ");
    int age = int.Parse(Console.ReadLine());
    return age;

}

//Ask for a square number
static double SquareNumber( int number){
    Console.Write("Write your square number " );
    int squareNumber = int.Parse(Console.ReadLine()) ;
    double square = Math.Pow( number, squareNumber);

    return square;

}



//display the final result
static void DisplayResult (string name, int age, double square){

    Console.WriteLine($"Nice to meet you {name} you are {age} and your square number is {square}");
    
}

}
