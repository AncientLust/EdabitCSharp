namespace TestingProject
{
    public partial class SimplifiedProperFractionsTests
    {
        [TestCase(10, ExpectedResult = 31)]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(30, ExpectedResult = 277)]
        [TestCase(100, ExpectedResult = 3043)]
        [TestCase(56, ExpectedResult = 963)]
        public static int TestCode(int num)
        {
            Console.WriteLine($"Input: {num}");
            return SimplifiedProperFractions.SimPropFrac(num);
        }
    }
}