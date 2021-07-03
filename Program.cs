using System;

namespace SENG8040_Assignment02
{
    class Program
    {
        public static void Main(string[] args)
        {
            int userInput, side1, side2, side3;
            do
            {
                Console.WriteLine("Please choose one of the following options:");
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                Int32.TryParse(Console.ReadLine(), out userInput);

                if ( userInput == 1)
                {
                    Console.Write("Please enter side 1 length:");
                    Int32.TryParse(Console.ReadLine(), out side1);
                    Console.Write("Please enter side 2 length:");
                    Int32.TryParse(Console.ReadLine(), out side2);
                    Console.Write("Please enter side 3 length:");
                    Int32.TryParse(Console.ReadLine(), out side3);

                    //check whether triangle sides are valid
                    if ((side1 + side2 > side3) && (side2 + side3 > side1) && (side1 + side3 > side2))
                    {
                        Console.WriteLine("Triangle is valid");
                        TriangleSolver.Analyze(side1, side2, side3);
                    }
                    else
                    {
                        Console.WriteLine("The given sides cannot form a Triangle ");
                    }
                }
            } while ( userInput != 2 );
            Console.WriteLine("Hello World!");
        }
    }
}
