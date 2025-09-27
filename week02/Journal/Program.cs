using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        List<string> journalEntries = new List<string>();
        List<string> LoadedEntries = new List<string>();

        while (true)
        {

            string name = "Luciano Seguel";
            //string fileName = "journal.csv";
            Console.WriteLine("");
            Console.WriteLine($"Hello {name}! Welcome to your journal.");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            Console.WriteLine($"You selected option {choice}");


            if (choice == "1") //Write a new entry
            {

                Writefile(journalEntries);



            }
            else if (choice == "2") //Display the journal
            {

                Display(journalEntries);
            }
            else if (choice == "3") //Load the journal from a file
            {
                Load(LoadedEntries);
                Display(journalEntries);
                Display(LoadedEntries);

            }
            else if (choice == "4") //Save the journal to a file
            {
                Console.Write("Please input the filename: ");
                string filename = Console.ReadLine();
                Savefile(journalEntries,LoadedEntries,filename);
            }



            else if (choice == "5")
            {
                break;
            }


        }








    }

    public static void Writefile(List<string> journalEntries)

    {   Random rnd = new Random();
        int question = rnd.Next(6);
        if (question == 0)
        { Console.WriteLine("Who was the most interesting person I interacted with today?"); }
        else if (question == 1)
        {
            Console.WriteLine("What was the best part of my day?");
        }
        else if (question == 2)
        {
            Console.WriteLine("How did I see the hand of the Lord in my life today?");
        }

        else if (question == 3)
        {
            Console.WriteLine("What was the strongest emotion I felt today?");
        }

        else if (question == 4)
        {
            Console.WriteLine("If I had one thing I could do over today, what would it be?");
        }

        else if (question == 5)
        {
            Console.WriteLine("Who was the most interesting person I interacted with today?");
        }



        Console.Write("Wirte your answer: ");
        string entry = Console.ReadLine();
        string to_write = $"[{DateTime.Now}] : {entry}";
        journalEntries.Add(to_write);
        
        Console.WriteLine("Note saved: " + to_write);
    }

    public static void Display(List<string> journalEntries)
    {
        foreach (string line in journalEntries)
        {
            Console.WriteLine(line);
        }

    }

    public static List<string> Load(List<string> Loadentrities)
    {
        Console.Write("What is the name of the file?");
        string  filename = Console.ReadLine();
        //string filename = "journal.csv";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            Loadentrities.Add(parts[0]);
           
        }

        


        
        return Loadentrities;
    }

    public static void Savefile(List<string> journalEntries, List<string> LoadedEntries, string filename)
    {
        
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            if (LoadedEntries == null)
            {
                foreach (string line in journalEntries)
                {
                    outputFile.WriteLine(line);
                }
            }
            else
            {
                foreach (string line in LoadedEntries)
                {
                    outputFile.WriteLine(line);
                }
                foreach (string line in journalEntries)
                {
                    outputFile.WriteLine(line);
                }
            }

            
            
        }
        
    }


        
}


