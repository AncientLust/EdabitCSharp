using NUnit.Framework;

public class Program
{

    static void Main(string[] args)
    {

        var result = RotateTransformTheTwoDimensionalMatrix.RotateTransform(new int[2, 2]
            {
            { 2, 4 },
            { 0, 0 }}, -1);


        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}