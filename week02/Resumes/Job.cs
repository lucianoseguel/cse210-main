using System;

public class Job{
   public string _jobTitle;
   public string _jobEnterprise;
   public int _startYear;
   public int _endYear; 

   public void DisplayJob(){
    Console.WriteLine($"{_jobTitle} ({_jobEnterprise}) {_startYear} - {_endYear}");
   }
}


