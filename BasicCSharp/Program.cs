using System;

namespace BasicCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            string myName = "James";
            Console.WriteLine("What is your name?"); 
            yourName = Console.ReadLine();
            Console.WriteLine("Your name is: {0} and mine is: {1}", yourName, myName);
        }
    }
}
