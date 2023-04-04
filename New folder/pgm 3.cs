// Q3. Given a string s. You have to return another string such that even-indexed and odd-indexed characters of s are grouped and groups are space-separated (see sample below)
// LogixHealth
// Lgxelh oiHat

using System;

public class Program {
    public static void Main() {
        string s = "LogixHealth";
        string result = "";

        for (int i = 0; i < s.Length; i++) {
            if (i % 2 == 0) {
                result += s[i];
            } else {
                result += " " + s[i];
            }
        }

        Console.WriteLine("The original string is: " + s);
        Console.WriteLine("The modified string is: " + result);
    }
}