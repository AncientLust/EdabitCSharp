public class CenteredHexagonalNumber
{
    public static string HexagonalNumbers(int n = 1)
    {
        if (n == 1)
        {
            return " o ";
        }

        int num = 1, increment = 0;
        while (n > num)
        {
            increment++;
            num += increment * 6;
        }

        if (n != num)
            return "Invalid";

        string hexLattice = "";
        int spaces = increment ;
        int oCount = increment + 1;
        for (int i = 0; i < increment * 2 + 1; i++)
        {
            hexLattice += new string(' ', spaces);
            hexLattice += string.Concat(Enumerable.Repeat(" o", oCount - 1)) + " o";
            hexLattice += new string(' ', spaces) + " \n";

            if (i < increment)
            {
                spaces--;
                oCount++;
            }
            else
            {
                spaces++;
                oCount--;
            }
        }

        return hexLattice.TrimEnd('\n');
    }

}
