using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String userName=PromptUserName();
        int userNumber=PromptUserNumber();
        int squaredNumber=SquareNumber(userNumber);
        DisplayResult(userName,squaredNumber);
        //DisplayWelcome Function
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        // PromptUserName Function
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            String userName=Console.ReadLine();
            return userName;
        }
        //PromptUserNumber Function
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            String number=Console.ReadLine();
            int userNumber=int.Parse(number);
            return userNumber;
        }
        //SquareNumber Function
        static int SquareNumber(int userNumber)
        {
            int squaredNumber= userNumber*userNumber;
            return squaredNumber;
        }
        //DisplayResult Function
        static void DisplayResult(String userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
        }
    }
}