using System;
using System.Runtime.InteropServices;

class Program
{
    // static void ObtainFileName(String prompt)
    // {
        
    // }
    static void Main(string[] args)
    {
        Menu Menu = new Menu();
        Menu.CreateMenu();
        String Option;

        do
        {
            Option = Menu.DisplayMenu();
//["1. Write a New Entry", "2. Display the Journal", "3. Save Journal to a File", 
       // "4. Load a Journal from a File", "5. Exit"];
            switch (Option = Console.ReadLine()) 
            {
                case "1":
                    Menu.MakeEntry();
                break;
                case "2":
                    Menu.DisplayEntries();
                break;
                case "3":
                    Menu.SaveFile();
                break;
                case "4":
                    Menu.ReadFile();
                break;
                case "5":
                break;
            }

        } while (Option!= "5");

    }
}