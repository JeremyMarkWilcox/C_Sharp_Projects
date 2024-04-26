using System;

class Program
{
    static void Main()
    {
        // Print the title of the program
        Console.WriteLine("Anonymous Income Comparison Program");

        // Get details for Person 1
        Console.WriteLine("Person 1");
        Console.Write("Enter hourly rate: ");
        decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine()); // Convert input to decimal
        Console.Write("Enter hours worked per week: ");
        int hoursPerWeek1 = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

        // Get details for Person 2
        Console.WriteLine("Person 2");
        Console.Write("Enter hourly rate: ");
        decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine()); // Convert input to decimal
        Console.Write("Enter hours worked per week: ");
        int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

        // Calculate annual salary for Person 1
        decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
        Console.WriteLine("Annual salary of Person 1:");
        Console.WriteLine(annualSalary1); // Display the calculated salary

        // Calculate annual salary for Person 2
        decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;
        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(annualSalary2); // Display the calculated salary

        // Compare salaries and display result
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.WriteLine(annualSalary1 > annualSalary2); // Compare and print true or false
    }
}
