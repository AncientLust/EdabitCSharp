﻿namespace TestingProject
{
    public partial class SolveForTheRedAreaTests
    {
        [TestCase(25, ExpectedResult = 48.906d)]
        [TestCase(94, ExpectedResult = 691.412d)]
        [TestCase(36, ExpectedResult = 101.411d)]
        [TestCase(42, ExpectedResult = 138.032d)]
        [TestCase(39, ExpectedResult = 119.017d)]
        [TestCase(36, ExpectedResult = 101.411d)]
        [TestCase(28, ExpectedResult = 61.348d)]
        [TestCase(33, ExpectedResult = 85.214d)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(68, ExpectedResult = 361.825d)]
        [TestCase(15, ExpectedResult = 17.606d)]
        [TestCase(55, ExpectedResult = 236.705d)]
        [TestCase(9, ExpectedResult = 6.338d)]
        [TestCase(67, ExpectedResult = 351.262d)]
        [TestCase(4, ExpectedResult = 1.252d)]
        [TestCase(30, ExpectedResult = 70.425d)]
        [TestCase(99, ExpectedResult = 766.923d)]
        [TestCase(28, ExpectedResult = 61.348d)]
        [TestCase(48, ExpectedResult = 180.287d)]
        [TestCase(13, ExpectedResult = 13.224d)]
        [TestCase(76, ExpectedResult = 451.969d)]
        [TestCase(3, ExpectedResult = 0.704d)]
        [TestCase(33, ExpectedResult = 85.214d)]
        [TestCase(37, ExpectedResult = 107.123d)]
        [TestCase(13, ExpectedResult = 13.224d)]
        [TestCase(14, ExpectedResult = 15.337d)]
        [TestCase(71, ExpectedResult = 394.455d)]
        [TestCase(60, ExpectedResult = 281.698d)]
        [TestCase(8, ExpectedResult = 5.008d)]
        [TestCase(70, ExpectedResult = 383.422d)]
        [TestCase(92, ExpectedResult = 662.303d)]
        [TestCase(29, ExpectedResult = 65.808d)]
        [TestCase(1, ExpectedResult = 0.078d)]
        [TestCase(17, ExpectedResult = 22.614d)]
        [TestCase(34, ExpectedResult = 90.456d)]
        [TestCase(20, ExpectedResult = 31.3d)]
        [TestCase(31, ExpectedResult = 75.198d)]
        [TestCase(14, ExpectedResult = 15.337d)]
        [TestCase(97, ExpectedResult = 736.249d)]
        [TestCase(62, ExpectedResult = 300.791d)]
        [TestCase(37, ExpectedResult = 107.123d)]
        [TestCase(46, ExpectedResult = 165.576d)]
        [TestCase(65, ExpectedResult = 330.604d)]
        [TestCase(77, ExpectedResult = 463.941d)]
        [TestCase(50, ExpectedResult = 195.624d)]
        [TestCase(78, ExpectedResult = 476.07d)]
        [TestCase(93, ExpectedResult = 676.779d)]
        [TestCase(38, ExpectedResult = 112.992d)]
        [TestCase(51, ExpectedResult = 203.527d)]
        [TestCase(28, ExpectedResult = 61.348d)]
        public static double TestRedArea(int r)
        {
            Console.WriteLine($"Input: n={r}");
            return SolveForTheRedArea.RedArea(r);
        }
    }
}