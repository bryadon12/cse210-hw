using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int sum = 0;
        int ave;
        int i = 0;
        int largeNumber = 0;
        List<int> numbers = [];
        Console.WriteLine("Enter a list of numbers, enter 0 when finished.");
        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        } while (number != 0);
        numbers.Remove(0);

        foreach (int numb in numbers)
        {
            i++;
            sum += numb;   
            if (largeNumber < numb)
            {
                largeNumber = numb;
            }
        }

        ave = sum/i;
        Console.WriteLine($"The sum is :{sum}");
        Console.WriteLine($"The average is :{ave}");
        Console.WriteLine($"The largest number is :{largeNumber}");
    }
}