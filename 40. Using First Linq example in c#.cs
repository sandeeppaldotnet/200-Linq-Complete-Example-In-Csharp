using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var firstNumber = numbers.First();

        Console.WriteLine($"First Number: {firstNumber}");
    }
}
