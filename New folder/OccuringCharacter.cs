using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "aba";
        var charCount = new System.Collections.Hashtable();

        foreach (char c in str)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c] = (int)charCount[c] + 1;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        Console.WriteLine("{ " + string.Join(", ", GetCharCount(charCount)) + " }");
    }

    static string[] GetCharCount(System.Collections.Hashtable charCount)
    {
        var result = new string[charCount.Count];
        int i = 0;
        foreach (char key in charCount.Keys)
        {
            result[i++] = $"'{key}': {charCount[key]}";
        }
        return result;
    }
}
