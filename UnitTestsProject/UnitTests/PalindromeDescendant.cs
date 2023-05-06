namespace TestingProject
{
    public partial class PalindromeDescendantTests
    {
        [TestCase(11211230, ExpectedResult = false)]
        [TestCase(13001120, ExpectedResult = true)]
        [TestCase(23336014, ExpectedResult = true)]
        [TestCase(11, ExpectedResult = true)]
        [TestCase(1122, ExpectedResult = false)]
        [TestCase(332233, ExpectedResult = true)]
        [TestCase(10210112, ExpectedResult = true)]
        [TestCase(9735, ExpectedResult = false)]
        [TestCase(97358817, ExpectedResult = false)]
        public static bool PalindromeDescendant(int num)
        {
            return PalindromeDescendantClass.PalindromeDescendant(num);
        }
    }
}