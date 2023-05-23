using System.Text.RegularExpressions;

public class SentencePrimenessClass
{
    public static string SentencePrimeness(string sentence)
    {
        // Filter our in the sentence non-alphanumeric values
        Regex regex = new Regex("[^a-zA-Z0-9 ]");
        sentence = regex.Replace(sentence, "");

        // Calculate the sum of the sentence
        int sum = CalculateSentenceSum(sentence);

        // If sum is prime return smthng
        if (IsPrime(sum)) return "Prime Sentence";
        
        // Split the sentence by spaces
        List<string> words = sentence.Split(' ').ToList();
        foreach (string word in words)
        {
            sum = CalculateSentenceSum(sentence.Replace(word, ""));
            if (IsPrime(sum)) return $"Almost Prime Sentence ({word})";
        }

        return "Composite Sentence";
    }

    private static int CalculateSentenceSum(string sentence)
    {
        // Filter out spaces
        sentence = sentence.Replace(" ", "");

        int sum = 0;
        foreach (char c in sentence)
        {
            if (char.IsLetter(c))
            {
                // Convert letter to its corresponding value
                int letterValue = char.ToLower(c) - 'a' + 1;
                sum += letterValue;
            }
            else if (char.IsDigit(c))
            {
                // Convert digit to its literal value
                int digitValue = c - '0';
                sum += digitValue;
            }
        }

        return sum;
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        if (number == 2)
            return true;

        if (number % 2 == 0)
            return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}