using System;
using NUnit.Framework;
using SENG8040_Assignment02;

namespace SENG8040_Assignment02.Tests
{
    [TestFixture]
    public class ValidateTriangleSidesIscoscelesTest
    {
        [Test]
        public void TestTriangleSidesValidEdge()
        {
            string output = TriangleSolver.Analyze(1, 1, 5);
            Assert.AreEqual(output, "not_a_triangle");
        }

    }
}
