// Q4.In this problem you are given a string for example:

// "example(unwanted thing)example"
// Your task is to remove everything inside the parentheses as well as the parentheses themselves.

// The example above would return:

// "exampleexample"

using System;

class Program
{
    static void Main(string[] args)
    {
        string s = "example(unwanted thing)example";
        int startIndex = s.IndexOf('(');
        int endIndex = s.IndexOf(')');
        if (startIndex != -1 && endIndex != -1)
        {
            s = s.Remove(startIndex, endIndex - startIndex + 1);
        }
        Console.WriteLine(s);
    }
}   