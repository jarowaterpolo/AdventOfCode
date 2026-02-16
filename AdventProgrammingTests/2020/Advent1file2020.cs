using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;


internal class Advent1file2020
{
    public string[] TestInput = { "1721", "979", "366", "299", "675", "1456" };
    public List<int> AllIntValues = new List<int>();

    public int Value1;
    public int Value2;
    public int Value3;
    public int Answer;
    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day 1");
        Console.ResetColor();
        Console.WriteLine("");
        string[] lines = File.ReadLines("2020Day1file.txt").ToArray();

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

            AllIntValues.Add(vals[0]);
            //Console.WriteLine(vals[0]);
        }

        //Part1();
        //Part2();


        //testing
        //for (int i = 0; i < TestInput.Length; i++) 
        //{
        //    for (int j = 0; j < TestInput.Length; j++) 
        //    { 
        //        if (i != j)
        //        {
        //            int[] IntInput = TestInput.Select(int.Parse).ToArray();
        //            if (IntInput[i] + IntInput[j] == 2020)
        //            {
        //                Console.WriteLine("the numbers that sum 2020 = " + TestInput[i] + "+" + TestInput[j] + "= 2020");
        //            }
        //        }
        //    }
        //}

        //Part 1
        Console.WriteLine("Part 1:");
        Console.WriteLine("the 2 values that add up to 2020 are 251 & 1769");
        Console.WriteLine("251 x 1769 = 444019 so the answer is 444019");
        Console.WriteLine();

        //Part 2
        Console.WriteLine("Part 2:");
        Console.WriteLine("the 3 values that add up to 2020 are 1589, 383 & 48");
        Console.WriteLine("1589 x 383 x 48 = 29212176 so the answer is 29212176");
        Console.WriteLine("");
    }

    void Part1()
    {
        for (int i = 0; i < AllIntValues.Count; i++)
        {
            for (int j = 0; j < AllIntValues.Count; j++)
            {
                if (i != j)
                {
                    if (AllIntValues[i] + AllIntValues[j] == 2020)
                    {
                        Console.WriteLine("the numbers that sum 2020 = " + AllIntValues[i] + "+" + AllIntValues[j] + "= 2020");
                        Value1 = AllIntValues[i];
                        Value2 = AllIntValues[j];
                    }
                }
            }
        }

        Answer = Value1 * Value2;
        Console.WriteLine("{0} x {1} = {2}", Value1, Value2, Answer);
    }

    void Part2()
    {
        for (int i = 0; i < AllIntValues.Count; i++)
        {
            for (int j = 0; j < AllIntValues.Count; j++)
            {
                for (int k = 0; k < AllIntValues.Count; k++)
                {
                    if (i != j && i != k && j != k)
                    {
                        if (AllIntValues[i] + AllIntValues[j] + AllIntValues[k] == 2020)
                        {
                            Console.WriteLine("the numbers that sum 2020 = " + AllIntValues[i] + "+" + AllIntValues[j] + "+" + AllIntValues[k] + "= 2020");
                            Value1 = AllIntValues[i];
                            Value2 = AllIntValues[j];
                            Value3 = AllIntValues[k];
                        }
                    }
                }
            }
        }

        Answer = Value1 * Value2 * Value3;
        Console.WriteLine("{0} x {1} x {2} = {3}", Value1, Value2, Value3, Answer);
    }
}

