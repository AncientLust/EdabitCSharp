namespace TestingProject
{
    public partial class ThreeSumProblemTests
    {
        // ThreeSumProblem
        [TestCase(new int[] { 0, 1, -1, -1, 2 }, ExpectedResult = "{ { 0, 1, -1 }, { -1, -1, 2 } }")]
        [TestCase(new int[] { 0, 0, 0, 5, -5 }, ExpectedResult = "{ { 0, 0, 0 }, { 0, 5, -5 } }")]
        [TestCase(new int[] { 0, -1, 1, 0, -1, 1 }, ExpectedResult = "{ { 0, -1, 1 }, { 0, 1, -1 }, { -1, 1, 0 }, { -1, 0, 1 }, { 1, 0, -1 } }")]
        [TestCase(new int[] { 0, 5, 5, 0, 0 }, ExpectedResult = "{ { 0, 0, 0 } }")]
        [TestCase(new int[] { 0, 5, -5, 0, 0 }, ExpectedResult = "{ { 0, 5, -5 }, { 0, 0, 0 }, { 5, -5, 0 } }")]
        [TestCase(new int[] { 1, 2, 3, -5, 8, 9, -9, 0 }, ExpectedResult = "{ { 1, 8, -9 }, { 2, 3, -5 }, { 9, -9, 0 } }")]
        [TestCase(new int[] { 0, 0, 0 }, ExpectedResult = "{ { 0, 0, 0 } }")]
        [TestCase(new int[] { 1, 5, 5, 2 }, ExpectedResult = "{  }")]
        [TestCase(new int[] { 1, 1 }, ExpectedResult = "{  }")]
        [TestCase(new int[] { }, ExpectedResult = "{  }")]
        public static string TestThreeSum(int[] arr)
        {
            var res = ThreeSumProblemClass.ThreeSum(arr);
            var result = string.Join(", ", res.Select(itm => $"{{ {itm[0]}, {itm[1]}, {itm[2]} }}"));
            return "{ " + result + " }";
        }
    }
}