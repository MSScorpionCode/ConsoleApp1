using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            var start = Console.ReadLine();

            string[] commands = new string[3] { "Command1", "Command2", "Command3" };
            string sabrina = "Sabrina";

            if (start == "Hello")
            {
                Console.WriteLine("What is your name?");
                var name = Console.ReadLine();
                if (name == sabrina)
                {
                    Console.WriteLine("Heey Sabrina! My owner is called " ,sabrina, ".");
                }
                else
                {
                    Console.WriteLine("Nice To meet you " + name);
                }
                
                Console.WriteLine("My name is Dakoda.");
                Console.WriteLine("What are you here for?");
                var here = Console.ReadLine();
                if (here == "Testing")
                {
                    Console.WriteLine("Then you are in the right place!");
                    Console.WriteLine("Tell me what can I do for you?");
                    var input = Console.ReadLine();
                    if (input == "Show me your commands")
                    {
                        Console.WriteLine(string.Join(",", commands));
                    }
                }
            }
            else
            {
                Console.WriteLine("I said Hello");
            }
            var key = System.Console.ReadKey();
        }
    }
}