namespace TestingProject
{
    public partial class ThrowingAmountOfDartsTests
    {
        [TestCase(new int[] { 3, 6, 8, 11, 15, 19, 22 }, 3, 35, ExpectedResult = new string[] { "8-8-19" })]
        [TestCase(new int[] { 2, 4, 7, 10, 13, 18, 24 }, 3, 29, ExpectedResult = new string[] { "4-7-18" })]
        [TestCase(new int[] { 3, 7, 11, 14, 18, 20, 25 }, 3, 40, ExpectedResult = new string[] { "11-11-18" })]
        [TestCase(new int[] { 3, 7, 11, 14, 18, 20, 25 }, 3, 8, ExpectedResult = new string[] { })]
        [TestCase(new int[] { 3, 7, 11, 14, 18, 20, 25 }, 3, 32, ExpectedResult = new string[] { "3-11-18", "7-7-18", "7-11-14" })]
        [TestCase(new int[] { 3, 7, 11, 14, 18, 20, 25, 29, 34 }, 3, 67, ExpectedResult = new string[] { "18-20-29" })]
        [TestCase(new int[] { 3, 7, 11, 14, 18, 20, 25 }, 4, 23, ExpectedResult = new string[] { "3-3-3-14" })]
        public static string[] TestDartsSolver(int[] sections, int darts, int target)
        {
            return ThrowingAmountOfDarts.DartsSolver(sections, darts, target);
        }
    }
}