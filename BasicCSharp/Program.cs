using System;

namespace BasicCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            //*****************************************************************************************
            //USER INPUT AND CONSOLE OUTPUT
            //Variables
            string yourName;
            string myName = "James";
            int yourAge;
            int myAge = 1000;

            //Names
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Your name is: {0} and mine is: {1}", yourName, myName);

            //Ages
            Console.WriteLine("What is your age?");
            yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: {0} and mine is: {1}", yourAge, myAge);
            
            //*****************************************************************************************
            //CALCULATE AREA OF A CIRCLE
            const double pi = 3.14;
            double radius;
            double area;
            //your code goes here
            Console.WriteLine("What is the radius?");
            radius = Convert.ToDouble(Console.ReadLine());
            area = pi * radius * radius;
            Console.WriteLine("Area = {0}", area);
            */

            //*****************************************************************************************
            //IFS AND LOOPS
            int x = 4;
            int y = 7;
            Console.WriteLine("Int 1 = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Int 2 = ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.Write("{0} is greater than {1}", x, y);
            }
            else
            {
                Console.Write("{0} is NOT greater than {1}", x, y);
            }



        }
    }
}
