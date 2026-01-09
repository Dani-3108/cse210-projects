using System;

class Program
{
    static void Main(string[] args)
    {
        //User input
        Console.Write("What is your grade percentage? ");
        String userInput=Console.ReadLine();
        int gradePercentage=int.Parse(userInput);

        //Grade Letter code block
        string letterGrade="";
        if (gradePercentage >= 90)
        {
            letterGrade="A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade="B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade="C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade="D";
        }
        else 
        {
            letterGrade="F";
        }
        // + or - code block
        string sign="";
        int remainder= gradePercentage % 10;
        if (gradePercentage>=97)
        {
            sign="";
        }
        else if (gradePercentage<60)
        {
            sign="";
        }
        else if (remainder>=7)
        {
            sign="+";
        }
        else if (remainder<3)
        {
            sign="-";
        }
        //Print section
        Console.WriteLine($"Your grade is {letterGrade}{sign}.");
        //Passed course or not section
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course");
        }
        else if (gradePercentage < 70)
        {
            Console.WriteLine("Sorry, you have not passed the course. Try next time! ");
        }
    }
}