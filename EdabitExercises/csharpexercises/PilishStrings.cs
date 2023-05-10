class PilishStringsClass
{
    public static string PilishString(string txt)
    {
        if (txt == "")
            return "";

        string pi = "314159265358979";
        string result = "";

        int cursor = 0;
        for (int i = 0; i < pi.Length; i++)
        {
            int piNumber = int.Parse(pi[i].ToString());
            int overflow = 0;

            // Until length limit will be reached
            if ((cursor + piNumber) <= txt.Length)
            {
                // Read piNumber characters and move cursor position
                result += txt.Substring(cursor, piNumber) + " ";
                cursor += piNumber;
            }
            else // When limit reached
            {
                // Append the rest of the txt
                result += txt.Substring(cursor);
                
                // Repeat last character untill last word
                // have the same length as used digit of PI
                overflow = (cursor + piNumber) - txt.Length;
                char charToRepeat = result[result.Length - 1];
                result += RepeatChar(charToRepeat, overflow);

                break;
            }

            // Endpoint normal case
            if (cursor >= txt.Length)
                break;
        }

        return result.TrimEnd();
    }

    private static string RepeatChar(char character, int repeatCount)
    {
        return string.Concat(Enumerable.Repeat(character, repeatCount));
    }
}