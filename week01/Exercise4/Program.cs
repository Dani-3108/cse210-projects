using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //creation of list section
        List<int> numbers=new List<int>();
        //intro section
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        //variable to compare in the while loop declare before the loop
        int userNumber=-1;
        //while loop
        while (userNumber!=0)
        {
            //user input
            Console.Write("Enter a Number: ");
            string uN=Console.ReadLine();
            userNumber=int.Parse(uN);
            if (userNumber!=0)
            {
                numbers.Add(userNumber);
            }
        }
        //variable declaring before the loop
        int sum=0;
        //sum or total section
        foreach (int number in numbers)
        {
            sum=sum+number;
        }
        //average section
        float average=((float)sum) / numbers.Count;
        //maximum, largest on the list section
        int largest=numbers[0];
        foreach (int numberInList in numbers)
        {
            if (numberInList > largest)
            {
                largest=numberInList;
            }
        }
        //stretch challenges
        //smallest positive section
        int smallestPositive=99999999;
        foreach (int i in numbers)
        {
            if (i >0 && i <smallestPositive)
            {
                smallestPositive=i;
            }
        }
        //print section 
        Console.WriteLine($"The sum is:{sum}");
        Console.WriteLine($"The average is:{average}");
        Console.WriteLine($"The largest number is:{largest}");
        Console.WriteLine($"The smallest positive number is:{smallestPositive}");
        //sort section 
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}