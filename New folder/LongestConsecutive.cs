using System;

class LongestConsecutiveChar
{
    public static (char, int) FindLongestConsecutiveChar(string s)
    {
        char prevChar = s[0];
        int maxCount = 1;
        int count = 1;
        char maxChar = prevChar;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == prevChar)
            {
                count++;
                if (count > maxCount)
                {
                    maxCount = count;
                    maxChar = prevChar;
                }
            }
            else
            {
                count = 1;
                prevChar = s[i];
            }
        }

        return (maxChar, maxCount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string s = "aabbbbcccddddd";
        (char maxChar, int maxCount) = LongestConsecutiveChar.FindLongestConsecutiveChar(s);

        Console.WriteLine($"The character '{maxChar}' has the longest consecutive repetition of {maxCount}.");
    }
}