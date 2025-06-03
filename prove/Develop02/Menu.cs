using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

class Menu
{
    Journal _Journal;
    String _Title;
    String _Discription;
    List<String> _MenuItems;

    public void ReadFile()
    {

    }

    public void SaveFile()
    {

    }

    public void MakeEntry()
    {

    }

    public void DisplayEntries()
    {

    }

    public List<String> CreateMenu()
    {
        _MenuItems = ["1. Write a New Entry", "2. Display the Journal", "3. Save Journal to a File", 
        "4. Load a Journal from a File", "5. Exit"];
        return _MenuItems;
    }

    public string DisplayMenu()
    {
        Console.WriteLine("Choose an optino 1-5: ");
        foreach (String MenuItem in _MenuItems)
        {
            Console.WriteLine(MenuItem);
        }
        return Console.ReadLine();
    }
}