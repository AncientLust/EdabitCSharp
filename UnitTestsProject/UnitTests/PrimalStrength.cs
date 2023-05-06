namespace TestingProject
{
    public partial class PrimalStrengthTests
    {
        [Test]
        [TestCase(5, ExpectedResult = "Balanced")]
        [TestCase(211, ExpectedResult = "Balanced")]
        [TestCase(593, ExpectedResult = "Balanced")]
        [TestCase(1693, ExpectedResult = "Strong")]
        [TestCase(599, ExpectedResult = "Strong")]
        [TestCase(2203, ExpectedResult = "Strong")]
        [TestCase(19, ExpectedResult = "Weak")]
        [TestCase(2971, ExpectedResult = "Weak")]
        [TestCase(1493, ExpectedResult = "Weak")]
        public static string PrimalStrength(int n)
        {
            Console.WriteLine($"Input: {n}");
            return PrimalStrengthClass.PrimalStrength(n);
        }
    }
}