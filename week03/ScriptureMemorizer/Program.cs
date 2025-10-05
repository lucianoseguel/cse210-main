
using System;
using System.IO;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello! This is the scripture memorizer. (Write quit to quit)");


        // SET VERSES 
        Verse verse_1 = new Verse();
        verse_1.Setverse("1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        Verse verse_2 = new Verse();
        verse_2.Setverse("2 Nephi 2:25", "Adam fell that men might be; and men are, that they might have joy.");

        Verse verse_3 = new Verse();
        verse_3.Setverse("2 Nephi 28:30", "For behold, thus saith the Lord God: I will give unto the children of men line upon line, precept upon precept, here a little and there a little; and blessed are those who hearken unto my precepts, and lend an ear unto my counsel, for they shall learn wisdom; for unto him that receiveth I will give more.");

        //* This are random options for choicing verse 
        

        Random rnd = new Random();
        int n_number = rnd.Next(3);
        if (n_number == 0)
        {

            Console.WriteLine(verse_1.Getverse());
            Console.WriteLine("");
            Console.Write("");
            string x = Console.ReadLine();
            if (x == "quit")
            {
                return;
            }

            Console.Clear();
            Console.WriteLine(" This is the scripture memorizer. (Write quit to quit)");

            string newverse = Hidde_verse(verse_1.Getonlyverse(), Globalvariables.attempt);
            Console.WriteLine(verse_1.Getbook() + ": " + newverse);
            Console.Write("");
            string choice = Console.ReadLine();
            if (choice == "quit")
            {
                return;
            }

            Console.Clear();
            Console.WriteLine(" This is the scripture memorizer. (Write quit to quit)");
            newverse = Hidde_verse(verse_1.Getonlyverse(), Globalvariables.attempt);
            Console.WriteLine(verse_1.Getbook() + ": " + newverse);

            Console.Write("");
            choice = Console.ReadLine();
            if (choice == "quit")
            {
                return;
            }
            
            Console.Clear();
            Console.WriteLine(" This is the scripture memorizer. (Write quit to quit)");
            newverse = Hidde_verse(verse_1.Getonlyverse(), Globalvariables.attempt);
            Console.WriteLine(verse_1.Getbook() + ": " + newverse);
            
            Console.Write("");
            choice = Console.ReadLine();
            if (choice == "quit")
            {
                return;
            }
        

        }
        else if (n_number == 1)
        {
             Console.WriteLine(verse_2.Getverse());
            Console.WriteLine("");
            Console.Write("");
            string x = Console.ReadLine();
            if (x == "quit")
            {
                return;
            }

            Console.Clear();
            Console.WriteLine(" This is the scripture memorizer. (Write quit to quit)");

            string newverse = Hidde_verse(verse_2.Getonlyverse(), Globalvariables.attempt);
            Console.WriteLine(verse_2.Getbook() + ": " + newverse);
            Console.Write("");
            string choice = Console.ReadLine();
            if (choice == "quit")
            {
                return;
            }

            Console.Clear();
            Console.WriteLine(" This is the scripture memorizer. (Write quit to quit)");

            newverse = Hidde_verse(verse_2.Getonlyverse(), Globalvariables.attempt);
            Console.WriteLine(verse_2.Getbook() + ": " + newverse);

            Console.Write("");
            choice = Console.ReadLine();
            if (choice == "quit")
            {
                return;
            }
            
            Console.Clear();
            Console.WriteLine(" This is the scripture memorizer. (Write quit to quit)");

            newverse = Hidde_verse(verse_2.Getonlyverse(), Globalvariables.attempt);
            Console.WriteLine(verse_2.Getbook() + ": " + newverse);
            
            Console.Write("");
            choice = Console.ReadLine();
            if (choice == "quit")
            {
                return;
            }
        




        }
        else if (n_number == 2)
        {
              Console.WriteLine(verse_3.Getverse());
            Console.WriteLine("");
            Console.Write("");
            string x = Console.ReadLine();
            if (x == "quit")
            {
                return;
            }
            Console.Clear();
            Console.WriteLine(" This is the scripture memorizer. (Write quit to quit)");

            string newverse = Hidde_verse(verse_3.Getonlyverse(), Globalvariables.attempt);
            Console.WriteLine(verse_3.Getbook() + ": " + newverse);
            Console.Write("");
            string choice = Console.ReadLine();
            if (choice == "quit")
            {
                return;
            }

            Console.Clear();
            Console.WriteLine(" This is the scripture memorizer. (Write quit to quit)");

            newverse = Hidde_verse(verse_3.Getonlyverse(), Globalvariables.attempt);
            Console.WriteLine(verse_3.Getbook() + ": " + newverse);

            Console.Write("");
            choice = Console.ReadLine();
            if (choice == "quit")
            {
                return;
            }
            
            Console.Clear();
            Console.WriteLine(" This is the scripture memorizer. (Write quit to quit)");

            newverse = Hidde_verse(verse_3.Getonlyverse(), Globalvariables.attempt);
            Console.WriteLine(verse_3.Getbook() + ": " + newverse);
            
            Console.Write("");
            choice = Console.ReadLine();
            if (choice == "quit")
            {
                return;
            }
        
        }




    }



    public static string Hidde_verse(string text, int trys )
    {



        string[] words = text.Split(' '); //Convert the phrase in array of words



        //Randomize the hidden words


        if (trys == 0) //Hide first words

        {
            for (int i = 0; i < words.Length / 7; i++)
            {
                Random rnd = new Random();
                int r_words = rnd.Next(words.Length);

                string hidetoword = words[r_words];
                string hiddenword = new string('_', hidetoword.Length);

                words[r_words] = hiddenword;


            }
            string newtext = string.Join(" ", words);
            Globalvariables.attempt++;
            return newtext;

        }

        else if (trys == 1) //Hide second words
        {
            for (int i = 0; i < words.Length / 4; i++)
            {
                Random rnd = new Random();
                int r_words = rnd.Next(words.Length);

                string hidetoword = words[r_words];
                string hiddenword = new string('_', hidetoword.Length);

                words[r_words] = hiddenword;


            }
            string newtext = string.Join(" ", words);
            Globalvariables.attempt++;
            return newtext;
        }


        else 
        {
            for (int i = 0; i < words.Length ; i++)
            {
                Random rnd = new Random();
                int r_words = rnd.Next(words.Length);

                string hidetoword = words[r_words];
                string hiddenword = new string('_', hidetoword.Length);

                words[r_words] = hiddenword;


            }
            string newtext = string.Join(" ", words);
            Globalvariables.attempt++;
            return newtext;
        }

        

        


    }


  
    public static class Globalvariables
    {
        public static int attempt = 0;
    }
}
