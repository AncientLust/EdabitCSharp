namespace TestingProject
{
    public partial class UnravelAllThePossibilitiesTests
    {
        [TestCase("abc", ExpectedResult = new string[] { "abc" })]
        [TestCase("a[b|c]", ExpectedResult = new string[] { "ab", "ac" })]
        [TestCase("a[b|c|d]e", ExpectedResult = new string[] { "abe", "ace", "ade" })]
        [TestCase("a[b|cd]ef", ExpectedResult = new string[] { "abef", "acdef" })]
        [TestCase("a[b|c]def[g]", ExpectedResult = new string[] { "abdefg", "acdefg" })]
        [TestCase("a[b|c]de[f|g]", ExpectedResult = new string[] { "abdef", "abdeg", "acdef", "acdeg" })]
        [TestCase("a[b]c[d]", ExpectedResult = new string[] { "abcd" })]
        [TestCase("[a][b][c]d[e]", ExpectedResult = new string[] { "abcde" })]
        [TestCase("[a][b][c]d[e|f|g]", ExpectedResult = new string[] { "abcde", "abcdf", "abcdg" })]
        [TestCase("[a|b][c|d][e|f]", ExpectedResult = new string[] { "ace", "acf", "ade", "adf", "bce", "bcf", "bde", "bdf" })]
        [TestCase("[a][b|c|d][e][f|g]", ExpectedResult = new string[] { "abef", "abeg", "acef", "aceg", "adef", "adeg" })]
        [TestCase("apple [pear|grape]", ExpectedResult = new string[] { "apple grape", "apple pear" })]
        [TestCase("apple [pear|grape] [persimmon|mango] [cherry|apricot]", ExpectedResult = new string[] {
        "apple grape mango apricot",
        "apple grape mango cherry",
        "apple grape persimmon apricot",
        "apple grape persimmon cherry",
        "apple pear mango apricot",
        "apple pear mango cherry",
        "apple pear persimmon apricot",
        "apple pear persimmon cherry" })]
        [TestCase("Let's do [Friday|Wednesday|Saturday] at [4|5|7] for the [concert|movies]?", ExpectedResult = new string[] {
        "Let's do Friday at 4 for the concert?",
        "Let's do Friday at 4 for the movies?",
        "Let's do Friday at 5 for the concert?",
        "Let's do Friday at 5 for the movies?",
        "Let's do Friday at 7 for the concert?",
        "Let's do Friday at 7 for the movies?",
        "Let's do Saturday at 4 for the concert?",
        "Let's do Saturday at 4 for the movies?",
        "Let's do Saturday at 5 for the concert?",
        "Let's do Saturday at 5 for the movies?",
        "Let's do Saturday at 7 for the concert?",
        "Let's do Saturday at 7 for the movies?",
        "Let's do Wednesday at 4 for the concert?",
        "Let's do Wednesday at 4 for the movies?",
        "Let's do Wednesday at 5 for the concert?",
        "Let's do Wednesday at 5 for the movies?",
        "Let's do Wednesday at 7 for the concert?",
        "Let's do Wednesday at 7 for the movies?" })]
        public static string[] TestUnravel(string txt)
        {
            Console.WriteLine($"Input: {txt}");
            return UnravelAllThePossibilities.Unravel(txt);
        }
    }
}