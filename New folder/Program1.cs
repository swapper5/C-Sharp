using System;

public class MillipedeWords
{
    public static bool CanJoinWords(string[] words)
    {
        if (words.Length < 3 || words.Length > 7)
        {
            return false;
        }

        bool[] used = new bool[words.Length];
        used[0] = true;

        for (int i = 0; i < words.Length - 1; i++)
        {
            string current = words[i];
            string next = null;

            for (int j = 1; j < words.Length; j++)
            {
                if (!used[j] && current[current.Length - 1] == words[j][0])
                {
                    next = words[j];
                    used[j] = true;
                    break;
                }
            }

            if (next == null)
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        string[] set1 = { "excavate", "endure", "desire", "screen", "theater", "excess", "night" };
        Console.WriteLine(CanJoinWords(set1)); // True

        string[] set2 = { "trade", "pole", "view", "grave", "ladder", "mushroom", "president" };
        Console.WriteLine(CanJoinWords(set2)); // False
    }
}
