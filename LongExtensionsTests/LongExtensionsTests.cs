using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LongExtensions;

namespace LongExtensionsTests
{
    [TestClass]
    public class LongExtensionsTests
    {
        [TestMethod]
        public void TestMagnitudeZero()
        {
            long expected = 1;
            long actual   = 0L.Magnitude();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMagnitudeLowerBound()
        {
            long expected = LongExtensions.LongExtensions.MAX_MAGNITUDE;
            long actual   = (long.MinValue + 1).Magnitude();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMagnitudeUpperBound()
        {
            long expected = LongExtensions.LongExtensions.MAX_MAGNITUDE;
            long actual   = long.MaxValue.Magnitude();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMagnitudeDoubleRounding()
        {
            long expected = 1000000000000000;
            long actual   = 9999999999999999.Magnitude();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMagnitudeOverflowException()
        {
            Action actual = () => long.MinValue.Magnitude();
            Assert.ThrowsException<OverflowException>(actual);
        }

        [TestMethod]
        public void TestAppendLowerBound()
        {
            long expected = 0;
            long actual   = 0L.Append(0);
            Assert.AreEqual(expected, actual);
        }
     
        [TestMethod]
        public void TestAppendZero()
        {
            long expected = 10;
            long actual   = 1L.Append(0);
            Assert.AreEqual(expected, actual);
        }
     
        [TestMethod]
        public void TestAppendToZero()
        {
            long expected = 1;
            long actual   = 0L.Append(1);
            Assert.AreEqual(expected, actual);
        }
     
        [TestMethod]
        public void TestAppendUpperBound()
        {
            long expected = long.MaxValue;
            long actual   = 0L.Append(long.MaxValue);
            Assert.AreEqual(expected, actual);
        }
     
        [TestMethod]
        public void TestAppendOverflowException()
        {
            Action actual = () => long.MaxValue.Append(0);
            Assert.ThrowsException<OverflowException>(actual);
        }
     
        [TestMethod]
        public void TestAppendLongAppendException()
        {
            Action actual = () => 1L.Append(-1);
            Assert.ThrowsException<LongAppendException>(actual);
        }
    }
}
