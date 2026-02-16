using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;


internal class Advent1file2021
{
    public string[] TestInput = { "199", "200", "208", "210", "200", "207", "240", "269", "260", "263" };
    public int[] IntInputs;
    public int IncreasedDepthMeasureCounter;
    public List<int> IntList = new List<int>();
    public List<int> MeasureSumList = new List<int>();
    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day 1");
        Console.ResetColor();
        Console.WriteLine("");
        string[] lines = File.ReadLines("2021Day1file.txt").ToArray();

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
            int[] vals = words.Select(int.Parse).ToArray(); // Linq
        }

        //Test();
        //Part1();
        //Part2();

        //Part 1
        Console.WriteLine("Part 1:");
        Console.WriteLine("the depth measured was increased 1448 times");
        Console.WriteLine();

        //Part 2
        Console.WriteLine("Part 2:");
        Console.WriteLine("the depth measured was increased 1471 times");
        Console.WriteLine("");
    }

    public void Test()
    {
        for (int i = 0; i < TestInput.Length; i++)
        {
            IntInputs = TestInput.Select(int.Parse).ToArray();
            if (i > 0)
            {
                if (IntInputs[i] - IntInputs[i-1] > 0)
                {
                    IncreasedDepthMeasureCounter++;
                    Console.WriteLine("{0} - {1} > 0 so", IntInputs[i], IntInputs[i-1]);
                    Console.WriteLine("the incereased depth measure counter has gone up to " + IncreasedDepthMeasureCounter);
                }
            }

        }
    }

    public void Part1()
    {
        string[] lines = File.ReadLines("2021Day1file.txt").ToArray();
        for (int li = 0; li < lines.Length; li++)
        {
            string line = lines[li];
            string[] words = line.Split(' ');
            IntInputs = words.Select(int.Parse).ToArray();
            IntList.Add(IntInputs[0]);

        }


        for (int i = 0; i < IntList.Count; i++)
        {
            if (i > 0)
            {
                if (IntList[i] - IntList[i - 1] > 0)
                {
                    IncreasedDepthMeasureCounter++;
                    Console.WriteLine("{0} - {1} > 0 so", IntList[i], IntList[i - 1]);
                    Console.WriteLine("the incereased dept measure counter has gone up to " + IncreasedDepthMeasureCounter);
                }
            }
        }

        IncreasedDepthMeasureCounter = 0;
    }

    public void Part2()
    {
        string[] lines = File.ReadLines("2021Day1file.txt").ToArray();
        for (int li = 0; li < lines.Length; li++)
        {
            string line = lines[li];
            string[] words = line.Split(' ');
            IntInputs = words.Select(int.Parse).ToArray();
            IntList.Add(IntInputs[0]);
        }


        for (int i = 0; i < IntList.Count; i++)
        {
            if (i + 2 < IntList.Count)
            {
                int MeasureSum = IntList[i] + IntList[i + 1] + IntList[i + 2];
                //Console.WriteLine("Sum {0}: Value 1 = {1} Value 2 = {2} and Value 3 = {3}", i + 1, IntList[i], IntList[i + 1], IntList[i + 2]);
                //Console.WriteLine("the sum of those = " + MeasureSum);
                MeasureSumList.Add(MeasureSum);
            }
        }

        for (int i = 0; i < MeasureSumList.Count; i++)
        {
            if (i > 0)
            {
                if (MeasureSumList[i] - MeasureSumList[i - 1] > 0)
                {
                    IncreasedDepthMeasureCounter++;
                    Console.WriteLine("{0} - {1} > 0 so", MeasureSumList[i], MeasureSumList[i - 1]);
                    Console.WriteLine("the incereased dept measure counter has gone up to " + IncreasedDepthMeasureCounter);
                }
            }
        }
    }
}

