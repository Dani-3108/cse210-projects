using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Spoton";
        job1._jobTitle = "Business Developer Representative";
        job1._startYear = 2022;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "UnitX";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2025;
        job2._endYear = 2050;

        Resume myresume = new Resume();
        myresume._name = "Daniel Osorio";

        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        myresume.Display();
    }
}