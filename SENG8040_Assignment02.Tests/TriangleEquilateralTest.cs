using System;
using NUnit.Framework;
using SENG8040_Assignment02;

namespace SENG8040_Assignment02.Tests
{
    [TestFixture]
    public class TriangleEquilateralTest
    {
        [Test]
        public void TestEquilateral()
        {
            string output = TriangleSolver.Analyze(3, 3, 3);
            Assert.AreEqual(output, "equilateral");
        }

    }
}
