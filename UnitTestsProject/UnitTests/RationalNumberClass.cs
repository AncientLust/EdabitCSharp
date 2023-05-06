namespace TestingProject
{
    public partial class RationalNumberClassTests
    {
        [TestCase(1, 2, ExpectedResult = "1/2")]
        [TestCase(15, 27, ExpectedResult = "5/9")]
        [TestCase(-3, 4, ExpectedResult = "-3/4")]
        [TestCase(-5, -3, ExpectedResult = "5/3")]
        [TestCase(10, 5, ExpectedResult = "2")]
        public static string TestRational_Create(int num, int denom)
        {
            Console.WriteLine($"Create: new Rational({num}, {denom})");
            return new Rational(num, denom).ToString();
        }

        [Test]
        public void TestRational_Create_ThrowsArgumentException()
        {
            int num = 1;
            int denom = 0;
            Console.WriteLine($"Create: new Rational({num}, {denom})");
            Assert.Throws<ArgumentException>(() => new Rational(num, denom));
        }

        [TestCase(1, 2, ExpectedResult = 1)]
        [TestCase(15, 27, ExpectedResult = 5)]
        [TestCase(-3, 4, ExpectedResult = -3)]
        [TestCase(-5, -3, ExpectedResult = 5)]
        [TestCase(10, 5, ExpectedResult = 2)]
        public static int TestRational_Numerator(int num, int denom)
        {
            Console.WriteLine($"Numerator test: new Rational({num}, {denom})");
            return new Rational(num, denom).Numerator;
        }

        [TestCase(1, 2, ExpectedResult = 2)]
        [TestCase(15, 27, ExpectedResult = 9)]
        [TestCase(-3, 4, ExpectedResult = 4)]
        [TestCase(-5, -3, ExpectedResult = 3)]
        [TestCase(10, 5, ExpectedResult = 1)]
        [TestCase(0, 5, ExpectedResult = 1)]
        public static int TestRational_Denominator(int num, int denom)
        {
            Console.WriteLine($"Numerator test: new Rational({num}, {denom})");
            return new Rational(num, denom).Denominator;
        }

        [Test]
        public static void TestRational_Arithmetic()
        {
            var r1 = new Rational(1, 2);
            var r2 = new Rational(10, 8);
            var r3 = new Rational(2, -1);
            var r4 = r1 + r2;
            Assert.That(r4.ToString(), Is.EqualTo("7/4"), "1/2 + 5/4 should equal 7/8");
            Assert.That((r1 * r3).ToString(), Is.EqualTo("-1"), "1/2 * -2 should equal -1");
            Assert.That((r2 - new Rational(-1, 4)).ToString(), Is.EqualTo("3/2"), "5/4 - -1/4 should equal 3/2");
            Assert.That(((r1 + r2) / r3).ToString(), Is.EqualTo("-7/8"), "7/8 ÷ -2 should equal -7/8");
            Assert.That((-r2).ToString(), Is.EqualTo("-5/4"), "Unary minus should invert sign");
            Assert.That((+r3).ToString(), Is.EqualTo("-2"), "Unary plus should not invert sign");
            Assert.That((new Rational(157, 251) / new Rational(27, 191)).ToString(), Is.EqualTo("29987/6777"), "157/251 ÷ 27/191 should equal 29987/6777");
            Assert.That(r3.Sign, Is.EqualTo(-1), "The Sign of -1/2 should equal -1");
        }

        [Test]
        public static void TestRational_Comaparisons()
        {
            var r1 = new Rational(1, 2);
            var r2 = new Rational(10, 8);
            var r3 = new Rational(2, -1);
            var r4 = new Rational(3, 4);
            var r5 = new Rational(16393, 2500);
            var r6 = (Rational)13.34m;
            decimal d = r1;
            Assert.That(r1 == (r2 - r4), Is.EqualTo(true), "1/2 should equal 5/4 - 3/4");
            Assert.That(r1 != -r1, Is.EqualTo(true), "1/2 should not equal -1/2");
            Assert.That(r2 > r1, Is.EqualTo(true), "5/4 should be greater than 1/2");
            Assert.That(r1 <= r3, Is.EqualTo(false), "1/2 should not be less than or equal to -2");
            Assert.That(r1 >= new Rational(4, 8), Is.EqualTo(true), "1/2 should be greater than or equal to 1/2");
            Assert.That(r1 < r3, Is.EqualTo(false), "1/2 should not be less than -2");
            Assert.That(r5 == 6.5572m, Is.EqualTo(true), "16393/2500 should equal 6.5572 decimal (implicit conversion)");
            Assert.That(d == 0.5m, Is.EqualTo(true), "Should be able to assign Rational to decimal variable (implicit conversion)");
            Assert.That(r6 == new Rational(667, 50), Is.EqualTo(true), "Should be able to explicitly convert decimal to Rational: (Rational)13.34m");
        }
    }
}