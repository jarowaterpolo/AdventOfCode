using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Advent1file2016
{
    public string[] words;

    IVec2 BasePos = new IVec2(0, 0);
    public IVec2 Pos;
    public IVec2 Y = new IVec2(0, 1);
    public IVec2 X = new IVec2(1, 0);
    public int r = 0;

    public string CurrentPos;

    public string TestMoves;

    public int AmountOffBlocksAway;

    public List<string> PositionsBeenTo = new List<string>();
    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day 1");
        Console.ResetColor();
        Console.WriteLine("");
        string[] lines = File.ReadLines("2016Day1file.txt").ToArray();

        Pos = BasePos;
        CurrentPos = Pos.ToString();
        //Console.WriteLine("Your rotation = " + r);
        //Console.WriteLine("your at " + CurrentPos);
        //Console.WriteLine();

        for (int li = 0; li < lines.Length; li++)
        {
            string line = lines[li];

            string TestMoves =
                //"R2, L3"
                //"R2, R2, R2"
                //"R5, L5, R5, R3"
                "R8, R4, R4, R8"
                ;

            // Here's some helper code that you might need or not:
            words = line.Split(", ");
            //words = TestMoves.Split(", ");

            //Part1();
            //Part2();

            Console.WriteLine("Part 1:");
            Console.WriteLine("you are 161 Blocks away from Easter Bunny HQ");
            Console.WriteLine();

            Console.WriteLine("Part 2:");
            Console.WriteLine("The first Position you will come across twice is [-96,-14]");
            Console.WriteLine("This means you are 110 Blocks away from the Easter Bunny HQ");
        }
    }


    void Part1()
    {
        foreach (string s in words)
        {
            char RotationLetter = s[0];
            int MoveAmount = int.Parse(s.Substring(1));

            Console.WriteLine("we have letter {0} and number {1}", RotationLetter, MoveAmount);

            switch (RotationLetter)
            {
                case 'R':
                    r += 90;
                    break;
                case 'L':
                    r -= 90;
                    break;
            }

            if (r == 360)
            {
                r = 0;
            }
            else if (r == -90)
            {
                r = 270;
            }

            Console.WriteLine("Your rotation = " + r);

            Pos = Pos.RotateNumberMove(r, MoveAmount);
            CurrentPos = Pos.ToString();

            Console.WriteLine("you are at " + CurrentPos);
            Console.WriteLine(' ');

            if (Pos.x <= 0 && Pos.y <= 0)
            {
                AmountOffBlocksAway = -Pos.x - Pos.y;
            }
            else if (Pos.x >= 0 && Pos.y <= 0)
            {
                AmountOffBlocksAway = Pos.x - Pos.y;
            }
            else if (Pos.x <= 0 && Pos.y >= 0)
            {
                AmountOffBlocksAway = -Pos.x + Pos.y;
            }
            else
            {
                AmountOffBlocksAway = Pos.x + Pos.y;
            }
            Console.WriteLine("you are {0} Blocks away from start (0,0) ", AmountOffBlocksAway);
            Console.WriteLine(' ');
        }
        
    }

    void Part2()
    {
        foreach (string s in words)
        {
            char RotationLetter = s[0];
            int MoveAmount = int.Parse(s.Substring(1));

            //Console.WriteLine("we have letter {0} and number {1}", RotationLetter, MoveAmount);

            switch (RotationLetter)
            {
                case 'R':
                    r += 90;
                    break;
                case 'L':
                    r -= 90;
                    break;
            }

            if (r == 360)
            {
                r = 0;
            }
            else if (r == -90)
            {
                r = 270;
            }

            //Console.WriteLine("Your rotation = " + r);

            for (int i = 0; i < MoveAmount; i++)
            {
                Pos = Pos.RotateNumberMove(r, 1);
                CurrentPos = Pos.ToString();
                PositionsBeenTo.Add(CurrentPos);
                //Console.WriteLine("you are at " + CurrentPos);
                //Console.WriteLine(' ');
            }

            //PositionsBeenTo.Sort();
            //for (int i =0; i < PositionsBeenTo.Count; i++)
            //{
            //    Console.WriteLine(PositionsBeenTo[i]);
            //}

        }


        string firstDuplicate = null;
        var seen = new HashSet<string>();

        foreach (var pos in PositionsBeenTo) 
        { 
            if (!seen.Add(pos))
            {
                firstDuplicate = pos;
                break;
            }
        }

        if (firstDuplicate != null)
        {
            Console.WriteLine("The first Position you come across twice is " + firstDuplicate);
        }
        //var myList = PositionsBeenTo;

        //var duplicateItems = myList
        //.GroupBy(x => x)
        //.Where(g => g.Count() > 1)
        //.Select(g => g.Key);

        //foreach (var item in duplicateItems)
        //{
        //    Console.WriteLine("a positions you have been to multiple times is {0}", item);
        //}
        firstDuplicate = firstDuplicate.Trim().Trim('[', ']', ' ');
        var parts = firstDuplicate.Split(',');
        int x = int.Parse(parts[0]);
        int y = int.Parse(parts[1]);

        if (x <= 0 && y <= 0)
        {
            AmountOffBlocksAway = -x - y;
        }
        else if (x >= 0 && y <= 0)
        {
            AmountOffBlocksAway = x - y;
        }
        else if (x <= 0 && y >= 0)
        {
            AmountOffBlocksAway = -x + y;
        }
        else
        {
            AmountOffBlocksAway = x + y;
        }

        Console.WriteLine("you are {0} Blocks away from start (0,0) ", AmountOffBlocksAway);
        Console.WriteLine(' ');
    }
}

