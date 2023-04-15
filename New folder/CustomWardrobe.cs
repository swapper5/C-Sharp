using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<List<int>> GetAllCombinations(int[] sizes, int totalLength)
    {
        List<List<int>> result = new List<List<int>>();
        GetCombinations(sizes, totalLength, new List<int>(), result);
        return result;
    }

    static void GetCombinations(int[] sizes, int remainingLength, List<int> currentCombination, List<List<int>> result)
    {
        if (remainingLength == 0)
        {
            result.Add(currentCombination);
            return;
        }

        foreach (int size in sizes)
        {
            if (size <= remainingLength)
            {
                List<int> newCombination = new List<int>(currentCombination);
                newCombination.Add(size);
                GetCombinations(sizes, remainingLength - size, newCombination, result);
            }
        }
    }

    static int GetCombinationCost(List<int> combination)
    {
        Dictionary<int, int> sizeCost = new Dictionary<int, int>()
        {
            { 50, 59 },
            { 75, 62 },
            { 100, 90 },
            { 120, 111 }
        };

        int cost = 0;
        foreach (int size in combination)
        {
            cost += sizeCost[size];
        }
        return cost;
    }

    static void Main(string[] args)
    {
        int[] sizes = new int[] { 50, 75, 100, 120 };
        int totalLength = 250;

        List<List<int>> combinations = GetAllCombinations(sizes, totalLength);

        List<int> cheapestCombination = null;
        int cheapestCost = int.MaxValue;

        foreach (List<int> combination in combinations)
        {
            int cost = GetCombinationCost(combination);
            if (cost < cheapestCost)
            {
                cheapestCost = cost;
                cheapestCombination = combination;
            }
        }

        Console.WriteLine("Cheapest combination: " + string.Join(",", cheapestCombination));
        Console.WriteLine("Cost: " + cheapestCost);
    }
}
