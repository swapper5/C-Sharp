
using System;

class Program
{
    static void Main()
    {
        bool[] doors = new bool[100];
        for (int pass = 1; pass <= 100; pass++)
        {
            for (int door = pass - 1; door < 100; door += pass)
            {
                doors[door] = !doors[door];
            }
        }

        foreach (bool doorState in doors)
        {
            Console.WriteLine(doorState ? "@" : "#");
        }


    }
}