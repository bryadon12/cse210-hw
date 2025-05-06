using System;

int magicNumber;
int guess;
Random randomGenerator = new Random();
magicNumber = randomGenerator.Next(1, 100);
Console.WriteLine("I have choosen the Magic Number! ");

do
{
    Console.WriteLine("What is your guess?");
    guess = int.Parse(Console.ReadLine());
    if (guess == magicNumber)
    {
        Console.WriteLine("You got it!!!");
    }
    else if (guess < magicNumber)
    {
        Console.WriteLine("Higher");
    }
    else
    {
        Console.WriteLine("Lower");
    }
} while (guess != magicNumber);
