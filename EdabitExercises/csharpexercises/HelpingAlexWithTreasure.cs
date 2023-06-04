class HelpingAlexWithTreasure
{
    public static int Solve(int[] boxes)
    {
        int n = boxes.Length;
        int[,] dp = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            dp[i, i] = boxes[i];
        }

        for (int length = 2; length <= n; length++)
        {
            for (int i = 0; i <= n - length; i++)
            {
                int j = i + length - 1;
                dp[i, j] = Math.Max(boxes[i] - dp[i + 1, j], boxes[j] - dp[i, j - 1]);
            }
        }
        return dp[0, n - 1];
    }

}