namespace TestingProject
{
    public static class PokerHandRankingTests
    {
        [Test]
        [TestCase("10h Jh Qh Ah Kh", ExpectedResult = "Royal Flush")]
        [TestCase("3h 5h Qs 9h Ad", ExpectedResult = "High Card")]
        [TestCase("10s 10c 8d 10d 10h", ExpectedResult = "Four of a Kind")]
        [TestCase("4h 9s 2s 2d Ad", ExpectedResult = "Pair")]
        [TestCase("10s 9s 8s 6s 7s", ExpectedResult = "Straight Flush")]
        [TestCase("10c 9c 9s 10s 9h", ExpectedResult = "Full House")]
        [TestCase("8h 2h 8s 3s 3c", ExpectedResult = "Two Pair")]
        [TestCase("Jh 9h 7h 5h 2h", ExpectedResult = "Flush")]
        [TestCase("Ac Qc As Ah 2d", ExpectedResult = "Three of a Kind")]
        [TestCase("Ad Kd Qd Jd 9d", ExpectedResult = "Flush")]
        [TestCase("10h Jh Qs Ks Ac", ExpectedResult = "Straight")]
        [TestCase("3h 8h 2s 3s 3d", ExpectedResult = "Three of a Kind")]
        [TestCase("4h Ac 4s 4d 4c", ExpectedResult = "Four of a Kind")]
        [TestCase("3h 8h 2s 3s 2d", ExpectedResult = "Two Pair")]
        [TestCase("8h 8s As Qh Kh", ExpectedResult = "Pair")]
        [TestCase("Js Qs 10s Ks As", ExpectedResult = "Royal Flush")]
        [TestCase("Ah 3s 4d Js Qd", ExpectedResult = "High Card")]
        public static string TestPokerHandRanking(string hand)
        {
            Console.WriteLine($"Input: {hand}");
            return PokerHandRankingClass.PokerHandRanking(hand.Split(' '));
        }
    }
}