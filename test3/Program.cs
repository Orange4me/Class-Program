using System;

namespace test3
{
    class Program
    {

        
        static void Main (string[] arg)
        {
            //Variables that are declared must be specified. Here are some options
            // Int - Integers (whole numbers, positive and negative)
            // string - Strings (a sequence of characters, including letters, numbers, or symbols)
            // float - Floating point numbers (numbers that use decimals)
            // double - Double precision floating point numbers (just like a float, except it takes up twice as much memory, so it can hold larger numbers or numbers with more decimal places.
            // bool - Boolean variables (true or false)

            int x = 5;

            // To use a print statement use command: Console.WriteLine("")
            // To make it so the code does not add it to a new line after the print statement do Console.Write("")
            Console.WriteLine(x);
            Console.Write("There will not be a new line of code after this. By the way,");

            Console.WriteLine("Hello World!");

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine($"Your favorite color is {color}");
        
        
//In C#, curly braces {} define the body of an if statement or a function. In python, 
//indenting did the same job. Indenting in C# is just for convention        
        }
    }
}