using System;
using NUnit.Framework;
using SENG8040_Assignment02;

namespace SENG8040_Assignment02.Tests
{
    [TestFixture]
    public class ValidateTriangleSidesTest
    {
        [Test]
        public void TestTriangleSidesValid()
        {
            string output = TriangleSolver.Analyze(1, 2, 3);
            Assert.AreEqual(output, "not_a_triangle");
        }
 

    }
}
