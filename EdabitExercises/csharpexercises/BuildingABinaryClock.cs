public class BuildingABinaryClock
{
    /*
    Example Usage:
    BinaryClock("10:37:49") ➞ new string[] {
        " 0 0 1",
        " 00110",
        "001100",
        "101101"
    }
    */

    public static string[] BinaryClock(string time)
    {
        // Replaces the ":" characters from the time string
        time = time.Replace(":", "");

        // Converts each character of the time string into a digit and stores them in a list
        List<int> digits = time.Select(digit => int.Parse(digit.ToString())).ToList();

        List<string> binaryDigits = new List<string>();
        for (int i = 0; i < digits.Count; i++)
        {
            // Calculate required padding for binary string representation
            int padLeft = 4;
            if (i == 0) padLeft = 2;
            if (i == 2 || i == 4) padLeft = 3;

            // Converts each digit to its binary representation
            string binaryDigit = Convert.ToString(digits[i], 2);

            // Pads the binary string from the left with '0' to meet the required length
            binaryDigit = binaryDigit.PadLeft(padLeft, '0');

            // Pads the binary string from the left with ' ' to ensure all binary strings have length of 4
            binaryDigit = binaryDigit.PadLeft(4, ' ');

            binaryDigits.Add(binaryDigit);
        }

        // Transpose the binary digit matrix to match the clock's format
        List<string> resultLines = new List<string>();
        for (int i = 0; i < 4; i++)
        {
            string line = "";
            for (int j = 0; j < binaryDigits.Count; j++)
            {
                // Adds the ith character of each binary string to form a line of the clock
                line += binaryDigits[j][i];
            }

            resultLines.Add(line);
        }

        return resultLines.ToArray();
    }
}
