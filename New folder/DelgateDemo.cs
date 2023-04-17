using System;

namespace DelegateDemo
{
    class Program
    {
        delegate void PrintAgeDelegate(int age);

        static void Main(string[] args)
        {
            PrintAgeDelegate printAge = delegate (int age)
            {
                Console.WriteLine($"You are {age} years old.");
            };


            int age = 18;

            
            printAge(age);
        }
    }
}
