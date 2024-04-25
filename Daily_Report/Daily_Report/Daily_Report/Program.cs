using System;

class Program
{
    static void Main()
    {
        // Print the name of the academy and the report title
        Console.WriteLine("The Tech Academy.");
        Console.WriteLine("Student Daily Report.");

        // Ask for the student's name and store the input in a variable
        Console.WriteLine("What is your name?");
        string studentName = Console.ReadLine();

        // Ask for the current course and store the input in a variable
        Console.WriteLine("What course are you on?");
        string courseName = Console.ReadLine();

        // Ask for the page number and store the input in a variable
        Console.WriteLine("What page number?");
        int pageNumber = int.Parse(Console.ReadLine()); // Converts string to integer

        // Ask if the student needs help and store the input as a boolean
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
        bool needsHelp = bool.Parse(Console.ReadLine()); // Converts string to boolean

        // Ask for any positive experiences and store the input
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string positiveExperiences = Console.ReadLine();

        // Ask for any additional feedback and store the input
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string otherFeedback = Console.ReadLine();

        // Ask how many hours were spent studying and store the input as an integer
        Console.WriteLine("How many hours did you study today?");
        int studyHours = int.Parse(Console.ReadLine()); // Converts string to integer

        // Print a thank you message and indicate that an instructor will respond soon
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

        // End of the program
    }
}
