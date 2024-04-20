using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Multiply_10and5_50returned()
        {
            int x = 10;
            int y = 5;
            int expected = 50;

            Class1 c = new Class1();
            int actual = c.Multiply(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}