using System;

class Program
{
    static void Main(string[] args)
    {
        String keepPlaying="yes";
        while (keepPlaying=="yes")
        {
            //guess count variable
            int guessCount=1;
            //Random number generator
            Random randomGenerator=new Random();
            int magicNumber=randomGenerator.Next(1,100);
            //core requirement but i dont use since i generate the number randon
            //Console.Write("What is the magic number? ");
            //String userInput=Console.ReadLine();
            //int magicNumber= int.Parse(userInput);
            //User Input
            Console.Write("What is your guess? ");
            String userInput=Console.ReadLine();
            int userNumber=int.Parse(userInput);
            //While loop
            while (userNumber != magicNumber)
            {
                //guess count
                guessCount+=1;
                // if statements
                if (userNumber<magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userNumber>magicNumber)
                {
                    Console.WriteLine("Lower");
                } 
                //asking again for user input
                Console.Write("What is your guess? ");
                userInput=Console.ReadLine();
                userNumber=int.Parse(userInput);
            }
            Console.WriteLine("You guessed the Magic Number!");
            Console.WriteLine($"It took you {guessCount} guesses to find the magic number.");
            Console.Write("Do you want to keep playing? ");
            keepPlaying=Console.ReadLine();
        }
    }
}