using NUnit.Framework;
using Sage;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsTrue()
        {
            Assert.IsTrue(Combinatoris.SplitArray(new int[] { 1, 1 }));
            Assert.IsTrue(Combinatoris.SplitArray(new int[] { 1, 2, 3 }));
            Assert.IsTrue(Combinatoris.SplitArray(new int[] { 4, 6, 10 }));
            Assert.IsTrue(Combinatoris.SplitArray(new int[] { 1, 2, 3, 6 }));
            Assert.IsTrue(Combinatoris.SplitArray(new int[] { 1, 1, 1, 1 }));
            Assert.IsTrue(Combinatoris.SplitArray(new int[] { 1, 3, 3, 4, 5 }));
            Assert.IsTrue(Combinatoris.SplitArray(new int[] { 1, 1, 2, 2, 3, 3 }));
        }

        [Test]
        public void IsFalse()
        {
            Assert.IsFalse(Combinatoris.SplitArray(new int[] { 1 }));
            Assert.IsFalse(Combinatoris.SplitArray(new int[] { 1, 2 }));
            Assert.IsFalse(Combinatoris.SplitArray(new int[] { 2, 2, 2 }));
            Assert.IsFalse(Combinatoris.SplitArray(new int[] { 1, 4, 6, 10 }));
            Assert.IsFalse(Combinatoris.SplitArray(new int[] { 2, 4, 5, 6 }));
            Assert.IsFalse(Combinatoris.SplitArray(new int[] { 1, 1, 1, 1, 1 }));
        }
    }
}