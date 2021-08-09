using System;

namespace CollatzConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("The Collatz Conjecture:");
            Console.WriteLine("Uneven number: *3+1");
            Console.WriteLine("Even number: /2");
            Console.WriteLine("Choose a number:");
        }
    }
}
