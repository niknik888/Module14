using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numsList = new List<int[]>()
        {
            new[] {2, 3, 7, 1},
            new[] {45, 17, 88, 0},
            new[] {23, 32, 44, -6},
        };

        var orderedNums = numsList
            .SelectMany(s => s) 
            .OrderBy(s => s);

        foreach (var ord in orderedNums)
            Console.WriteLine(ord);

    }
}