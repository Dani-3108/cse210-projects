using System;
//Author: Daniel Osorio
//Exceeding Requirements: The exceeding requirements are:
//1st: i wrote code that makes the program look more user friendly and like a real app, it has an introduction, messages after each action of the program as an app would function and a close message when the user decides to quit.
//2nd: the other information the program storages besides the requirements would be the mood of the user, the program ask the user the mood it has at the moment of writing and stores it at the end of the user entry.

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        //Introduction Mesage
        Console.WriteLine("Welcome to the Journal App");
        Console.WriteLine();
        Console.WriteLine("This app will help you to mantain your habits or reaching constantly your goal of writing on a Journal.");
        Console.WriteLine("And for that to be easier for you so you don't need to think what you should write, the app will provide prompts so you can focus on something specific and meaningfull.");
        Console.WriteLine("Remeber the powerfull quote by Christina Baldwin:");
        Console.WriteLine("'Journal writing is a voyage to the interior.'");
        Console.WriteLine();
        Console.WriteLine("Enjoy this time of writing!!");
        Console.WriteLine();
        //While loop
        int userNumber = 0;
        while (userNumber!=5)
        {
            Console.WriteLine("\nSelect one of the following options: ");
            Console.WriteLine("1: Write a new entry");
            Console.WriteLine("2: Display the journal");
            Console.WriteLine("3: Save the journal to a file");
            Console.WriteLine("4: Load the journal from a file");
            Console.WriteLine("5: Quit");
            Console.Write("What would you like to do? ");
            string uN = Console.ReadLine();
            userNumber = int.Parse(uN);
            Console.WriteLine();
            //Write New Entry
            if (userNumber == 1)
            {
                //Random prompt section
                string prompt = promptGen.GetRandomPrompt();

                Console.WriteLine($"Prompt of the day:{prompt}");
                Console.WriteLine("Your entry:");
                string userEntry = Console.ReadLine();
                Console.WriteLine("What is your mood today?");
                string userMood = Console.ReadLine();
            

                //current date
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                //New Entry
                Entry newEntry = new Entry();
                //Entry data order
                newEntry._date = dateText;
                newEntry._promptText = prompt;
                newEntry._entryText = userEntry;
                newEntry._usermood = userMood;
                //Add new entry
                myJournal.AddEntry(newEntry);
            
            }
            //Display the Journal
            else if (userNumber == 2)
            {
                Console.WriteLine("This are all the entries you have wrote until now;");
                myJournal.DisplayAllEntries();
            }
            //Save the Journal to a file
            else if (userNumber == 3)
            {
                Console.Write("What is the file name where you want to store your entry? ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
                Console.WriteLine("Entry successfully saved!");
            }
            //Load the Journal from a file
            else if (userNumber == 4)
            {
                Console.Write("What is the file name from where you want to load your entries? ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
                Console.WriteLine("Entries loaded successfully!");
            }
            else if (userNumber == 5)
            {
                Console.WriteLine("You took time to listen to yourself today—that matters. See you when you return.");
            }
        }
    }
}