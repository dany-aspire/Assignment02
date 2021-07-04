using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG8040_Assignment02
{
    public static class TriangleSolver
    {
        public static string Analyze(int side1, int side2, int side3)
        {
            if ((side1 + side2 > side3) && (side2 + side3 > side1) && (side1 + side3 > side2))
                if ( side1 == side2 && side2 == side3 && side1 == side3)
                    return "equilateral";
                else if ( side1 == side2 || side2 == side3 || side1 == side3)
                    return "isosceles";
                else
                    return "scalene";
            else
            {
                return "not_a_triangle";

            }
        }
    }
}
