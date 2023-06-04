using System.Text.RegularExpressions;

public class SolveALinearEquation
{
    public static string FindX(string equation)
    {
        // Split the equation into left and right sides
        var sides = equation.Split('=');

        // Find coefficients and constants on both sides
        var left = Parse(sides[0]);
        var right = Parse(sides[1]);

        // Transfer all to the left side
        var coef = left.Item1 - right.Item1;
        var cons = right.Item2 - left.Item2;

        // Check the solutions
        if (coef == 0)
        {
            if (cons == 0)
            {
                return "Infinite solutions";
            }
            else
            {
                return "No solution";
            }
        }
        else
        {
            return $"x={Math.Round((double)cons / coef, 2):0.##}";
        }
    }

    private static Tuple<int, int> Parse(string side)
    {
        // Match coefficients and constants
        var matches = Regex.Matches(side, @"([+-]?)(\d*)(x?)");

        // Sum up coefficients and constants
        var coef = matches.Where(m => m.Groups[3].Value == "x")
            .Sum(m => string.IsNullOrEmpty(m.Groups[2].Value) ? (m.Groups[1].Value == "-" ? -1 : 1) : int.Parse(m.Groups[1].Value + m.Groups[2].Value));

        var cons = matches.Where(m => m.Groups[3].Value != "x")
            .Sum(m => string.IsNullOrEmpty(m.Groups[2].Value) ? 0 : int.Parse(m.Groups[1].Value + m.Groups[2].Value));

        return Tuple.Create(coef, cons);
    }
}