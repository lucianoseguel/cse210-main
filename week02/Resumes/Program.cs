using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        //Fist JOB
        Job job1 = new Job();
        job1._jobTitle = "Sofware engineer";
        job1._jobEnterprise = "Microsoft";
        job1._startYear = 2025;
        job1._endYear = 2028;
        

        //Second Job
        Job job2 = new Job();
        job2._jobTitle = "Sofware engineer";
        job2._jobEnterprise = "Apple";
        job2._startYear = 2025;
        job2._endYear = 2030;

        

        Resume resume = new Resume();
        resume._Name = "Luciano Seguel";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        
        Console.WriteLine($"{resume._Name} ");


        for (int i = 0; i < resume._jobs.Count; i++   ){

            resume._jobs[i].DisplayJob();
        }

    }




}

