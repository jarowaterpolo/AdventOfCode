using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


internal class Advent3file2015
{
    public string HouseID = "";
    public HashSet<string> Houses = new HashSet<string>();
    IVec2 BasePos = new IVec2(0, 0);
    public IVec2 Pos;
    public IVec2 Pos2;
    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day 3");
        Console.ResetColor();
        Console.WriteLine("");
        string[] lines = File.ReadLines("2015Day3file.txt").ToArray();
        Pos = BasePos;
        Pos2 = BasePos;

        //Part 1
        for (int li = 0; li < lines.Length; li++)
        {
            string line = lines[li];

            Console.WriteLine("Part 1:");
            HouseID = Pos.ToString();
            Houses.Add(HouseID);

            foreach (char c in line)
            {
                Pos = Pos.ArrowMove(c);
                
                HouseID = Pos.ToString();
                //Console.WriteLine("your at house {0} ",HouseID);
                Houses.Add(HouseID);
            }

            Console.WriteLine("Santa has been to {0} Unique Houses", Houses.Count);
        }

        Houses.Clear();
        ResetCords();
        Console.WriteLine("");

        //Part 2
        for (int li = 0; li < lines.Length; li++)
        {
            string line = lines[li];

            Console.WriteLine("Part 2:");
            HouseID = Pos.ToString();
            Houses.Add(HouseID);

            int i = 0;
            foreach (char c in line)
            {
                i++;
                if (i == 1)
                {
                    Pos = Pos.ArrowMove(c);

                    HouseID = Pos.ToString();
                }
                else
                {
                    Pos2 = Pos2.ArrowMove(c);

                    i = 0;
                    HouseID = Pos2.ToString();
                }

                //Console.WriteLine("your at house {0} ",HouseID);
                Houses.Add(HouseID);
            }

            Console.WriteLine("Santa and his robot have been to {0} Unique Houses", Houses.Count);
        }

        Console.WriteLine("");
    }

    void ResetCords()
    {
        Pos = BasePos;
        Pos2 = BasePos;
    }
}

