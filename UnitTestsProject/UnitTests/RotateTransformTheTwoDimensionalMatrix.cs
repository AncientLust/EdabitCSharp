namespace TestingProject
{
    public partial class RotateTransformTheTwoDimensionalMatrixTests
    {
        [Test]

        public static void TestRotateTransform()
        {
            System.Console.WriteLine("Test #1 of 10");

            Assert.That(new int[2, 2]
            {
            { 0, 2 },
            { 0, 4 }}, Is.EqualTo(RotateTransformTheTwoDimensionalMatrix.RotateTransform(new int[2, 2]
            {
            { 2, 4 },
            { 0, 0 }}, 1)));

            System.Console.WriteLine("Test #2 of 10");

            Assert.That(new int[2, 2]
            {
            { 4, 0 },
            { 2, 0 }}, Is.EqualTo(RotateTransformTheTwoDimensionalMatrix.RotateTransform(new int[2, 2]
            {
            { 2, 4 },
            { 0, 0 }}, -1)));

            System.Console.WriteLine("Test #3 of 10");

            Assert.That(new int[4, 4]
            {
            { 1, 7, 0, 0 },
            { 5, 3, 0, 0 },
            { 0, 0, 8, 2 },
            { 0, 0, 4, 1 }}, Is.EqualTo(RotateTransformTheTwoDimensionalMatrix.RotateTransform(new int[4, 4]
            {
            { 1, 4, 0, 0 },
            { 2, 8, 0, 0 },
            { 0, 0, 3, 5 },
            { 0, 0, 7, 1 }}, 2)));

            System.Console.WriteLine("Test #4 of 10");

            Assert.That(new int[4, 4]
            {
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 },
            { 4, 3, 1, 2 },
            { 2, 1, 3, 4 }}, Is.EqualTo(RotateTransformTheTwoDimensionalMatrix.RotateTransform(new int[4, 4]
            {
            { 4, 3, 1, 2 },
            { 2, 1, 3, 4 },
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 }}, -2)));

            System.Console.WriteLine("Test #5 of 10");

            Assert.That(new int[6, 6]
            {
            { 0, 0, 0, 5, 1, 2 },
            { 0, 0, 0, 3, 7, 3 },
            { 0, 0, 0, 2, 1, 5 },
            { 4, 2, 1, 0, 0, 0 },
            { 3, 8, 3, 0, 0, 0 },
            { 1, 2, 4, 0, 0, 0 }}, Is.EqualTo(RotateTransformTheTwoDimensionalMatrix.RotateTransform(new int[6, 6]
            {
            { 2, 3, 5, 0, 0, 0 },
            { 1, 7, 1, 0, 0, 0 },
            { 5, 3, 2, 0, 0, 0 },
            { 0, 0, 0, 1, 3, 4 },
            { 0, 0, 0, 2, 8, 2 },
            { 0, 0, 0, 4, 3, 1 }}, 5)));

            System.Console.WriteLine("Test #6 of 10");

            Assert.That(new int[6, 6]
            {
            { 0, 0, 0, 4, 2, 1 },
            { 0, 0, 0, 3, 8, 3 },
            { 0, 0, 0, 1, 2, 4 },
            { 5, 1, 2, 0, 0, 0 },
            { 3, 7, 3, 0, 0, 0 },
            { 2, 1, 5, 0, 0, 0 }}, Is.EqualTo(RotateTransformTheTwoDimensionalMatrix.RotateTransform(new int[6, 6]
            {
            { 2, 3, 5, 0, 0, 0 },
            { 1, 7, 1, 0, 0, 0 },
            { 5, 3, 2, 0, 0, 0 },
            { 0, 0, 0, 1, 3, 4 },
            { 0, 0, 0, 2, 8, 2 },
            { 0, 0, 0, 4, 3, 1 }}, 3)));

            System.Console.WriteLine("Test #7 of 10");

            Assert.That(new int[8, 8]
            {
            { 0, 0, 7, 7, 1, 1, 7, 7 },
            { 0, 0, 7, 7, 1, 1, 7, 7 },
            { 0, 0, 0, 0, 7, 7, 1, 1 },
            { 0, 0, 0, 0, 7, 7, 1, 1 },
            { 3, 3, 4, 4, 0, 0, 7, 7 },
            { 3, 3, 4, 4, 0, 0, 7, 7 },
            { 1, 1, 2, 2, 0, 0, 0, 0 },
            { 1, 1, 2, 2, 0, 0, 0, 0 }}, Is.EqualTo(RotateTransformTheTwoDimensionalMatrix.RotateTransform(new int[8, 8]
            {
            { 1, 1, 3, 3, 0, 0, 0, 0 },
            { 1, 1, 3, 3, 0, 0, 0, 0 },
            { 2, 2, 4, 4, 0, 0, 7, 7 },
            { 2, 2, 4, 4, 0, 0, 7, 7 },
            { 0, 0, 0, 0, 7, 7, 1, 1 },
            { 0, 0, 0, 0, 7, 7, 1, 1 },
            { 0, 0, 7, 7, 1, 1, 7, 7 },
            { 0, 0, 7, 7, 1, 1, 7, 7 }}, -5)));

            System.Console.WriteLine("Test #8 of 10");

            Assert.That(new int[8, 8]
            {
            { 1, 1, 3, 3, 0, 0, 0, 0 },
            { 1, 1, 3, 3, 0, 0, 0, 0 },
            { 2, 2, 4, 4, 0, 0, 7, 7 },
            { 2, 2, 4, 4, 0, 0, 7, 7 },
            { 0, 0, 0, 0, 7, 7, 1, 1 },
            { 0, 0, 0, 0, 7, 7, 1, 1 },
            { 0, 0, 7, 7, 1, 1, 7, 7 },
            { 0, 0, 7, 7, 1, 1, 7, 7 }}, Is.EqualTo(RotateTransformTheTwoDimensionalMatrix.RotateTransform(new int[8, 8]
            {
            { 1, 1, 3, 3, 0, 0, 0, 0 },
            { 1, 1, 3, 3, 0, 0, 0, 0 },
            { 2, 2, 4, 4, 0, 0, 7, 7 },
            { 2, 2, 4, 4, 0, 0, 7, 7 },
            { 0, 0, 0, 0, 7, 7, 1, 1 },
            { 0, 0, 0, 0, 7, 7, 1, 1 },
            { 0, 0, 7, 7, 1, 1, 7, 7 },
            { 0, 0, 7, 7, 1, 1, 7, 7 }}, 4)));

            System.Console.WriteLine("Test #9 of 10");

            Assert.That(new int[4, 4]
            {
            { 0, 0, 0, 0 },
            { 0, 3, 3, 0 },
            { 0, 3, 3, 0 },
            { 0, 0, 0, 0 }}, Is.EqualTo(RotateTransformTheTwoDimensionalMatrix.RotateTransform(new int[4, 4]
            {
            { 0, 0, 0, 0 },
            { 0, 3, 3, 0 },
            { 0, 3, 3, 0 },
            { 0, 0, 0, 0 }}, -3)));

            System.Console.WriteLine("Test #10 of 10");

            Assert.That(new int[4, 4]
            {
            { 3, 7, 1, 2 },
            { 7, 3, 2, 1 },
            { 1, 2, 3, 7 },
            { 2, 1, 7, 3 }
            }, Is.EqualTo(RotateTransformTheTwoDimensionalMatrix.RotateTransform(new int[4, 4]
            {
            { 3, 7, 1, 2 },
            { 7, 3, 2, 1 },
            { 1, 2, 3, 7 },
            { 2, 1, 7, 3 }}, -4)));
        }
    }
}