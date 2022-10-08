using System;

namespace Lab_4_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Cars cars = new("535i", 18, "седан", "BMW");
        cars.Information();

        BMW bmw = new("M5", 18, "седан");
        cars.Information();

        Cars cars1 = bmw;
        cars.Information();

        BMW bmw1 = (BMW)bmw;
        cars.Information();

        Console.ReadLine();
    }
}