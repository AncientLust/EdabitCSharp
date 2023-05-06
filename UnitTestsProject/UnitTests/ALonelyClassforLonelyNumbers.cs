namespace TestingProject
{
    public partial class ALonelyClassforLonelyNumbersTests
    {
        [TestCase(0, 22, ExpectedResult = "number: 0, distance: 2, closest: 2")]
        [TestCase(8, 123, ExpectedResult = "number: 120, distance: 7, closest: 127")]
        [TestCase(938, 1190, ExpectedResult = "number: 1140, distance: 11, closest: 1151")]
        [TestCase(120, 1190, ExpectedResult = "number: 211, distance: 12, closest: 223")]
        [TestCase(2, 31, ExpectedResult = "number: 23, distance: 4, closest: 19")]
        [TestCase(14, 50, ExpectedResult = "number: 23, distance: 4, closest: 19")]
        [TestCase(889, 1389, ExpectedResult = "number: 1344, distance: 17, closest: 1361")]
        [TestCase(3208, 8752, ExpectedResult = "number: 3967, distance: 20, closest: 3947")]
        [TestCase(16723, 28775, ExpectedResult = "number: 24281, distance: 30, closest: 24251")]
        public static string TestLoneliestNumber(int lo, int hi)
        {
            Console.WriteLine($"Input: {lo}, {hi}");
            return ALonelyClassforLonelyNumbers.LoneliestNumber(lo, hi);
        }
    }
}