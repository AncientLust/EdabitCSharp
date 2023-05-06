using System.Collections.Generic;
using System.Linq;

class PalindromeDescendantClass
{
    public static bool PalindromeDescendant(int num)
    {
        string stringNumber = num.ToString();
        int numberLength = stringNumber.Length;

        // A 1-digit number is trivially a palindrome
        if (numberLength == 1)
        {
            return true;
        }

        // Finite case for the recursion
        if (numberLength == 2)
        {
            return IsPalindrome(num);
        }

        // Collapse only even number of digits
        if (numberLength % 2 != 0)
        {
            return IsPalindrome(num);
        }

        // Collapse each pair of numbers
        List<int> collapsedNumbers = new List<int>();
        for (int i = 0; i < numberLength; i += 2)
        {
            int num1 = stringNumber[i] - '0';
            int num2 = stringNumber[i + 1] - '0';
            collapsedNumbers.Add((num1 + num2));
        }

        // Collapsed result
        string stringDescendant = string.Join("", collapsedNumbers);
        int intDescendant = int.Parse(stringDescendant);

        if (stringDescendant.Length > 2)
        {
            return PalindromeDescendant(intDescendant);
        }
        else
        {
            return IsPalindrome(intDescendant);
        }

    }

    private static bool IsPalindrome(int num)
    {
        string inputNumber = num.ToString();
        string invertedNumber = new string(inputNumber.Reverse().ToArray());
        return inputNumber == invertedNumber;
    }
}