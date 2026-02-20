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
        Console.WriteLine("The total sum of the difference result between the left and right list is 1889772");
        Console.WriteLine();

        //Part 2
        Console.WriteLine("Part 2:");
        Console.WriteLine("The total sum of the first and last digit of each line where the word variant also counts is 54578");
        Console.WriteLine("");

        TestGetFirstAndLastDigit();

        GetFirstAndLastDigit();
    }

    void TestGetFirstAndLastDigit()
    {
        string testInput = "3   4\r\n4   3\r\n2   5\r\n1   3\r\n3   9\r\n3   3";

        string[] lines = testInput.Split("\r\n");

        List<int> LeftInputList = new List<int>();
        List<int> RightInputList = new List<int>();
        List<int> ResultList = new List<int>();

        int ResultsSum = 0;

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

            LeftInputList.Add(FirstDigit);
            RightInputList.Add(LastDigit);

            Console.WriteLine("First & Last digit = " + FirstDigit + "" + LastDigit);

        }

        //start lists
        for (int i = 0; i < LeftInputList.Count; i++)
        {
            Console.WriteLine("left inputs: " + LeftInputList[i] + " right inputs: " + RightInputList[i]);
        }

        Console.WriteLine("________________________________");
        LeftInputList.Sort();
        RightInputList.Sort();

        //sorted lists
        for (int i = 0; i < LeftInputList.Count; i++)
        {
            Console.WriteLine("left inputs: " + LeftInputList[i] + " right inputs: " + RightInputList[i]);
        }

        Console.WriteLine("________________________________");

        //calculating difference
        for (int i = 0; i < LeftInputList.Count; i++)
        {
            if (LeftInputList[i] >= RightInputList[i])
            {
                ResultList.Add(LeftInputList[i] - RightInputList[i]);
            }
            else
            {
                ResultList.Add(RightInputList[i] - LeftInputList[i]);
            }

        }

        for (int i = 0; i < ResultList.Count; i++)
        {
            Console.WriteLine("results = " + ResultList[i]);
        }

        for (int i = 0; i < ResultList.Count; i++) 
        {
            ResultsSum += ResultList[i];
        }
        Console.WriteLine("________________________________");

        Console.WriteLine(ResultsSum);

    }

    void GetFirstAndLastDigit()
    {

        string[] lines = File.ReadLines("2024Day1file.txt").ToArray();

        List<int> LeftInputList = new List<int>();
        List<int> RightInputList = new List<int>();
        List<int> ResultList = new List<int>();

        int ResultsSum = 0;

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

            for (int i = 0; i < words.Length; i++) 
            {
                //Console.WriteLine("word " + i + " = " + words[i]);
            }

            int FirstNumber;
            int LastNumber;

            Int32.TryParse(words[0] , out FirstNumber);
            Int32.TryParse(words[3] , out LastNumber);

            LeftInputList.Add(FirstNumber);
            RightInputList.Add(LastNumber);

            //Console.WriteLine("First & Last digit = " + FirstDigit + "" + LastDigit);

        }

        //start lists
        for (int i = 0; i < LeftInputList.Count; i++)
        {
            Console.WriteLine("left inputs: " + LeftInputList[i] + " right inputs: " + RightInputList[i]);
        }

        Console.WriteLine("________________________________");
        LeftInputList.Sort();
        RightInputList.Sort();

        //sorted lists
        for (int i = 0; i < LeftInputList.Count; i++)
        {
            Console.WriteLine("left inputs: " + LeftInputList[i] + " right inputs: " + RightInputList[i]);
        }

        Console.WriteLine("________________________________");

        //calculating difference
        for (int i = 0; i < LeftInputList.Count; i++)
        {
            if (LeftInputList[i] >= RightInputList[i])
            {
                ResultList.Add(LeftInputList[i] - RightInputList[i]);
            }
            else
            {
                ResultList.Add(RightInputList[i] - LeftInputList[i]);
            }

        }

        for (int i = 0; i < ResultList.Count; i++)
        {
            Console.WriteLine("results = " + ResultList[i]);
        }

        for (int i = 0; i < ResultList.Count; i++)
        {
            ResultsSum += ResultList[i];
        }
        Console.WriteLine("________________________________");

        Console.WriteLine(ResultsSum);

    }


}

