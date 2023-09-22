using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_methods_assignment.Services
{
    internal class Class1
    {
 
        
        public static void Method1()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
        public static void Method2()
        {

            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine();
            Console.WriteLine("#" + text);
        }

        public static string Method3(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            return userInput;
        }
       
      

       public static string Method4(string word)
        {
            Console.WriteLine($"Please enter a {word}: ");
           string input = Console.ReadLine();
            return input;
        }

       

        public static string Method5(string firstName, string lastName)
        {
            string fullName = lastName + ", " + firstName;
            Console.WriteLine("Expected outcome:" + fullName);
            return fullName;
        }

    }
        
        }
    
    

