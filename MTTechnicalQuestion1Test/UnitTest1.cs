using MTTechnicalQuestion1;

namespace MTTechnicalQuestion1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var case1 = new Program().joinArrays(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 5, 6 });
            CollectionAssert.AreEqual(case1, new int[] { 1, 2, 3, 4, 5, 6 });
        }

        [TestMethod]
        public void TestMethod2()
        {
            var case1 = new Program().joinArrays(new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 });
            CollectionAssert.AreEqual(case1, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
        }

        [TestMethod]
        public void TestMethod3()
        {
            var case1 = new Program().joinArrays(new int[] { 1, 2, 1, 2 }, new int[] { 1, 2, 7, 8 });
            CollectionAssert.AreEqual(case1, new int[] { 1, 2, 1, 2, 7, 8 });
        }

        [TestMethod]
        public void TestMethod4()
        {
            var case1 = new Program().joinArrays(new int[] { 5, 5, 1, 2 }, new int[] { 5, 1, 7, 8 });
            CollectionAssert.AreEqual(case1, new int[] { 5, 5, 1, 2, 5, 1, 7, 8 });
        }

        [TestMethod]
        public void TestMethod5()
        {
            var case1 = new Program().joinArrays(new int[] { 1, 2, 3, 4 }, new int[] { 12, 34, 56, 78 });
            CollectionAssert.AreEqual(case1, new int[] { 1, 2, 3, 4, 12, 34, 56, 78 });
        }

        [TestMethod]
        public void TestMethod6()
        {
            var case1 = new Program().joinArrays(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 5, 6, 7 });
            CollectionAssert.AreEqual(case1, new int[] { 1, 2, 3, 4, 5, 6, 7 });
        }

        [TestMethod]
        public void TestMethod7()
        {
            var case1 = new Program().joinArrays(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6, 7 });
            CollectionAssert.AreEqual(case1, new int[] { 1, 2, 3, 4, 5, 6, 7 });
        }

        [TestMethod]
        public void TestMethod8()
        {
            var case1 = new Program().joinArrays(new int[] { 1, 2, 3, 4, 5, 3, 4, 5 }, new int[] { 3, 4, 5, 7, 8, 9 });
            CollectionAssert.AreEqual(case1, new int[] { 1, 2, 3, 4, 5, 3, 4, 5, 7, 8, 9 });
        }

        [TestMethod]
        public void TestMethod9()
        {
            var case1 = new Program().joinArrays(new int[] { }, new int[] { 1, 2, 3, 4 });
            CollectionAssert.AreEqual(case1, new int[] { 1, 2, 3, 4 });
        }

        [TestMethod]
        public void TestMethod10()
        {
            var case1 = new Program().joinArrays(new int[] { 1, 2, 3, 4 }, new int[] { });
            CollectionAssert.AreEqual(case1, new int[] { 1, 2, 3, 4 });
        }

        [TestMethod]
        public void TestMethod11()
        {
            var case1 = new Program().joinArrays(new int[] { }, new int[] { });
            CollectionAssert.AreEqual(case1, new int[] { });
        }

    }
}