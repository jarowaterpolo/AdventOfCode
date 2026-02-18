using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


internal class Advent1file2024
{


    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day 1");
        Console.ResetColor();
        Console.WriteLine("");
        //string[] lines = File.ReadLines("2024Day1file.txt").ToArray();

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
        //    //int[] vals = words.Select(int.Parse).ToArray(); // Linq
        //}

        //totalSum = 0;

        //TestGetFirstAndLastDigit();
        //GetFirstAndLastDigit();
        //ReplaceTextToDigits();

        //foreach (int n in numbers)
        //{
        //    Console.WriteLine($"{n}");
        //    totalSum += n;
        //}

        //Console.WriteLine(totalSum);


        //Part 1
        Console.WriteLine("Part 1:");
        Console.WriteLine("The total sum of the first and last digit of each line is 55208");
        Console.WriteLine();

        //Part 2
        Console.WriteLine("Part 2:");
        Console.WriteLine("The total sum of the first and last digit of each line where the word variant also counts is 54578");
        Console.WriteLine("");

    }

    void Test()
    {
        string testInput = "3   4\r\n4   3\r\n2   5\r\n1   3\r\n3   9\r\n3   3\r\n";
    }

   
}

