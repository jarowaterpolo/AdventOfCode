using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;


internal class Advent1file2015
{
    public int i;
    public int j;
    public int k;
    public int x;
    public int y;
    public int z;
    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day 1");
        Console.ResetColor();
        Console.WriteLine("");
        string[] lines = File.ReadLines("2015Day1file.txt").ToArray();

        for (int li = 0; li < lines.Length; li++)
        {
            string line = lines[li];

            foreach (char c in line.ToCharArray()) 
            {
                if (c == '(')
                {
                    i++;
                    x++;
                    y++;
                }
                else if (c == ')') 
                { 
                    j++;
                    x--;
                    y++;
                }

                if (x == -1 && z == 0)
                {
                    z = y;
                }
            }

            k = i - j;
        }

        Console.WriteLine("Part 1:");
        Console.WriteLine("ended up on floor " + k + "\n");

        Console.WriteLine("Part 2:");
        Console.WriteLine("first time at floor -1 = " + z);
        Console.WriteLine("");
    }
}

