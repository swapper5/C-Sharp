using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        string[] ops = new string[] {"5", "-2", "4", "C", "D", "9", "+", "+"};
        int totalScore = CalculateScore(ops);
        Console.WriteLine("Total score: " + totalScore);
    }

    static int CalculateScore(string[] operations) {
        Stack<int> stack = new Stack<int>();
        int sum = 0;

        foreach (string op in operations) {
            if (op == "C") {
                sum -= stack.Pop();
            } else if (op == "D") {
                int prev = stack.Peek();
                int curr = prev * 2;
                stack.Push(curr);
                sum += curr;
            } else if (op == "+") {
                int prev = stack.Pop();
                int curr = prev + stack.Peek();
                stack.Push(prev);
                stack.Push(curr);
                sum += curr;
            } else {
                int curr = int.Parse(op);
                stack.Push(curr);
                sum += curr;
            }
        }

        return sum;
    }
}
