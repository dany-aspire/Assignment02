using System;
using NUnit.Framework;
using SENG8040_Assignment02;

namespace SENG8040_Assignment02.Tests
{
    [TestFixture]
    public class TriangleIsoscelesTest3
    {
        [Test]
        public void TestIsosceles3()
        {
            string output = TriangleSolver.Analyze(3, 1, 3);
            Assert.AreEqual(output, "isosceles");
        }

    }
}
