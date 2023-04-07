using System;

class Program
{
    static void Main(string[] args)
    {
        object[] arr = { 1, "2", "3", 4, "5" };
        int sum = 0;

        foreach (object item in arr)
        {
            if (item.GetType() == typeof(int))
            {
                sum += (int)item;
            }
            else if (item.GetType() == typeof(string))
            {
                int number;
                bool isNumber = int.TryParse((string)item, out number);
                if (isNumber)
                {
                    sum -= number;
                }
            }
        }

        Console.WriteLine(sum);
    }
}
