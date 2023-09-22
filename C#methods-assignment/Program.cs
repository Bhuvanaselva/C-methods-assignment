// See https://aka.ms/new-console-template for more information




using C_methods_assignment.Services;

//Assignment1

Class1.Method1();

//Assignment2

Class1.Method2();

//Assignment3

string message = "Please enter a number:";
        string userText = Class1.Method3(message);
        Console.WriteLine("You entered:" + userText);

//Assignment4

Console.WriteLine("Enter a word: ");
string word = Console.ReadLine();
string userInput = Class1.Method4(word);
Console.WriteLine($"You entered: {userInput}");

//Assignment5

Console.WriteLine("My firstname:");
string firstName = "Bhuvana";
Console.WriteLine(firstName);
Console.WriteLine("My lastname:");
string lastName = "Selvaraj";
Console.WriteLine(lastName);
string fullName = Class1.Method5(firstName, lastName);
