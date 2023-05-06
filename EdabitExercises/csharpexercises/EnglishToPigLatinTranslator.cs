using System.Text.RegularExpressions;

class EnglishToPigLatinTranslatorClass
{
    private static bool IsFirstCharVovel(string word)
    {
        char[] vovels = { 'a', 'e', 'i', 'o', 'u' };
        return vovels.Contains(char.ToLower(word[0])) ? true : false;
    }

    static bool IsWord(string input)
    {
        return !string.IsNullOrEmpty(input) && input.All(char.IsLetter);
    }

    public static string TranslateWord(string word)
    {
        // Word can be empty
        if (string.IsNullOrEmpty(word))
        {
            return "";
        }
        
        bool startedWithCapital = char.IsUpper(word[0]);

        if (!IsFirstCharVovel(word))
        {
            //Rotate the word untill first letter is a vovel
            string appendix = "";
            while (!IsFirstCharVovel(word))
            {
                appendix += char.ToLower(word[0]);
                word = word.Substring(1);
            }

            word = word + appendix + "ay";
        }
        else
        {
            word = word + "yay";
        }

        if (startedWithCapital)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }
        else
        {
            return word;
        }
    }

    public static string TranslateSentence(string sentence)
    {
        // Split the input by spaces and punctuation marks
        string[] parts = Regex.Split(sentence, @"(\s+|[.,!?;:""])");
        string[] processedParts = parts.Select(part => IsWord(part) ? TranslateWord(part) : part).ToArray();
        return string.Join("", processedParts);
    }
}