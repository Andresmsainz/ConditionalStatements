using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 0;
            int y = 0;

            Console.WriteLine("Enter No. 1");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter No. 2");
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine(x + " is greater than " + y);
            }
            else if (x < y)
            {
                Console.WriteLine(x + " is less than " + y);
            }
            else if (x == y)
            {
                Console.WriteLine(x + " is equal than " + y);
            }




        }
    }
}
