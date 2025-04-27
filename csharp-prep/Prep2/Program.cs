using System;

Console.WriteLine("Enter your grade percentage: ");
int gradePercentage = int.Parse(Console.ReadLine());
string letterGrade;
if (gradePercentage >= 90)
{
    letterGrade = "A";
}
else if (gradePercentage >= 80)
{
    letterGrade = "B";
}
else if (gradePercentage >= 70)
{
    letterGrade = "C";
}
else if (gradePercentage >= 60)
{
    letterGrade = "D";
}
else
{
    letterGrade = "F";
}
Console.WriteLine($"You got a(n) {letterGrade}");
if (gradePercentage >= 70)
{
    Console.WriteLine("You passed! Congradulations!!!");
}
else
{
    Console.WriteLine("You did not pass this time. You'll do better next time!");
}
