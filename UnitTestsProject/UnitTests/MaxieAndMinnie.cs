namespace TestingProject
{
    public partial class MaxieAndMinnie
    {
        [Test]
        [TestCase(9876543210, ExpectedResult = new long[] { 9876543210, 1876543290 })]
        [TestCase(1234567890, ExpectedResult = new long[] { 9234567810, 1034567892 })]
        [TestCase(190015878798001, ExpectedResult = new long[] { 990015878718001, 100015878798091 })]
        [TestCase(411347917692022, ExpectedResult = new long[] { 911347917642022, 111347947692022 })]
        [TestCase(91620336331950, ExpectedResult = new long[] { 99620336331150, 11620336339950 })]
        [TestCase(428256072523076, ExpectedResult = new long[] { 824256072523076, 228256072543076 })]
        [TestCase(999607251369567, ExpectedResult = new long[] { 999907251366567, 199607259369567 })]
        [TestCase(10936404093733, ExpectedResult = new long[] { 90936404013733, 10036404993733 })]
        [TestCase(116962727585478, ExpectedResult = new long[] { 916162727585478, 112962767585478 })]
        [TestCase(645440811595719, ExpectedResult = new long[] { 945440811595716, 145440811595769 })]
        [TestCase(304732653285373, ExpectedResult = new long[] { 804732653235373, 204732653385373 })]
        [TestCase(734694929081563, ExpectedResult = new long[] { 934694927081563, 134694929087563 })]
        [TestCase(597202395684464, ExpectedResult = new long[] { 997202355684464, 297205395684464 })]
        [TestCase(111090753368874, ExpectedResult = new long[] { 911010753368874, 101091753368874 })]
        [TestCase(357758017083851, ExpectedResult = new long[] { 857758017083351, 157758017083853 })]
        [TestCase(744888865698909, ExpectedResult = new long[] { 944888865698907, 447888865698909 })]
        [TestCase(589067130451808, ExpectedResult = new long[] { 985067130451808, 189067130455808 })]
        [TestCase(236077600527389, ExpectedResult = new long[] { 936077600527382, 206077603527389 })]
        [TestCase(405272406161141, ExpectedResult = new long[] { 705242406161141, 105272406161144 })]
        [TestCase(21460234556134, ExpectedResult = new long[] { 61460234552134, 11460234556234 })]
        [TestCase(347435942637955, ExpectedResult = new long[] { 947435942637355, 247435943637955 })]
        [TestCase(942631615759140, ExpectedResult = new long[] { 992631615754140, 142631615759940 })]
        public static long[] TestMaxMin(long n)
        {
            Console.WriteLine($"Input: {n}");
            return MaxieAndMinnieClass.MaxMin(n);
        }
    }
}