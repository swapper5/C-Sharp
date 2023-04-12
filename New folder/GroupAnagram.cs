using System;
using System.Collections.Generic;

public class AnagramGrouper {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

        
        foreach (string str in strs) {
         
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string canonicalForm = new string(chars);

          
            if (!anagramGroups.ContainsKey(canonicalForm)) {
                anagramGroups[canonicalForm] = new List<string>();
            }
            anagramGroups[canonicalForm].Add(str);
        }

        
        return new List<IList<string>>(anagramGroups.Values);
    }
}

public class Program {
    public static void Main(string[] args) {
        AnagramGrouper grouper = new AnagramGrouper();

        string[] strs1 = { "eat", "tea", "tan", "ate", "nat", "bat" };
        IList<IList<string>> groups1 = grouper.GroupAnagrams(strs1);
        PrintGroups(groups1);

        
    }

    public static void PrintGroups(IList<IList<string>> groups) {
        Console.Write("[ ");
        foreach (IList<string> group in groups) {
            Console.Write("[ ");
            foreach (string str in group) {
                Console.Write(str + " ");
            }
            Console.Write("]");
        }
        Console.WriteLine("]");
    }
}
