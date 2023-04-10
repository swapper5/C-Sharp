using System;
public class Program {
    public static int AddSubtractIntegers(string[] arr) {
        int sum = 0;
        foreach (string s in arr) {
            if (int.TryParse(s, out int num)) {
                sum += num;
            } else {
                sum -= 0;
            }
        }
        return sum;
    }
    public static void Main(string[] args) {
        string[] arr = {"1", "2", "3", "four", "5"};
        int result = AddSubtractIntegers(arr);
        Console.WriteLine($"Result: {result}"); 
    }
}