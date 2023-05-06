namespace TestingProject
{
    public partial class TheSmallestNumberTests
    {
        [Test]
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(10, ExpectedResult = "2520")]
        [TestCase(17, ExpectedResult = "12252240")]
        [TestCase(31, ExpectedResult = "72201776446800")]
        [TestCase(99, ExpectedResult = "69720375229712477164533808935312303556800")]
        [TestCase(100, ExpectedResult = "69720375229712477164533808935312303556800")]
        [TestCase(101, ExpectedResult = "7041757898200960193617914702466542659236800")]
        public static string TestSmallest(int n)
        {
            Console.WriteLine($"Input: {n}");
            return TheSmallestNumber.Smallest(n);
        }
    }
}