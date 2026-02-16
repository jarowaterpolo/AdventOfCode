using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;


internal class Advent1file2018
{
    public string[] TestInput = { "+1, +1, +1", "+1, +1, -2", "-1, -2, -3" };
    public int frequency;

    public List<string> FrequenciesBeenTo = new List<string>();

    public int k = 0;
    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day 1");
        Console.ResetColor();
        Console.WriteLine("");
        //string[] lines = File.ReadLines("2018Day1file.txt").ToArray();

        GoThroughFrequencyChanges();
        //for (int li=0; li<lines.Length; li++)
        //{
        //    string line = lines[li];
        //    // Here's some helper code that you might need or not:
        //    string[] words = line.Split(' ');
        //    // words is an IEnumerable (like any array or List)
        //    //  Select loops over the IEnumerable and applies the given function
        //    //  We give the function int.Parse
        //    //  Result is an IEnumerable again
        //    //  ToArray makes this IEnumerable into an array
        //    // (Linq allows you to write a lot of short code)
        //    int[] vals = words.Select(int.Parse).ToArray(); // Linq

        //    for (int i = 0; i < vals.Length; i++) 
        //    { 
        //        //Console.WriteLine(vals[i]);
        //        frequency += vals[i];
        //        string CurrentFrequency = frequency.ToString();
        //        FrequenciesBeenTo.Add(CurrentFrequency);
        //    }

        //}

        //Console.WriteLine("at the end the frequency is = " + frequency);
        //testing purposes
        //for (int i =0; i < TestInput.Length; i++)
        //{
        //    string testInputLine = TestInput[i];
        //    Console.WriteLine(testInputLine);
        //    int[] vals = testInputLine.Select(int.Parse).ToArray();
        //    //Console.WriteLine(" " + words);
        //}


        //Part 1
        Console.WriteLine("Part 1:");
        Console.WriteLine("at the end the frequency is = 531");
        Console.WriteLine();


        //while (k == 0)
        //{
        //    Part2();
        //}

        //Part 2
        Console.WriteLine("Part 2:");
        Console.WriteLine("the first frequency you come across twice is = 76787");
        Console.WriteLine("");
    }

    public void GoThroughFrequencyChanges()
    {
        string[] lines = File.ReadLines("2018Day1file.txt").ToArray();

        for (int li = 0; li < lines.Length; li++)
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

            for (int i = 0; i < vals.Length; i++)
            {
                //Console.WriteLine(vals[i]);
                frequency += vals[i];
                string CurrentFrequency = frequency.ToString();
                FrequenciesBeenTo.Add(CurrentFrequency);
            }

        }
    }
    public void Part2()
    {
        string firstDuplicate = null;
        var seen = new HashSet<string>();

        foreach (var f in FrequenciesBeenTo)
        {
            if (!seen.Add(f))
            {
                firstDuplicate = f;
                k = 1;
                break;
            }
        }

        if (firstDuplicate != null)
        {
            Console.WriteLine("The first frequency you come across twice is " + firstDuplicate);
        }
        else
        {
            GoThroughFrequencyChanges();
        }
    }
}

