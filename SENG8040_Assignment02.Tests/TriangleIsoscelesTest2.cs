using System;
using NUnit.Framework;
using SENG8040_Assignment02;

namespace SENG8040_Assignment02.Tests
{
    [TestFixture]
    public class TriangleIsoscelesTest2
    {
        [Test]
        public void TestIsosceles2()
        {
            string output = TriangleSolver.Analyze(1, 3, 3);
            Assert.AreEqual(output, "isosceles");
        }

    }
}
