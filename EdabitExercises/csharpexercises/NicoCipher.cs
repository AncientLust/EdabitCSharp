class NicoCipherClass
{
    public static string NicoCipher(string message, string key)
    {
        // Rank each char in key, with incremeneting of duplicated chars
        List<int> charCodes = RankCharsInKey(key);

        // Assign numbers to the letters of the given message
        Dictionary<int, string> keyCharsDict = new Dictionary<int, string>();       
        for (int i = 0; i < message.Count(); i++)
        {
            int keyIndex = i % charCodes.Count;

            if (keyCharsDict.ContainsKey(charCodes[keyIndex]))
            {
                keyCharsDict[charCodes[keyIndex]] = keyCharsDict[charCodes[keyIndex]] + message[i].ToString();
            }
            else
            {
                keyCharsDict[charCodes[keyIndex]] = message[i].ToString();
            }
        }

        // Append trailing spaces
        int tableWidth = (int)Math.Ceiling((float)message.Length / charCodes.Count);
        foreach (KeyValuePair<int, string> entry in keyCharsDict) 
        {
            if (keyCharsDict[entry.Key].Length < tableWidth)
            {
                keyCharsDict[entry.Key] += " ";
            }
        }

        // Sort columns as per assigned numbers
        keyCharsDict = keyCharsDict.OrderBy(entry => entry.Key).ToDictionary(entry => entry.Key, entry => entry.Value);

        //  Return encoded message Rows-wise
        string result = "";
        for (int i = 0; i < tableWidth; i++)
        {
            for (int j = 1; j <= charCodes.Count; j++)
            {
                result += keyCharsDict[j][i];
            }
        }

        return result;
    }

    private static List<int> RankCharsInKey(string key)
    {
        // Chars might be duplicated, so we use the loop 
        // to increment each second occurrence of the same char
        List<int> charCodes = key.Select(c => (int)c).ToList();
        for (int i = 0; i < charCodes.Count; i++)
        {
            for (int j = 0; j < charCodes.Count; j++)
            {
                if (i == j)
                {
                    continue;
                }

                if (charCodes[j] >= charCodes[i])
                {
                    charCodes[j]++;
                }
            }
        }

        // Rank the codes 
        return  charCodes.Select(x => charCodes.Count(y => y < x) + 1).ToList();
    }
}