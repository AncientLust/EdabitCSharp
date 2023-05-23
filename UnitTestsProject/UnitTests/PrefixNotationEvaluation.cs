namespace TestingProject
{
    public partial class PrefixNotationEvaluationTests
    {
        [TestCase("- -14 -15", ExpectedResult = 1)]
        [TestCase("+ 12 13", ExpectedResult = 25)]
        [TestCase("* 3 3", ExpectedResult = 9)]
        [TestCase("+ -15 15", ExpectedResult = 0)]
        [TestCase("- 2200 100", ExpectedResult = 2100)]
        [TestCase("/ 1000 10", ExpectedResult = 100)]
        [TestCase("+ 20 20", ExpectedResult = 40)]
        [TestCase("* - 8 6 10", ExpectedResult = 38)]
        [TestCase("+ 13 100", ExpectedResult = 113)]
        [TestCase("* / 40 4 3", ExpectedResult = 53)]
        [TestCase("- + 200 300 500", ExpectedResult = 400)]
        [TestCase("+ - * / 100 10 4 100 20", ExpectedResult = 90)]
        [TestCase("* + 20 2 5", ExpectedResult = 45)]
        [TestCase("/ + * 12 8 2 2", ExpectedResult = 6)]
        public static int TestSolution(string exp)
        {
            return PrefixNotationEvaluation.Prefix(exp);
        }
    }
}