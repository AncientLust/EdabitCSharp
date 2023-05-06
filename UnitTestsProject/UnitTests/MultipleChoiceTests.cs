namespace TestingProject
{
    public partial class MultipleChoiceTestsTests
    {
        [Test]
        public static void MultipleChoiceTests()
        {
            var paper1 = new Testpaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
            var paper2 = new Testpaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
            var paper3 = new Testpaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");
            var paper4 = new Testpaper("Physics", new string[] { "1A", "2B", "3A", "4C", "5A", "6C", "7A", "8C", "9D", "10A", "11A" }, "90%");

            var student1 = new Student();
            var student2 = new Student();
            var student3 = new Student();

            Assert.IsTrue(paper1 is ITestpaper, "The Testpaper class does not implement the ITestpaper interface");
            Assert.IsTrue(student1 is IStudent, "The Student class does not implement the IStudent interface");
            Assert.IsFalse(student1 is ITestpaper, "The Student class should not implement the ITestpaper interface");
            Assert.IsFalse(paper1 is IStudent, "The Testpaper class should not implement the IStudent interface");

            Assert.That(new string[] { "No tests taken" }, Is.EqualTo(student1.TestsTaken));
            student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });
            Assert.That(new string[] { "Maths: Passed! (80%)" }, Is.EqualTo(student1.TestsTaken));

            student2.TakeTest(paper2, new string[] { "1C", "2D", "3A", "4C" });
            student2.TakeTest(paper3, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });
            Assert.That(new string[] { "Chemistry: Failed! (25%)", "Computing: Failed! (43%)" }, Is.EqualTo(student2.TestsTaken));

            Assert.That(new string[] { "No tests taken" }, Is.EqualTo(student3.TestsTaken));
            student3.TakeTest(paper1, new string[] { "1C", "2D", "3A", "4C", "5A" });
            student3.TakeTest(paper3, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });
            Assert.That(new string[] { "Computing: Failed! (43%)", "Maths: Failed! (20%)" }, Is.EqualTo(student3.TestsTaken));
            student3.TakeTest(paper4, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B", "8C", "9D", "10A", "11A" });
            Assert.That(new string[] { "Computing: Failed! (43%)", "Maths: Failed! (20%)", "Physics: Failed! (73%)" }, Is.EqualTo(student3.TestsTaken));

            Assert.That(paper1.Subject, Is.EqualTo("Maths"));
            Assert.That(paper2.Subject, Is.EqualTo("Chemistry"));
            Assert.That(paper3.Subject, Is.EqualTo("Computing"));
            Assert.That(paper4.Subject, Is.EqualTo("Physics"));

            Assert.That(new string[] { "1A", "2C", "3D", "4A", "5A" }, Is.EqualTo(paper1.MarkScheme));
            Assert.That(new string[] { "1C", "2C", "3D", "4A" }, Is.EqualTo(paper2.MarkScheme));
            Assert.That(new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, Is.EqualTo(paper3.MarkScheme));
            Assert.That(new string[] { "1A", "2B", "3A", "4C", "5A", "6C", "7A", "8C", "9D", "10A", "11A" }, Is.EqualTo(paper4.MarkScheme));

            Assert.That(paper1.PassMark, Is.EqualTo("60%"));
            Assert.That(paper2.PassMark, Is.EqualTo("75%"));
            Assert.That(paper3.PassMark, Is.EqualTo("75%"));
            Assert.That(paper4.PassMark, Is.EqualTo("90%"));
        }
    }
}