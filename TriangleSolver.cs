using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG8040_Assignment02
{
    public static class TriangleSolver
    {
        public static void Analyze(int side1, int side2, int side3)
        {
            if ( side1 == side2 && side2 == side3 && side1 == side3)
                Console.WriteLine("The triangle is equilateral");
            else if ( side1 == side2 || side2 == side3 || side1 == side3)
                Console.WriteLine("The triangle is isosceles");
            else
                Console.WriteLine("The triangle is scalene");
        }
    }
}
