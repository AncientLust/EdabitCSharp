using System.Text;

class RationalNumber
{
    public static string Rational(int a, int b)
    {
        StringBuilder sb = new StringBuilder();
        int quotient = a / b;
        int remainder = a % b;

        sb.Append(quotient);
        sb.Append(".");

        Dictionary<int, int> remainderIndices = new Dictionary<int, int>();

        while (remainder != 0 && !remainderIndices.ContainsKey(remainder))
        {
            remainderIndices[remainder] = sb.Length;
            remainder *= 10;
            quotient = remainder / b;
            sb.Append(quotient);
            remainder = remainder % b;
        }

        if (remainder != 0)
        {
            int index = remainderIndices[remainder];
            sb.Insert(index, "(");
            sb.Append(")");
        }

        return sb.ToString();
    }
}