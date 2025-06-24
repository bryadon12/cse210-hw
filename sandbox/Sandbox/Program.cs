using System;
class Program
{
    static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Lemi", 34);
        Console.WriteLine(myPerson.GetPersonInformation());
        PoliceMan myPoliceman = new PoliceMan("Betty", "Croker", 23, "hammer");
        Console.WriteLine(myPoliceman.GetPersonInformation());
    }
}