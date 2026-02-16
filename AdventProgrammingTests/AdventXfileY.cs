using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;


internal class AdventXfileY
{
    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day X");
        Console.ResetColor();
        Console.WriteLine("");
        string[] lines = File.ReadLines("YDayXfile.txt").ToArray();

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
    }
}

