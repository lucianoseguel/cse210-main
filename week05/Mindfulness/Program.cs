using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)

    {
        Console.Clear();
        Console.WriteLine("Hello Welcome to our FITCENTER Seguel's");
        Console.WriteLine("Witch Activity are you doing?");
        Console.WriteLine("1. Bereathing Activity \n2. Reflection Activity \n3. Listing Activity  ");
        Console.Write("Please insert a number: ");
        string option = Console.ReadLine();

        if (option == "1") //Breath Activity
        {

            Console.Write("How many seconds you will to do the activity? (no less 10 seconds) ");
            int duration = int.Parse(Console.ReadLine());

            while (duration < 10)
            {
                Console.Write("How many seconds you will to do the activity? (no less 10 seconds) ");
                duration = int.Parse(Console.ReadLine());
            }



            BereathingActivity bereathing = new BereathingActivity("Breathing Activity", duration, "", "");
            bereathing.SetMessages();
            bereathing.StartBreath();
            //End Activity 1


        }
        else if (option == "2") //Reflection Activity
        {
            Console.Write("How many seconds will you use to think carefully about the situations and questions? (no less 10 seconds) ");
            int duration = int.Parse(Console.ReadLine());

            while (duration < 10)
            {
                Console.Write("How many seconds you will to do the activity? (no less 10 seconds) ");
                duration = int.Parse(Console.ReadLine());
            }

            ReflecionActivity reflecion = new ReflecionActivity("Reflection Activity", duration);
            reflecion.SetMessages();
            reflecion.DisplaySituation(duration);



        }
        else if (option == "3") //Listing Activity
        {
            Console.Write("How many seconds will you use to think carefully about the situations and questions? (no less 3 seconds) ");
            int duration = int.Parse(Console.ReadLine());


            while (duration < 3)
            {
                Console.Write("How many seconds you will to do the activity? (no less 10 seconds) ");
                duration = int.Parse(Console.ReadLine());
            }
            
            ListingActivity listing = new ListingActivity("Listing Activity", duration);
            listing.SetMessages();
            listing.DisplayQuestions(duration);


        }

    }


    public class Activity
    {
        public string _name;
        public int _duration;

        public Activity()
        {
            _name = "Unknown activity";
            _duration = 0;
        }

        public Activity(string name, int duration)
        {
            _name = name;
            _duration = duration;
        }



        public void SetActivity()
        {
            _name = "Unknown activity";
            _duration = 0;
        }

        public void SetActivity(string name, int duration)
        {
            _name = name;
            _duration = duration;
        }


    }

    public class BereathingActivity : Activity
    {
        private string _startMessage;
        private string _endMessage;


        public BereathingActivity(string name, int duration, string startMessage, string endMessage) : base(name, duration)
        {
            _duration = duration;
            _name = name;
            _startMessage = startMessage;
            _endMessage = endMessage;
        }

        public void SetMessages(string startMessage, string endMessage)
        {
            _startMessage = startMessage;
            _endMessage = endMessage;

        }

        public void SetMessages()
        {
            _startMessage = "\nThis activity will help you relax while sitting as you inhale and exhale slowly. Clear your mind and focus on your breathing.";
            _endMessage = $"\nToday you did a great job after the {_duration} seconds. Let's meet for the next session and increase the activity time. have a nice day!";

        }

        public void StartBreath()
        {
            Console.WriteLine(_startMessage);


            Console.Write("You start a Breath in..4");

            Thread.Sleep(1000);

            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);

            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);

            Console.Write("\b \b");
            Console.Write("1");




            int counter = _duration;

            while (counter > 0)
            {


                Console.Write("\nBreath...5");

                Thread.Sleep(1000);

                Console.Write("\b \b");
                Console.Write("4");
                Thread.Sleep(1000);

                Console.Write("\b \b");
                Console.Write("3");
                Thread.Sleep(1000);

                Console.Write("\b \b");
                Console.Write("2");
                Thread.Sleep(1000);

                Console.Write("\b \b");
                Console.Write("1");
                Thread.Sleep(1000);

                Console.Write("\b \b");
                Console.Write("0");
                Thread.Sleep(1000);


                ///Now exhale

                Console.Write("\nExhale...5");

                Thread.Sleep(1000);

                Console.Write("\b \b");
                Console.Write("4");
                Thread.Sleep(1000);

                Console.Write("\b \b");
                Console.Write("3");
                Thread.Sleep(1000);

                Console.Write("\b \b");
                Console.Write("2");
                Thread.Sleep(1000);

                Console.Write("\b \b");
                Console.Write("1");
                Thread.Sleep(1000);

                Console.Write("\b \b");
                Console.Write("0");
                Thread.Sleep(1000);

                counter -= 10;



            }
            Console.WriteLine(_endMessage);
        }


    }

    public class ReflecionActivity : Activity
    {
        private string _startMessage;
        private string _endMessage;


        public ReflecionActivity(string name, int duration) : base(name, duration)
        {
            _duration = duration;
            _name = name;
        }

        public void SetMessages()
        {
            _startMessage = "Welcome to Reflection Activity. We will start by reflecting on some situations and asking ourselves some questions.";
            _endMessage = $"Excellent work! By reflecting on specific situations in our lives and asking ourselves questions, we can discover more about ourselves and find solutions to our problems. You have analyzed each situation for {_duration * 4} seconds.";
        }



        private string[] _situations = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];

        private string[] _questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
            ];


        public string SetRandomSituation()
        {
            Random rnd = new Random();
            int number = rnd.Next(_situations.Length);
            string situation = _situations[number];
            return situation;

        }

        public string SetRandomQuestion()
        {
            Random rnd = new Random();
            int number = rnd.Next(_questions.Length);
            string question = _questions[number];
            return question;
        }


        public void DisplaySituation(int duration)
        {
            Console.WriteLine(_startMessage);
            Console.WriteLine(SetRandomSituation());
            Loading(duration);
            Console.WriteLine(SetRandomQuestion());
            Loading(duration);
            Console.WriteLine(SetRandomSituation());
            Loading(duration);
            Console.WriteLine(SetRandomQuestion());
            Loading(duration);

            Console.WriteLine(_endMessage);

        }



        public void Loading(int times)
        {

            while (times > 0)
            {
                Console.Write("\b\b\b");
                Console.Write("(-)");

                Thread.Sleep(250);

                Console.Write("\b\b");
                Console.Write("|)");
                Thread.Sleep(250);

                Console.Write("\b\b");
                Console.Write("/)");
                Thread.Sleep(250);

                Console.Write("\b\b");
                Console.Write("-)");
                Thread.Sleep(250);

                times--;
            }
            Console.WriteLine("\n");
        }





    }

    public class ListingActivity : Activity
    {
        private string _startMessage;
        private string _endMessage;

        List<string> _mylist = new List<string>();


        public string[] _questions = ["Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"];


        public ListingActivity(string name, int duration) : base(name, duration)
        {
            _duration = duration;
            _name = name;
        }

        public void SetMessages()
        {
            _startMessage = "I want you to focus, reflect on the following question and then begin listing all the things you have done or that you have in your life.";
            _endMessage = $"Excellent work! It has been easy! Below is the list of what you wrote.";

        }

        public string GetRandomQuestion()
        {
            Random rnd = new Random();
            int number = rnd.Next(_questions.Length);
            string question = _questions[number];
            return question;

        }

        public void DisplayQuestions(int duration)
        {
            Console.WriteLine(_startMessage);
            Console.WriteLine(GetRandomQuestion());
            Console.WriteLine("Please write your answers\n");
            DateTime starttime = DateTime.Now;
            DateTime futuretime = starttime.AddSeconds(duration);
            while (DateTime.Now < futuretime)
            {
                Console.Write("");
                string answer = Console.ReadLine();
                _mylist.Add(answer);
            }
            Console.WriteLine(_endMessage);
            GetList();


        }

        public void GetList()
        {
            foreach (string item in _mylist)
            {
                Console.WriteLine(item + "\n");
            }
        }

    }
}