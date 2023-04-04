// Q1 . Trolls are attacking your comment section!
// A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
// Your task is to write a program that takes a string and return a new string with all vowels removed.
// For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

using System;

class Program {
    static void Main() {
        string input = "This website is for losers LOL!";
        string output = RemoveVowels(input);
        Console.WriteLine(output);
    }

    static string RemoveVowels(string input) {
        string vowels = "AEIOUaeiou";
        string output = "";
        foreach (char c in input) {
            if (!vowels.Contains(c.ToString())) {
                output += c;
            }
        }
        return output;
    }
}