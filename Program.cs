using System;

namespace introprogselection
{
    class Program
    {
        static void Main(string[] args)
        {

            int legalAge = 18;
            int lAge = 16;

            Console.WriteLine("HOW OLD ARE YOU?");
            int age = Convert.ToInt32(Console.ReadLine());

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


            if (age >= lAge)
            {
                Console.WriteLine("YOU CAN LEAVE SCHOOL");
            }
            else
            {
                Console.WriteLine("MUST STAY IN SCHOOL");
            }
             Console.WriteLine("PROGRAM FINISHED");

        }
    }
}
