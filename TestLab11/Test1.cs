using lab11;

namespace TestLab11
{
    [TestClass]
    public class LuckyNumberTests
    {
        [TestMethod]
        public void IsLuckyNumber_123123()
        {
            bool res = LuckyNumber.IsLuckyNumber("123123");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void IsLuckyNumber_222234()
        {
            bool res = LuckyNumber.IsLuckyNumber("222234");
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void IsLuckyNumber_111111()
        {
            bool res = LuckyNumber.IsLuckyNumber("111111");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void IsLuckyNumber_000000()
        {
            bool res = LuckyNumber.IsLuckyNumber("000000");
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void IsLuckyNumber_444336()
        {
            bool res = LuckyNumber.IsLuckyNumber("444336");
            Assert.IsTrue(res);
        }

    }
}