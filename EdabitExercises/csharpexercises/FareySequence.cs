class FareySequence
{
    public static string[] Farey(int n)
    {
  
        List<Fraction> fracions = new List<Fraction>();
        fracions.Add(new Fraction(0, 1));

        // Gather all fractions
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                // Skip whole numbers
                if (i % j != 0 && (float)i / j < 1)
                {
                    int gcd = GCD(i, j);
                    fracions.Add(new Fraction(i / gcd, j / gcd));
                }
            }
        }

        fracions.Add(new Fraction(1, 1));

        // Sort the list
        fracions = fracions.OrderBy(x => ((float)x.Num / x.Den)).ToList();

        // Cast to list of strings
        string[] strings = fracions.Select(x => x.ToString()).Distinct().ToArray();

        return strings;
    }

    private struct Fraction
    {
        public int Num { get; private set; }
        public int Den { get; private set; }

        public Fraction(int num, int den)
        {
            Num = num;
            Den = den;
        }

        override public string ToString()
        {
            return Num.ToString() + '/' + Den.ToString();
        }
    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
}