using System.Collections.Generic;

class ThrowingAmountOfDarts
{
    public static string[] DartsSolver(int[] sections, int darts, int target)
    {
        List<List<int>> permutations = GeneratePermutations(sections.ToList(), darts);
        List<string> result = new List<string>();
        foreach (var item in permutations)
        {
            if (item.Sum() == target)
            {
                List<int> sortedItem = new List<int>(item);
                sortedItem.Sort();

                result.Add(string.Join('-', sortedItem.ConvertAll(num => num.ToString())));
            }
        }

        return result.Distinct().ToArray();
    }

    static List<List<int>> GeneratePermutations(List<int> numbers, int permLength)
    {
        List<List<int>> permutations = new List<List<int>>();
        GeneratePermutations(numbers, permLength, new List<int>(), permutations, new HashSet<List<int>>());
        return permutations;
    }

    static void GeneratePermutations(List<int> numbers, int permLength, List<int> currentPerm, List<List<int>> permutations, HashSet<List<int>> seenPermutations)
    {
        if (currentPerm.Count == permLength)
        {
            if (!seenPermutations.Contains(currentPerm))
            {
                permutations.Add(new List<int>(currentPerm));
                seenPermutations.Add(new List<int>(currentPerm));
            }
            return;
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            currentPerm.Add(numbers[i]);
            GeneratePermutations(numbers, permLength, currentPerm, permutations, seenPermutations);
            currentPerm.RemoveAt(currentPerm.Count - 1);
        }
    }
}