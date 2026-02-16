using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
class AdventChallenges2020
{
    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("_____________");
        Console.WriteLine("Advent 2020:");
        Console.WriteLine("_____________");
        Console.WriteLine();
        Console.ResetColor();

        new Advent1file2020().Start();

        //Tests.DoTests();
    }
}
