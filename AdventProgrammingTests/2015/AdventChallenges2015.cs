using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
class AdventChallenges2015
{
    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("_____________");
        Console.WriteLine("Advent 2015:");
        Console.WriteLine("_____________");
        Console.WriteLine();
        Console.ResetColor();

        new Advent1file2015().Start();

        new Advent2file2015().Start();

        new Advent3file2015().Start();

        new Advent4file2015().Start();

        new Advent5file2015().Start();

        //Tests.DoTests();
    }

    void OldWayToStart()
    {
        //A1
        //Advent1 a1 = new Advent1();
        //a1.output = a1.text.Replace('(', 'a').Replace(')', 'b');
        ////Console.WriteLine(p.output);
        //a1.Start();
        // call the Start method on the instance

        //A2
        //formatting lines
        //FormatLines f = new FormatLines();
        //f.Start();
        //actual challenge
        //Advent2 a2 = new Advent2();
        //a2.Start();

        //A3
        //Advent3 a3 = new Advent3();
        //a3.Start();

        //new Advent4().Start();
    }
}
