public class RotateTransformTheTwoDimensionalMatrix
{
    public static int[,] RotateTransform(int[,] arr, int num)
    {
        for (int i = 0; i < Math.Abs(num); i++)
        {
            arr = num < 0 ? RotateMatrix(arr, false) : RotateMatrix(arr, true);
        }

        return arr;
    }

    private static int[,] RotateMatrix(int[,] arr, bool clockwise)
    {
        int N = arr.GetLength(0);

        // Consider all squares one by one
        for (int x = 0; x < N / 2; x++)
        {
            // Consider elements in group of 4 in current square
            for (int y = x; y < N - x - 1; y++)
            {
                if (clockwise)
                {
                    // Store current cell in temp variable
                    int temp = arr[x, y];

                    // Move values from left to top
                    arr[x, y] = arr[N - 1 - y, x];

                    // Move values from bottom to left
                    arr[N - 1 - y, x] = arr[N - 1 - x, N - 1 - y];

                    // Move values from right to bottom
                    arr[N - 1 - x, N - 1 - y] = arr[y, N - 1 - x];

                    // Assign temp to right
                    arr[y, N - 1 - x] = temp;
                }
                else
                {
                    // Store current cell in temp variable
                    int temp = arr[x, y];

                    // Move values from right to top
                    arr[x, y] = arr[y, N - 1 - x];

                    // Move values from bottom to right
                    arr[y, N - 1 - x] = arr[N - 1 - x, N - 1 - y];

                    // Move values from left to bottom
                    arr[N - 1 - x, N - 1 - y] = arr[N - 1 - y, x];

                    // Assign temp to left
                    arr[N - 1 - y, x] = temp;
                }
            }
        }

        return arr;
    }
}