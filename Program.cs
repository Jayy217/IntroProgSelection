using System;

namespace introprogselection
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            age = 18;
            int legalAge = 18;

            if (age >= legalAge)
            {
                Console.WriteLine("DRINK");
                Console.WriteLine("DRIVE");
            }
            else
            {
                Console.WriteLine("DON'T DRINK");
                Console.WriteLine("DON'T DRIVE WITHOUT THE L PLATE");
            }
            Console.WriteLine("PROGRAM FINISHED");
        }
    }
}
