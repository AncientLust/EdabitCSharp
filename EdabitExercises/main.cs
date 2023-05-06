using NUnit.Framework;

public class Program
{

    static void Main(string[] args)
    {
        //Console.WriteLine(PointWithinTriangle.WithinTriangle(new int[] { 1, 4 }, new int[] { 5, 6 }, new int[] { 6, 1 }, new int[] { 4, 5 }));
        Console.WriteLine(PointWithinTriangle.WithinTriangle(new int[] { -6, 2 }, new int[] { -2, -2 }, new int[] { 8, 4 }, new int[] { 0, -4 }));
    }
}