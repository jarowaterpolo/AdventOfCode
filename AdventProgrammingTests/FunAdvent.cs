using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;


internal class FunAdvent
{
    public int ColorChanger = 0;
    public List<string> ChristmasStrings = new List<string>();
    public Random random = new Random();

    public void Start()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        var star = "  \u2605  ";

        ChristmasStrings.Add(star);

        string tree =
            "  ^  \n" +
             " ^^^ \n" +
             "^^^^^ \n" +
             "  |";
        ChristmasStrings.Add
            (tree
            );

        var heart = "  \u2665  ";

        ChristmasStrings.Add(heart);

        //normal tree + chrismas tree

        var NormalTree = "  \U0001F332";

        var ChristmasTree = "  \U0001F384";

        ChristmasStrings.Add(NormalTree);
        ChristmasStrings.Add(ChristmasTree);

        ChristmasSetupText();

        for (int i = 0; i < 10; i++) 
        {
            switch (ColorChanger)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ResetColor();
                    break;
            }

            int RandomNum = random.Next(0, ChristmasStrings.Count);
            Console.WriteLine(ChristmasStrings[RandomNum]);

            ColorChanger++;

            if (ColorChanger >= 3)
            {
                ColorChanger = 1;
            }

        }
        Console.ResetColor();
    }


    public void ChristmasSetupText()
    {
        //Symbol Vars Setup
        var star = "  \u2605  ";
        var heart = "  \u2665  ";
        string MyTree =
             "  ^  \n" +
             " ^^^ \n" +
             "^^^^^ \n" +
             "  |";
        var NormalTree = "  \U0001F332";
        var ChristmasTree = "  \U0001F384";
        var Present = "  \U0001F381";


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(star);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(MyTree);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(heart);
        Console.ResetColor();
        Console.WriteLine(Present);
        Console.WriteLine();
    }
}

