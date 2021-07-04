using System;
using NUnit.Framework;
using SENG8040_Assignment02;

namespace SENG8040_Assignment02.Tests
{
    [TestFixture]
    public class ValidateTriangleSidesIsoceles2Test
    {
        [Test]
        public void TestTriangleSidesValidEdge2()
        {
            string output = TriangleSolver.Analyze(3, 3, 6);
            Assert.AreEqual(output, "not_a_triangle");
        }

    }
}
