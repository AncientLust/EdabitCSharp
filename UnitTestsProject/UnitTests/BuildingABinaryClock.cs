namespace TestingProject
{
    public partial class BuildingABinaryClockTests
    {
        [TestCase("07:24:16", ExpectedResult = new string[] { " 0 0 0", " 10101", "011001", "010010" })]
        [TestCase("13:48:18", ExpectedResult = new string[] { " 0 1 1", " 01000", "010000", "110010" })]
        [TestCase("18:48:15", ExpectedResult = new string[] { " 1 1 0", " 01001", "000000", "100011" })]
        [TestCase("11:47:55", ExpectedResult = new string[] { " 0 0 0", " 01111", "000100", "110111" })]
        [TestCase("05:46:39", ExpectedResult = new string[] { " 0 0 1", " 11100", "000110", "010011" })]
        [TestCase("20:35:19", ExpectedResult = new string[] { " 0 0 1", " 00100", "101000", "001111" })]
        [TestCase("10:51:40", ExpectedResult = new string[] { " 0 0 0", " 01010", "000000", "101100" })]
        [TestCase("10:16:17", ExpectedResult = new string[] { " 0 0 0", " 00101", "000101", "101011" })]
        [TestCase("08:17:26", ExpectedResult = new string[] { " 1 0 0", " 00101", "000111", "001100" })]
        [TestCase("17:48:59", ExpectedResult = new string[] { " 0 1 1", " 11010", "010000", "110011" })]
        [TestCase("20:04:33", ExpectedResult = new string[] { " 0 0 0", " 00100", "100011", "000011" })]
        [TestCase("01:35:39", ExpectedResult = new string[] { " 0 0 1", " 00100", "001010", "011111" })]
        [TestCase("13:23:39", ExpectedResult = new string[] { " 0 0 1", " 00000", "011110", "110111" })]
        [TestCase("01:56:09", ExpectedResult = new string[] { " 0 0 1", " 01100", "000100", "011001" })]
        [TestCase("10:50:22", ExpectedResult = new string[] { " 0 0 0", " 01000", "000011", "101000" })]
        [TestCase("07:41:09", ExpectedResult = new string[] { " 0 0 1", " 11000", "010000", "010101" })]
        [TestCase("10:20:42", ExpectedResult = new string[] { " 0 0 0", " 00010", "001001", "100000" })]
        [TestCase("02:19:30", ExpectedResult = new string[] { " 0 1 0", " 00000", "010010", "001110" })]
        [TestCase("13:41:41", ExpectedResult = new string[] { " 0 0 0", " 01010", "010000", "110101" })]
        [TestCase("03:17:28", ExpectedResult = new string[] { " 0 0 1", " 00100", "010110", "011100" })]
        public static string[] TestBinaryClock(string time)
        {
            Console.WriteLine($"Input: {time}");
            return BuildingABinaryClock.BinaryClock(time);
        }
    }
}