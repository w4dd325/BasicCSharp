using System;

namespace BasicCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //*****************************************************************************************
            //FOR LOOP WITH NESTED IF
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(i);
                }
            }

            //*****************************************************************************************
            //CALLING A FUNCTION
            static void func()
            {
                Console.WriteLine("Calling my Func");
            }

            func();

            //*****************************************************************************************
            //Passing the first level of a video game awards the player 1 point. For each subsequent 
            //level passed, the points awarded increment by 1 (2 for the 2nd level, 3 for the 3rd, and 
            //so on).
            //The program you are given takes the number of passed levels as input. Complete the given 
            //function to take that number as an argument, and recursively calculate and return the 
            //total number of points given for all passed levels.

            //Explanation
            //Level 1: 1 point
            //Level 2: 2 points
            //Level 3: 3 points
            //Total: 1+2+3 = 6 points.
             
            int levels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Points(levels));

            static int Points(int levels)
            {
                //your code goes here
                if (levels == 1)
                {
                    return 1;
                }
                return levels + Points(levels - 1);
            }
            
        }

    }
}
