//Author: Daniel Osorio

public class Entry
//Responsibility: Represents a single journal entry
{
    //Attributes (Variables)
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _usermood;

    //Methods (Behaviors)
    public void Display()
    {
        Console.WriteLine($"Date:{_date}.");
        Console.WriteLine($"Prompt:{_promptText}");
        Console.WriteLine($"My Entry:{_entryText}");
        Console.WriteLine($"Mood of today:{_usermood}");
        Console.WriteLine();
    }
}