namespace TestingProject
{
    public partial class UlamSequenceTests
    {
        [TestCase(4, ExpectedResult = 4)]
        [TestCase(9, ExpectedResult = 16)]
        [TestCase(38, ExpectedResult = 180)]
        [TestCase(99, ExpectedResult = 688)]
        [TestCase(206, ExpectedResult = 1856)]
        [TestCase(495, ExpectedResult = 5597)]
        [TestCase(577, ExpectedResult = 6782)]
        public static int TestSolution(int n)
        {
            return UlamSequenceClass.Ulam(n);
        }
    }
}