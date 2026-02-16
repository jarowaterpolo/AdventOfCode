using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


internal class Advent1file2022
{
    public string[] TestInput = { "1000","2000","3000","","4000","","5000","6000","","7000","8000","9000","","10000" };
    public int ElfID = 0;
    public int TotalCalories = 0;
    public int HighestCalories = 0;

    public List<string> ElfWithCalories = new List<string>();
    public List<string> ElfWithHighestCalories = new List<string>();

    List<int> HighestCaloriesInts = new List<int>();

    public int SumOfElfs;

    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day 1");
        Console.ResetColor();
        Console.WriteLine("");
        string[] lines = File.ReadLines("2022Day1file.txt").ToArray();

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

        //Test();
        //FindHighestCalorieElfs();
        //Part1();
        //Part2();

        //Part 1
        Console.WriteLine("Part 1:");
        Console.WriteLine("Elf number 26 was carrying the most amount of calories with an amount of 70764");
        Console.WriteLine();

        //Part 2
        Console.WriteLine("Part 2:");
        Console.WriteLine("The sum of the 3 highest calorie Elfs = 203905");
        Console.WriteLine("");
    }

    void Test()
    {
        HighestCalories = 0;
        ElfID++;

        for (int i = 0; i < TestInput.Length; i++)
        {
            string line = TestInput[i];
            string[] words = line.Split(" ");
            string empty = "";
            if (words[0] != empty)
            {
                int[] vals = words.Select(int.Parse).ToArray();
                //Console.WriteLine(vals[0]);
                TotalCalories += vals[0];
                string temp = ("Elf number " + ElfID + " has a total of " + TotalCalories + " calories with them");
                ElfWithCalories.Add(temp);

                if (TotalCalories > HighestCalories)
                {
                    HighestCalories = TotalCalories;
                    //Console.WriteLine("Elf {0} has the highest calories of {1}", ElfID, HighestCalories);
                    string Temp = ("Elf "+ ElfID +" has the highest calories of " + HighestCalories);
                    ElfWithHighestCalories.Add(Temp);
                }
            }
            else
            {
                //Console.WriteLine("Elf number {0} has a total of {1} calories with them", ElfID, TotalCalories);
                ElfID++;
                TotalCalories = 0;
            }

        }

        for (int i = 0; i < ElfWithCalories.Count; i++)
        {
            if (i > 0)
            {
                while (ElfWithCalories[i].ElementAt(11) == ElfWithCalories[i - 1].ElementAt(11))
                {
                    ElfWithCalories.Remove(ElfWithCalories[i - 1]);
                }
            }
        }

        for (int i = 0; i < ElfWithCalories.Count; i++)
        {
            if (ElfWithCalories[i] != null)
            {
                Console.WriteLine(ElfWithCalories[i]);
            }
        }

        Console.WriteLine(ElfWithHighestCalories[ElfWithHighestCalories.Count - 1]);
    }

    void FindHighestCalorieElfs()
    {
        ElfID++;
        string[] lines = File.ReadLines("2022Day1file.txt").ToArray();

        for (int li = 0; li < lines.Length; li++)
        {
            string line = lines[li];
            string[] words = line.Split(' ');

            if (words[0] != "")
            {
                int[] vals = words.Select(int.Parse).ToArray(); // Linq
                //Console.WriteLine(vals[0]);
                TotalCalories += vals[0];

                if (TotalCalories > HighestCalories)
                {
                    HighestCalories = TotalCalories;
                    //Console.WriteLine("Elf {0} has the highest calories of {1}", ElfID, HighestCalories);
                    string Temp = ("Elf " + ElfID + " has the highest calories of " + HighestCalories);
                    ElfWithHighestCalories.Add(Temp);
                }
            }
            else
            {
                HighestCaloriesInts.Add(TotalCalories);
                ElfID++;
                TotalCalories = 0;
            }
        }
    }
    void Part1()
    {
        Console.WriteLine(ElfWithHighestCalories[ElfWithHighestCalories.Count - 1]);
    }

    void Part2()
    {
        int CalorieSum;
        HighestCaloriesInts.Sort();
        CalorieSum = HighestCaloriesInts.TakeLast(3).Sum();
        Console.WriteLine(CalorieSum);
    }
}

