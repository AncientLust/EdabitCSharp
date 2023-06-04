namespace TestingProject
{
    public partial class RationalNumberTests
    {
        [Test]
        [TestCase(2, 5, ExpectedResult = "0.4")]
        [TestCase(1, 6, ExpectedResult = "0.1(6)")]
        [TestCase(1, 3, ExpectedResult = "0.(3)")]
        [TestCase(1, 7, ExpectedResult = "0.(142857)")]
        [TestCase(1, 77, ExpectedResult = "0.(012987)")]
        [TestCase(13, 26, ExpectedResult = "0.5")]
        [TestCase(1, 13, ExpectedResult = "0.(076923)")]
        [TestCase(1, 125, ExpectedResult = "0.008")]
        [TestCase(1, 450, ExpectedResult = "0.00(2)")]
        [TestCase(27, 125000, ExpectedResult = "0.000216")]
        [TestCase(9, 125000, ExpectedResult = "0.000072")]
        [TestCase(1, 152, ExpectedResult = "0.006(578947368421052631)")]
        [TestCase(1, 1225, ExpectedResult = "0.00(081632653061224489795918367346938775510204)")]
        public static string FixedTest(int a, int b)
        {
            return RationalNumber.Rational(a, b);
        }
    }
}