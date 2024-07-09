// See https://aka.ms/new-console-template for more information

using System;

class UserInput
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");  // Use Write for no newline after prompt
        string userInput = Console.ReadLine();  // Read the user input

        Console.WriteLine(" Welcome to Revature " + userInput);  // Print with formatting

    }
}


