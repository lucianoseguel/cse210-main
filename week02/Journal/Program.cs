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


            if (choice == "1")
            {

                Writefile(journalEntries);



            }
            else if (choice == "2")
            {

                Display(journalEntries);
            }
            else if (choice == "3")
            {
                Load(LoadedEntries);
                Display(journalEntries);
                Display(LoadedEntries);

            }
            else if (choice == "4")
            {
                Savefile(journalEntries,LoadedEntries);
            }



            else if (choice == "5")
            {
                break;
            }


        }








    }

    public static void Writefile(List<string> journalEntries)

    {
        Console.Write("What do you want to write? ");
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
        //Console.Write("What is the name of the file?");
        //string filename = Console.ReadLine();
        string filename = "journal.csv";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            Loadentrities.Add(parts[0]);
           
        }

        


        
        return Loadentrities;
    }

    public static void Savefile(List<string> journalEntries, List<string> LoadedEntries)
    {
        string filename = "journal.csv";
        
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


