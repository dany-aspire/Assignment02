using System;
using NUnit.Framework;
using SENG8040_Assignment02;

namespace SENG8040_Assignment02.Tests
{
    [TestFixture]
    public class TriangleScaleneTest
    {
        [Test]
        public void TestScalene()
        {
            string output = TriangleSolver.Analyze(2, 4, 5);
            Assert.AreEqual(output, "scalene");
        }
    }
}
