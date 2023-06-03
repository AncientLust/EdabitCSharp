namespace TestingProject
{
    public partial class FactorialTrailingZeroesTests
    {
        [TestCase(6, ExpectedResult = 1)]
        [TestCase(11, ExpectedResult = 2)]
        [TestCase(30, ExpectedResult = 7)]
        [TestCase(150, ExpectedResult = 37)]
        [TestCase(786, ExpectedResult = 195)]
        [TestCase(5017, ExpectedResult = 1252)]
        [TestCase(11693, ExpectedResult = 2919)]
        [TestCase(26677, ExpectedResult = 6666)]
        [TestCase(69101, ExpectedResult = 17272)]
        [TestCase(333571, ExpectedResult = 83388)]
        public static int TestTrailingZeroes(int n)
        {
            Console.WriteLine($"Input: {n}");
            return FactorialTrailingZeroes.TrailingZeroes(n);
        }
    }
}