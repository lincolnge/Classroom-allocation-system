using System;
using NUnit.Framework;

namespace NUnitSample
{
    [TestFixture]
    public class NUnitSampleTest
    {
        [Test]
        public void AddTest()
        {
            MathUtil util = new MathUtil();
            int result = util.Add(4, 4);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void AddTestFailure()
        {
            MathUtil util = new MathUtil();
            int result = util.Add(4, 4);
            Assert.AreEqual(6, result);
        }
    }
}
