namespace TestingProject
{
    public partial class EnglishToPigLatinTranslatorTests
    {
        [Test]
        public static void TranslateWord()
        {
            Console.WriteLine("have ➞ avehay");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateWord("have"), Is.EqualTo("avehay"));
            Console.WriteLine("cram ➞ amcray");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateWord("cram"), Is.EqualTo("amcray"));
            Console.WriteLine("take ➞ aketay");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateWord("take"), Is.EqualTo("aketay"));
            Console.WriteLine("Cat ➞ Atcay");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateWord("Cat"), Is.EqualTo("Atcay"));
            Console.WriteLine("Shrimp ➞ Impshray");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateWord("Shrimp"), Is.EqualTo("Impshray"));
            Console.WriteLine("trebuchet ➞ ebuchettray");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateWord("trebuchet"), Is.EqualTo("ebuchettray"));
            Console.WriteLine("ate ➞ ateyay");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateWord("ate"), Is.EqualTo("ateyay"));
            Console.WriteLine("Apple ➞ Appleyay");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateWord("Apple"), Is.EqualTo("Appleyay"));
            Console.WriteLine("oaken ➞ oakenyay");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateWord("oaken"), Is.EqualTo("oakenyay"));
            Console.WriteLine("eagle ➞ eagleyay");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateWord("eagle"), Is.EqualTo("eagleyay"));
            Console.WriteLine("ink ➞ inkyay");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateWord("ink"), Is.EqualTo("inkyay"));
            Console.WriteLine("unicorn ➞ unicornyay");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateWord("unicorn"), Is.EqualTo("unicornyay"));
            Console.WriteLine("\"\" ➞ \"\"");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateWord(""), Is.EqualTo(""));
        }

        [Test]
        public static void TranslateSentence()
        {
            Console.WriteLine("I like to eat honey waffles ➞ Iyay ikelay otay eatyay oneyhay afflesway");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateSentence("I like to eat honey waffles"), Is.EqualTo("Iyay ikelay otay eatyay oneyhay afflesway"));
            Console.WriteLine("Do you think it is going to rain today? ➞ Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateSentence("Do you think it is going to rain today?"), Is.EqualTo("Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?"));
            Console.WriteLine("He said, \"When will this all end?\" ➞ Ehay aidsay, \"Enwhay illway isthay allyay endyay?\"");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateSentence("He said, \"When will this all end?\""), Is.EqualTo("Ehay aidsay, \"Enwhay illway isthay allyay endyay?\""));
            Console.WriteLine("\"\" ➞ \"\"");
            Assert.That(EnglishToPigLatinTranslatorClass.TranslateSentence(""), Is.EqualTo(""));
        }
    }
}