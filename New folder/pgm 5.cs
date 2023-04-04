// Q3. For a given string s find the character c (or C) with longest consecutive repetition and return:

// (c, l)
// where l (or L) is the length of the repetition. If there are two or more characters with the same l return the first in order of appearance.

// For empty string return:

// ('', 0)

using System;

class LongestConsecutiveChar
{
    public static char FindLongestConsecutiveChar(string s)
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

        return maxChar;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string s = "aabbbbcccddddd";
        char maxChar = LongestConsecutiveChar.FindLongestConsecutiveChar(s);

        Console.WriteLine($"The character '{maxChar}' has the longest consecutive repetition.");
    }
}