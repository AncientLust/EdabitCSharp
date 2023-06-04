namespace TestingProject
{
    public partial class TheCentrifugeProblemTests
    {
        [TestCase(5, 1, ExpectedResult = false)]
        [TestCase(12, 7, ExpectedResult = true)]
        [TestCase(1, 1, ExpectedResult = false)]
        [TestCase(21, 18, ExpectedResult = true)]
        [TestCase(1, 0, ExpectedResult = false)]
        [TestCase(4, 2, ExpectedResult = true)]
        [TestCase(5, 3, ExpectedResult = false)]
        [TestCase(21, 13, ExpectedResult = false)]
        [TestCase(3, 3, ExpectedResult = true)]
        [TestCase(50, 1, ExpectedResult = false)]
        [TestCase(8, 6, ExpectedResult = true)]
        [TestCase(21, 20, ExpectedResult = false)]
        [TestCase(9, 5, ExpectedResult = false)]
        [TestCase(2, 1, ExpectedResult = false)]
        [TestCase(59, 59, ExpectedResult = true)]
        [TestCase(11, 4, ExpectedResult = false)]
        public static bool TestCentrifuge(int n, int k)
        {
            Console.WriteLine($"Input: n={n}, k={k}");
            return TheCentrifugeProblem.Centrifuge(n, k);
        }
    }
}