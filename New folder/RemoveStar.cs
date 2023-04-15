using System;
using System.Text;

public class StarRemover {
    public string RemoveStars(string s) {
        int n = s.Length;
        char[] arr = s.ToCharArray();

        for (int i = 0; i < n; i++) {
            if (arr[i] == '*') {
                int j = i - 1;
                while (j >= 0 && arr[j] == '*') {
                    j--;
                }
                if (j >= 0) {
                    arr[j] = '*';
                    arr[i] = '*';
                }
            }
        }

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++) {
            if (arr[i] != '*') {
                sb.Append(arr[i]);
            }
        }

        return sb.ToString();
    }
}

public class Program {
    public static void Main(string[] args) {
        StarRemover remover = new StarRemover();

        string s1 = "Logix*Hea*th";
        string result1 = remover.RemoveStars(s1);
        Console.WriteLine("Input: {0}\nOutput: {1}\n", s1, result1);

        string s2 = "erase*****";
        string result2 = remover.RemoveStars(s2);
        Console.WriteLine("Input: {0}\nOutput: {1}\n", s2, result2);

        string s3 = "abc*def*g";
        string result3 = remover.RemoveStars(s3);
        Console.WriteLine("Input: {0}\nOutput: {1}\n", s3, result3);
    }
}
