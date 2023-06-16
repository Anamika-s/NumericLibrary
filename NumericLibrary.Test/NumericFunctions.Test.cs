namespace NumericLibrary.Test
{
    public class Tests
    {
        NumericLibrary.NumericFunctions numericFunctions = null;

        [SetUp]
        public void Setup()
        {
           numericFunctions = new NumericLibrary.NumericFunctions();   
        }
        // All tests are run using AAA
        // A > Arrange
        // A > Act
        // A > Assert

        [Test]
        public void AddTest1()
        {
            // A > Arrange
            //NumericLibrary.NumericFunctions numericFunctions = new NumericLibrary.NumericFunctions();
            // Act
            int actual = numericFunctions.Add(2, 3);
            // Assert
            Assert.AreEqual(5, actual);

        }

        [Test]
        [Ignore("This is under construction")]
        [Author("aaa", "aa@gmail.com")]
        public void AddTest2()
        {
            // A > Arrange
            //NumericLibrary.NumericFunctions numericFunctions = new NumericLibrary.NumericFunctions();
            // Act
            int actual = numericFunctions.Add(12, 3);
            // Assert
            Assert.AreEqual(5, actual);

        }
        [TestCase(0, 0, 0)]
        [TestCase(10,30, 40)]
        [TestCase(11,13, 21)]
        public void Test3(int x, int y, int expected)
        { // A > Arrange
            //NumericLibrary.NumericFunctions numericFunctions = new NumericLibrary.NumericFunctions();
            // Act
            int actual = numericFunctions.Add(x, y);
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TearDown]
        public void End()
        {

        }
    }
}