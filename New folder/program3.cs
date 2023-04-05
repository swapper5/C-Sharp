using System;

public class Program {
    public static void Main() {
        Console.Write("Enter a credit card number: ");
        string cardNumber = Console.ReadLine();

        string maskedNumber = MaskCreditCard(cardNumber);
        Console.WriteLine("Masked card number: " + maskedNumber);
    }

    public static string MaskCreditCard(string number) {
        int length = number.Length;
        if (length <= 4) {
            return number;
        }
        else {
            return new String('#', length-4) + number.Substring(length-4);
        }
    }
}
