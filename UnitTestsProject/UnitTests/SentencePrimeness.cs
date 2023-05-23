namespace TestingProject
{
    public partial class SentencePrimenessTests
    {
        [TestCase("Help me!", ExpectedResult = "Prime Sentence", Description = "Example #1")]
        [TestCase("42 is THE aNsWeR...", ExpectedResult = "Almost Prime Sentence (aNsWeR)", Description = "Example #2")]
        [TestCase("Did you Smoke?", ExpectedResult = "Composite Sentence", Description = "Example #3")]
        [TestCase("She SellS SeaShellS by the SeaShore", ExpectedResult = "Prime Sentence")]
        [TestCase("Lorem. Ipsum. Dolor. Sit. Amet.", ExpectedResult = "Almost Prime Sentence (Lorem)")]
        [TestCase("three fASt hUNgry aniMALs -aNd- 3 slow faTTy kiDS", ExpectedResult = "Almost Prime Sentence (aniMALs)")]
        [TestCase("This is a 'Prime' Sentence", ExpectedResult = "Composite Sentence")]
        [TestCase("this is a composite sentence", ExpectedResult = "Almost Prime Sentence (this)")]
        [TestCase("Primes, PRIMES EVERYWHERE!", ExpectedResult = "Composite Sentence")]
        [TestCase("10 test cases are enough, this is the last one!", ExpectedResult = "Prime Sentence")]
        public static string TestSolution(string str)
        {
            return SentencePrimenessClass.SentencePrimeness(str);
        }
    }
}