using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


internal class Advent1file2023
{
    string[] testStrings = ["1abc2", "pqr3stu8vwx", "a1b2c3d4e5f", "treb7uchet"];
    List<int> numbers = new List<int>();
    int totalSum;

    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day 1");
        Console.ResetColor();
        Console.WriteLine("");
        //string[] lines = File.ReadLines("2023Day1file.txt").ToArray();

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

        totalSum = 0;

        //TestGetFirstAndLastDigit();
        //GetFirstAndLastDigit();
        ReplaceTextToDigits();

        foreach (int n in numbers)
        {
            Console.WriteLine($"{n}");
            totalSum += n;
        }

        Console.WriteLine(totalSum);


        //Part 1
        Console.WriteLine("Part 1:");
        Console.WriteLine("The total sum of the first and last digit of each line is 55208");
        Console.WriteLine();

        //Part 2
        Console.WriteLine("Part 2:");
        Console.WriteLine("The total sum of the first and last digit of each line where the word variant also counts is 54578");
        Console.WriteLine("");

    }

    void TestGetFirstAndLastDigit()
    {
        string[] lines = testStrings;
        for (int li=0; li<lines.Length; li++)
        {
            string line = lines[li];
            // Here's some helper code that you might need or not:
            string[] words = line.Split(' ');
            Console.WriteLine(words[0]);

            int[] Digits = words
            .SelectMany(w => w.Where(char.IsDigit))
            .Select(c => c - '0')
            .ToArray();


            int FirstDigit = Digits[0];
            int LastDigit = Digits[Digits.Length - 1];

            int n = FirstDigit * 10 + LastDigit;
            numbers.Add(n);

            Console.WriteLine("First & Last digit = " + FirstDigit + "" + LastDigit);

        }
    }


    void GetFirstAndLastDigit()
    {
        string[] lines = File.ReadLines("2023Day1file.txt").ToArray();
        for (int li = 0; li < lines.Length; li++)
        {
            string line = lines[li];
            // Here's some helper code that you might need or not:
            string[] words = line.Split(' ');
            Console.WriteLine(words[0]);

            int[] Digits = words
            .SelectMany(w => w.Where(char.IsDigit))
            .Select(c => c - '0')
            .ToArray();


            int FirstDigit = Digits[0];
            int LastDigit = Digits[Digits.Length - 1];

            int n = FirstDigit * 10 + LastDigit;
            numbers.Add(n);

            Console.WriteLine("First & Last digit = " + FirstDigit + "" + LastDigit);

        }
    }

    void ReplaceTextToDigits()
    {
        var wordToNumber = new Dictionary<string, string>
        {
            { "one", "o1e" },
            { "two", "t2o" },
            { "three", "t3e" },
            { "four", "f4r" },
            { "five", "f5e" },
            { "six", "s6x" },
            { "seven", "s7n" },
            { "eight", "e8t" },
            { "nine", "n9e" }
        };

        string[] lines = File.ReadLines("2023Day1file.txt").ToArray();
        foreach (string orline in lines)
        {
            string line = orline;
            foreach (var key in wordToNumber)
            {
                line = line.Replace(key.Key, key.Value, StringComparison.OrdinalIgnoreCase);
            }

            int[] digits = line
                .Where(char.IsDigit)
                .Select(c => c - '0')
                .ToArray();

            Console.WriteLine(line);


            int FirstDigit = digits[0];
            int LastDigit = digits[digits.Length - 1];

            int n = FirstDigit * 10 + LastDigit;
            numbers.Add(n);

            //Console.WriteLine("First & Last digit = " + FirstDigit + "" + LastDigit);

        }
}
}

