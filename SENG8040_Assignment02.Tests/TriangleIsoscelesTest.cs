using System;
using NUnit.Framework;
using SENG8040_Assignment02;

namespace SENG8040_Assignment02.Tests
{
    [TestFixture]
    public class TriangleIsoscelesTest
    {
        [Test]
        public void TestIsosceles()
        {
            string output = TriangleSolver.Analyze(3, 3, 1);
            Assert.AreEqual(output, "isosceles");
        }

    }
}
