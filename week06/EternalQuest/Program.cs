using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int globalPoints;
        globalPoints = 0;
        List<Goal> goalList = new List<Goal>();
        
        while (true) //We set the bucle while to repeat cycle
        {
            Console.Clear();
            Console.WriteLine("Hello! This is the EternalQuest.");
            Console.WriteLine($"You have {globalPoints} points at the moment");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Create a new goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Events \n6. Quit");
            Console.Write("Please insert an option: ");
            string option = Console.ReadLine();
            if (option == "1")
            {
                CreateNewGoal(goalList);
            }
            else if (option == "2")
            {
                ListGoals(goalList);

            }
            else if (option == "3")
            {
                SaveGoals(goalList, globalPoints);
            }
            else if (option == "4")
            {
                LoadGoals(goalList, globalPoints);
            }
            else if (option == "5")
            {
                RecordEvents(goalList);
            }
            else if (option == "6")
            {
                break;
            }




        }




    }
    // Creating main functions
    public static void CreateNewGoal(List<Goal> goalList)
    {
        Console.Write("What type of Goal do you want to create? \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal \n");
        string option = Console.ReadLine();

        if (option == "1") //Chose Simple Goal     
        {
            SimpleGoal goal = new SimpleGoal("", "", 0, false);
            goal.SetSimpleGoal();
            Console.WriteLine($"You created the next goal: {goal._shortname} \n Now go ahead, you got this!");
            goal.GetGoal();
            goalList.Add(goal);


        }
        else if (option == "2") //Chose Eternal Goal
        {
            EternalGoal goal = new EternalGoal("", "", 0);
            goal.SetEternalGoal();
            goal.GetGoal();
            goalList.Add(goal);


        }
        else
        {
            ChecklistGoal goal = new ChecklistGoal("", "", 0, 0, 0, 0, false);
            goal.SetCheckListGoal();
            goal.GetGoal();
            goalList.Add(goal);
        }


    }

    public static void ListGoals(List<Goal> goalList)
    {

        for (int i = 0; i < goalList.Count; i++)
        {
            if (goalList[i] is SimpleGoal)
            {

                SimpleGoal goal = (SimpleGoal)goalList[i];
                Console.WriteLine($"{i}. " +   goal.GetGoal());
              

            }
            else if (goalList[i] is EternalGoal)
            {
                EternalGoal goal = (EternalGoal)goalList[i];
                Console.WriteLine($"{i}. " + goal.GetGoal());
                goal.GetGoal();
            }
            else
            {
                ChecklistGoal goal = (ChecklistGoal)goalList[i];
                Console.WriteLine($"{i}. " + goal.GetGoal());
           
            }
        }

        Console.Write("");
        Console.ReadLine();
        

    }


    public static void SaveGoals(List<Goal> goalList, int points)
    {
        Console.Write("Please write the name document to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            outputfile.WriteLine(points);
            foreach (Goal goal in goalList)
            {
                if (goal is SimpleGoal)
                {
                    SimpleGoal simpleGoal = (SimpleGoal)goal;
                    outputfile.WriteLine($"SimpleGoal,{simpleGoal._shortname},{simpleGoal._description},{simpleGoal._points},{simpleGoal._completed}");
                }
                else if (goal is EternalGoal)
                {
                    EternalGoal eternalGoal = (EternalGoal)goal;
                    outputfile.WriteLine($"EternalGoal,{eternalGoal._shortname},{eternalGoal._description},{eternalGoal._points},{eternalGoal._isComplited}");
                }
                else
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    outputfile.WriteLine($"ChecklistGoal,{checklistGoal._shortname},{checklistGoal._description},{checklistGoal._points},{checklistGoal._amount_completed},{checklistGoal._completed},{checklistGoal.bonus_points},{checklistGoal._isComplited}");
                }
            }

        }
        Console.WriteLine($"Saved successfully in {filename}");
        Thread.Sleep(2000);
    }

    public static void LoadGoals(List<Goal> goalList, int points)
    {
        Console.Write("Please write the name document to load: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                goalList.Add(goal);


            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                goalList.Add(goal);

            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[7]));
                goalList.Add(goal);
            }else if(int.Parse(parts[0]) >= 0)
            {   
                
                points +=  int.Parse(parts[0]);
            }
        }
    }


    public static void RecordEvents(List<Goal> goalList)
    {

        ListGoals(goalList);
        Console.WriteLine("Select goal to record event: (00 to return)");
        Console.Write("");
        int option = int.Parse(Console.ReadLine());
        for (int i = 0; i < goalList.Count; i++)
        {
            if (i == option)
            {
                if (goalList[i] is SimpleGoal)
                {
                    SimpleGoal goal = (SimpleGoal)goalList[i];
                    goal.IsCompleted();
                    Console.WriteLine(goal.GetGoal());
                    Console.WriteLine($"Congrats! You completed the {goal._shortname} goal! Go ahead");
                }

                else if (goalList[i] is EternalGoal)
                {
                    EternalGoal goal = (EternalGoal)goalList[i];

                    Console.WriteLine(goal.GetGoal());
                    Console.WriteLine($"Congrats! You completed the {goal._shortname} goal! Go ahead");

                }
                else if (goalList[i] is ChecklistGoal)
                {
                    ChecklistGoal goal = (ChecklistGoal)goalList[i];
                    goal.AddCompleted();
                    if (goal._completed == goal._amount_completed)
                    {
                        goal._isComplited = true;
                        Console.WriteLine(goal.GetGoal());
                        Console.WriteLine($"Congrats! You completed the {goal._shortname} goal! Go ahead");

                    }
                    else
                    {
                        Console.WriteLine(goal.GetGoal());
                        Console.WriteLine($"Congrats! You reached {goal._completed}/{goal._amount_completed} in the {goal._shortname} goal! Go ahead");
                    }

                }
            }
            else if (option == 00)
            {
                return;
            }
        }
        Console.Write("");
        Console.ReadLine();


    }




    // Creation of Clases
    public class Goal
    {
        public string _shortname;
        public string _description;

        public int _points;

        public Goal(string shortname, string description, int points)
        {
            _shortname = shortname;
            _description = description;
            _points = points;
        }

        public Goal()
        {
            _shortname = "Unknown";
            _description = "Unknown";
            _points = 0;
        }


    }


    public class SimpleGoal : Goal
    {

        public bool _completed;


        public SimpleGoal(string shortname, string description, int points, bool completed) : base(shortname, description, points)
        {
            _shortname = shortname;
            _description = description;
            _points = points;
            _completed = completed;

        }

        public void IsCompleted()
        {
            if (_completed == true)
            {
                _completed = false;
            }
            else
            {
                _completed = true;
            }
        }

        public string GetGoal()
        {
            if (_completed == true)
            {
                return $"[X] {_shortname} ({_description})";
            }
            else
            {
                return $"[ ] {_shortname} ({_description})";
            }
        }

        public void SetSimpleGoal()
        {
            Console.Write("What is the goal name? ");
            _shortname = Console.ReadLine();
            Console.Write("What is the goal description? ");
            _description = Console.ReadLine();
            Console.Write("How Many points has this goal? ");
            _points = int.Parse(Console.ReadLine());



        }



    }

    public class EternalGoal : Goal
    {

        public bool _isComplited;


        public EternalGoal(string shortname, string description, int points) : base(shortname, description, points)
        {
            _shortname = shortname;
            _description = description;
            _points = points;
        }

        public void SetEternalGoal()
        {

            Console.Write("What is the goal name? ");
            _shortname = Console.ReadLine();
            Console.Write("What is the goal description? ");
            _description = Console.ReadLine();
            Console.Write("How Many points will add this goal? ");
            _points = int.Parse(Console.ReadLine());



        }

        public string  GetGoal()
        {
            if (_isComplited == true)
            {
                return $"[X] {_shortname} ({_description})";
            }
            else
            {
                return $"[ ] {_shortname} ({_description})";
            }
        }


    }

    public class ChecklistGoal : Goal
    {
        public int _amount_completed;
        public int _completed;
        public int bonus_points;
        public bool _isComplited;





        public ChecklistGoal(string shortname, string description, int points, int amount_completed, int completed, int bonus_points, bool isComplited) : base(shortname, description, points)
        {
            _shortname = shortname;
            _description = description;
            _points = points;


        }
        public void IsCompleted()
        {

        }

        public void SetCheckListGoal()
        {
            Console.Write("What is the goal name? ");
            _shortname = Console.ReadLine();
            Console.Write("What is the goal description?");
            _description = Console.ReadLine();
            Console.Write("How Many points have this goal? ");
            _points = int.Parse(Console.ReadLine());

            Console.Write("How Many extra points have each activity item? ");
            bonus_points = int.Parse(Console.ReadLine());

            Console.Write("How Many time you have to complete this goal? ");
            _amount_completed = int.Parse(Console.ReadLine());


        }

        public string  GetGoal()
        {
            if (_completed == _amount_completed)
            {
                _isComplited = true;
            }

            if (_isComplited == true)
            {
                return $"[X] {_shortname} ({_description}) Currently complete{_completed}/{_amount_completed}";
            }
            else
            {
                return $"[ ] {_shortname} ({_description}) Currently complete{_completed}/{_amount_completed}";
            }

        }

        public void AddCompleted()
        {
            _completed++;
        }

    }

   
}