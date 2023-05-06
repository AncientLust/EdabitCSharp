namespace TestingProject
{
    public partial class NumberOfLuckyTicketsTests
    {
        [TestCase(2, ExpectedResult = 10)]
        [TestCase(4, ExpectedResult = 670)]
        [TestCase(6, ExpectedResult = 55252)]
        [TestCase(8, ExpectedResult = 4816030)]
        [TestCase(10, ExpectedResult = 432457640)]
        [TestCase(12, ExpectedResult = 39581170420)]
        [TestCase(14, ExpectedResult = 3671331273480)]
        public static long NumberOfLuckyTickets(int n)
        {
            return NumberOfLuckyTicketsClass.LuckyTicket(n);
        }
    }
}