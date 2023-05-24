namespace TestingProject
{
    public partial class IPutMyPrimeDownFlipItandReverseItTests
    {
        [TestCase(101, ExpectedResult = "P")]
        [TestCase(1011, ExpectedResult = "C")]
        [TestCase(1069, ExpectedResult = "E")]
        [TestCase(1061, ExpectedResult = "B")]
        [TestCase(198101, ExpectedResult = "C")]
        [TestCase(1009, ExpectedResult = "E")]
        [TestCase(10091, ExpectedResult = "B")]
        [TestCase(18616061, ExpectedResult = "B")]
        [TestCase(10909, ExpectedResult = "E")]
        [TestCase(16069, ExpectedResult = "P")]
        public static string TestSolution(int n)
        {
            return IPutMyPrimeDownFlipItandReverseIt.Bemirp(n);
        }
    }
}