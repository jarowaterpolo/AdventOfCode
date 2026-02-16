using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;


internal class Advent2file2015
{
    public int neededWrappingPaper;
    public int totalNeededWrappingPaper;

    public int neededRibbon;
    public int totalNeededRibbon;
    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day 2");
        Console.ResetColor();
        Console.WriteLine("");

        string[] lines = File.ReadLines("2015Day2file.txt").ToArray();

        for (int li = 0; li < lines.Length; li++)
        {
            string line = lines[li];
            // Here's some helper code that you might need or not:
            string[] words = line.Split('x');
            // words is an IEnumerable (like any array or List)
            //  Select loops over the IEnumerable and applies the given function
            //  We give the function int.Parse
            //  Result is an IEnumerable again
            //  ToArray makes this IEnumerable into an array
            // (Linq allows you to write a lot of short code)
            int[] vals = words.Select(int.Parse).ToArray(); // Linq
            //Console.WriteLine($"Line {li}: {line}. Values: {vals[0]} {vals[1]} {vals[2]}");

            int l = vals[0];
            int w = vals[1];
            int h = vals[2];

            //Console.WriteLine("present = " + line);
            int side1 = l * w;
            //Console.WriteLine("side1 = " + side1);
            int side2 = w * h;
            //Console.WriteLine("side2 = " + side2);
            int side3 = h * l;
            //Console.WriteLine("side3 = " + side3);
            int smallest = Math.Min(side1, Math.Min(side2, side3));

            neededWrappingPaper = (2 * side1) + (2 * side2) + (2 * side3) + smallest;
            //Console.WriteLine("needed wrapping paper for present " + line + "=" +neededWrappingPaper);
            totalNeededWrappingPaper += neededWrappingPaper;

            int[] OrderSmallest = new int[] { l, w, h };
            Array.Sort(OrderSmallest);

            int Smallest1 = OrderSmallest[0];
            int Smallest2 = OrderSmallest[1];

            neededRibbon = (2 * Smallest1) + (2 * Smallest2) + (l * w * h);
            totalNeededRibbon += neededRibbon;
            // for this one it should be IVec3, but anyway:
            //IVec2 pos = new IVec2(vals[0], vals[1]);
            //Console.WriteLine("   Position: {0}",pos); 
            // ^ automatically calls ToString!
        }

        Console.WriteLine("Part 1:");
        Console.WriteLine("total amount of needed wrapping paper = " + totalNeededWrappingPaper + "\n");

        Console.WriteLine("Part 2:");
        Console.WriteLine("total amount of needed Ribbon = " + totalNeededRibbon);
        Console.WriteLine("");
    }
}

