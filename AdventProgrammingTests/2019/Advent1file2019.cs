using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;


internal class Advent1file2019
{
    public double[] testDoubles = { 12, 14, 1969, 100756 };
    public double neededFuelPerModule;
    public double FuelForFuel;
    public double TotalFuelNeeded;
    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day 1");
        Console.ResetColor();
        Console.WriteLine("");
        string[] lines = File.ReadLines("2019Day1file.txt").ToArray();

        for (int li=0; li<lines.Length; li++)
        {
            string line = lines[li];
            // Here's some helper code that you might need or not:
            string[] words = line.Split(' ');
            // words is an IEnumerable (like any array or List)
            //  Select loops over the IEnumerable and applies the given function
            //  We give the function int.Parse
            //  Result is an IEnumerable again
            //  ToArray makes this IEnumerable into an array
            // (Linq allows you to write a lot of short code)
            //int[] vals = words.Select(int.Parse).ToArray(); // Linq
        }

        //test 1

        //for (int i = 0; i < testDoubles.Length; i++) 
        //{ 
        //    neededFuelPerModule = Math.Floor(testDoubles[i] / 3) - 2;
        //    Console.WriteLine(neededFuelPerModule);
        //    neededFuelPerModule = 0;
        //}

        //test 2

        //for (int i = 0; i < testDoubles.Length; i++)
        //{
        //    neededFuelPerModule = Math.Floor(testDoubles[i] / 3) - 2;
        //    FuelForFuel = neededFuelPerModule;

        //    while (FuelForFuel / 3 - 2 > 0)
        //    {
        //        FuelForFuel = Math.Floor(FuelForFuel / 3) - 2;
        //        Console.WriteLine("-( " + FuelForFuel + " )-");
        //        neededFuelPerModule += FuelForFuel;
        //    }

        //    Console.WriteLine(neededFuelPerModule);
        //    TotalFuelNeeded += neededFuelPerModule;

        //    neededFuelPerModule = 0;
        //}
        //Console.WriteLine();
        //Console.WriteLine("-( {0} )-", TotalFuelNeeded);

            /*
            Fuel required to launch a given module is based on its mass. Specifically, to find the fuel required for a module, take its mass, divide by three, round down, and subtract 2.

            For example:

            For a mass of 12, divide by 3 and round down to get 4, then subtract 2 to get 2.
            For a mass of 14, dividing by 3 and rounding down still yields 4, so the fuel required is also 2.
            For a mass of 1969, the fuel required is 654.
            For a mass of 100756, the fuel required is 33583.
            The Fuel Counter-Upper needs to know the total fuel requirement. To find it, individually calculate the fuel needed for the mass of each module (your puzzle input), then add together all the fuel values.

            What is the sum of the fuel requirements for all of the modules on your spacecraft?
            */

            //Part1();
            //Part2();

        //Part 1
        Console.WriteLine("Part 1:");
        Console.WriteLine("the total amount of fuel needed = 3415695");
        Console.WriteLine();

        //Part 2
        Console.WriteLine("Part 2:");
        Console.WriteLine("the total amount of fuel needed = 5120654");
        Console.WriteLine("");
    }

    public void Part1()
    {
        string[] lines = File.ReadLines("2019Day1file.txt").ToArray();

        for (int li = 0; li < lines.Length; li++)
        {
            string line = lines[li];
            string[] words = line.Split(' ');
            int[] vals = words.Select(int.Parse).ToArray(); // Linq

            var doubleVals = Convert.ToDouble(vals[0] / 3);
            //Console.WriteLine(vals[0]);
            for (int i = 0; i < vals.Length; i++) 
            {
                neededFuelPerModule = Math.Floor(doubleVals) - 2;
                Console.WriteLine(neededFuelPerModule);
                TotalFuelNeeded += neededFuelPerModule;
            }
        }
        Console.WriteLine(' ');
        Console.WriteLine("the total amount of fuel needed for the whole spacecraft = " + TotalFuelNeeded);
    }

    public void Part2()
    {
        string[] lines = File.ReadLines("2019Day1file.txt").ToArray();

        for (int li = 0; li < lines.Length; li++)
        {
            string line = lines[li];
            string[] words = line.Split(' ');
            int[] vals = words.Select(int.Parse).ToArray(); // Linq

            var doubleVals = Convert.ToDouble(vals[0] / 3);
            //Console.WriteLine(vals[0]);
            for (int i = 0; i < vals.Length; i++)
            {
                neededFuelPerModule = Math.Floor(doubleVals) - 2;
                FuelForFuel = neededFuelPerModule;
                while (FuelForFuel / 3 -2 > 0)
                {
                    FuelForFuel = Math.Floor(FuelForFuel / 3) - 2;
                    Console.WriteLine("-( " + FuelForFuel + " )-");
                    neededFuelPerModule += FuelForFuel;
                }


                Console.WriteLine(neededFuelPerModule);
                TotalFuelNeeded += neededFuelPerModule;
            }
        }
        Console.WriteLine(' ');
        Console.WriteLine("the total amount of fuel needed for the whole spacecraft = " + TotalFuelNeeded);
    }
}

