using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
class AdventChallenges2022
{
    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("_____________");
        Console.WriteLine("Advent 2022:");
        Console.WriteLine("_____________");
        Console.WriteLine();
        Console.ResetColor();

        new Advent1file2022().Start();

        //Tests.DoTests();
    }
}
