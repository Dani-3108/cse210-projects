using System.IO;
//Author: Daniel Osorio

public class Journal
//Responsibility: Stores and manages a list of journal entries
{
    //Attributes (Variables)
    public List<Entry> _entries = new List<Entry>();

    //Methods (Behaviors)
    public void AddEntry(Entry NewEntry)
    //Purpose: Adds to the list the entries wrote by the user
    {
        _entries.Add(NewEntry);
    }

    public void DisplayAllEntries()
    //Purpose: using a for loop, it displays all the entries the user has ever wrote on the journal
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    //Purpose: It opens and close safely the file and save or writes on the file all the entries in the format writen below.
    {
        //this is as with method on python to open and close safely files
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                //this Outputfile writes on the file
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._usermood}");
            }
        }
    }

    public void LoadFromFile(string file)
    //Purpose: Read entries from a file and put them back into your journal.

    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            entry._usermood = parts[3];
            _entries.Add(entry);
        }
    }
}