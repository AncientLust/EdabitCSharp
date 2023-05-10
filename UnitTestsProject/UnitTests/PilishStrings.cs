using Microsoft.VisualBasic;

namespace TestingProject
{
    public partial class PilishStringsTests
    {
        [TestCase("FORALOOP", ExpectedResult = "FOR A LOOP")]
        [TestCase("CANIMAKEAGUESS", ExpectedResult = "CAN I MAKE A GUESS")]
        [TestCase("CANIMAKEAGUESSNOW", ExpectedResult = "CAN I MAKE A GUESS NOWWWWWWW")]
        [TestCase("X", ExpectedResult = "XXX")]
        [TestCase("ARANDOMSEQUENCEOFLETTERS", ExpectedResult = "ARA N DOMS E QUENC EOFLETTER SS")]
        [TestCase("", ExpectedResult = "")]
        [TestCase("33314444155555999999999226666665555533355555888888889999999997777777999999999", ExpectedResult = "333 1 4444 1 55555 999999999 22 666666 55555 333 55555 88888888 999999999 7777777 999999999")]
        [TestCase("###*@", ExpectedResult = "### * @@@@")]
        [TestCase("..........", ExpectedResult = "... . .... . .....")]
        // Below, quoting Mike Keith
        [TestCase("NowIfallAtiredsuburbianInliquidunderthetreesDriftingalongsideforestssimm", ExpectedResult = "Now I fall A tired suburbian In liquid under the trees Drifting alongside forests simmmmmmm")]
        // Below, quoting Sir James Hopwood Jeans
        [TestCase("HOWINEEDADRINKALCOHOLICINNATUREAFTERTHEHEAVYLECTURESINVOLVINGQUANTUMMECHANICSANDALLTHESECRETSOFTHEUNIVERSE", ExpectedResult = "HOW I NEED A DRINK ALCOHOLIC IN NATURE AFTER THE HEAVY LECTURES INVOLVING QUANTUM MECHANICS")]
        [TestCase("HOWINEEDADRINKALCOHOLICINNATUREAFTERTHEHEAVYCODING", ExpectedResult = "HOW I NEED A DRINK ALCOHOLIC IN NATURE AFTER THE HEAVY CODINGGG")]
        public static string TestSolution(string txt)
        {
            return PilishStringsClass.PilishString(txt);
        }
    }
}