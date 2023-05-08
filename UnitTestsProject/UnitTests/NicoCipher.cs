namespace TestingProject
{
    public partial class NicoCipherTests
    {
        [TestCase("mubashirhassan", "crazy", ExpectedResult = "bmusarhiahass n")]
        [TestCase("edabitisamazing", "matt", ExpectedResult = "deabtiismaaznig ")]
        [TestCase("Pakistanisamazing", "airforce", ExpectedResult = "Paniasktiinmsaazg       ")]
        [TestCase("iloveher", "612345", ExpectedResult = "lovehir    e")]
        [TestCase("iwillquitsoon", "endisnear", ExpectedResult = "iiiulwqtl os no   ")]
        public static string TestSolution(string msg, string key)
        {
            return NicoCipherClass.NicoCipher(msg, key);
        }
    }
}