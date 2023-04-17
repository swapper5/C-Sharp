using System;

namespace OutDemo
{
    class Program
    {
        static void GetValues(out int num1, out int num2)
        {
            num1 = 10;
            num2 = 20;
        }
        static void Main(string[] args)
        {
            int num1, num2;

            
            GetValues(out num1, out num2);
            Console.WriteLine($"num1: {num1}, num2: {num2}");
        }

        
    }
}
