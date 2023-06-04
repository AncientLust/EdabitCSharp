class UnravelAllThePossibilities
{
    public static string[] Unravel(string input)
    {
        var result = new List<string>();
        GenerateCombinations(input, 0, "", result);
        return result.OrderBy(s => s).ToArray();
    }

    private static void GenerateCombinations(string input, int index, string current, List<string> result)
    {
        if (index == input.Length)
        {
            result.Add(current);
            return;
        }

        if (input[index] == '[')
        {
            var endIndex = input.IndexOf(']', index);
            var options = input.Substring(index + 1, endIndex - index - 1).Split('|');

            foreach (var option in options)
            {
                GenerateCombinations(input, endIndex + 1, current + option, result);
            }
        }
        else
        {
            GenerateCombinations(input, index + 1, current + input[index], result);
        }
    }
}