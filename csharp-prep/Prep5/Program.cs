using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Welcome to the program!\nPlease enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($" Brother {name}, the square of your number is {number*number}");
    }
//  Welcome to the program!
// Please enter your name: Brother Burton
// Please enter your favorite number: 42
// Brother Burton, the square of your number is 1764
}