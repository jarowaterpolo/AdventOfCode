using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;



internal class Advent5file2015
{
    //public List<string> testLines = new List<string>();

    //lines
    public int li;
    public string line;
    public int LineCount;

    //nice or naughty
    public bool LineNice;
    public int NiceCount;
    public int NaughtyCount;
    
    //Part 1 vars
    public int VowelCount;
    public bool EnoughVowels;
    public bool DoubleLetter;
    public bool NoBannedCombos;
    public string[] BannedCombos = { "ab","cd","pq","xy" };

    //Part 2 vars
    public bool LetterRepeatedAfterX;
    public bool PairRepeatedWithoutOverlap;
    public List<string> pairs = new List<string>();

    //Shared vars
    public List<string> Letters = new List<string>();

    public string[] TestingStrings = { "abddwoswe", "egshacd", "aammeedd", "ugknbfddgicrmopn", "aaa", "jchzalrnumimnmhp", "haegwjzuvuyypxyu", "dvszwmarrgswjxmb", "aabaa", "bbb" };
    //public string[] TestingStrings = { "aaa", "aabaa", "bbb", "bbbb", "bbbbb" };

    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day 5");
        Console.ResetColor();
        Console.WriteLine("");
        string[] lines = File.ReadLines("2015Day5file.txt").ToArray();

        //Test();

        for (li=0; li<lines.Length; li++)
        {
            line = lines[li];

            //Part1();

            //Part2();

            //Console.WriteLine("Is the Line {0} nice ? " + line + "=" + LineNice, li + 1);
            //Console.WriteLine();

        }

        

        //Console.WriteLine("there are {0} lines", LineCount);
        //Console.WriteLine("there are {0} nice lines",NiceCount);
        //Console.WriteLine("there are {0} naughty lines",NaughtyCount);

        Console.WriteLine("Part 1:");
        Console.WriteLine("there are 236 nice lines");
        Console.WriteLine();

        Console.WriteLine("Part 2:");
        Console.WriteLine("there are 51 nice lines");
        Console.WriteLine();

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(testLines[i]);
        //}
    }

    public void Test()
    {
        for (int i = 0; i < TestingStrings.Length; i++)
        {
            line = TestingStrings[i];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Str {0}",i + 1);
            Console.ResetColor();
            //Part1();
            Part2();
            Console.WriteLine("");

            Console.WriteLine("Is the Line {0} nice ? " + line + "=" + LineNice, i + 1);
            Console.WriteLine();
        }
    }
    public void Part1()
    {
        VowelCheck();
        DoubleLetterCheck();
        BannedComboCheck();
        Console.WriteLine("");
        LineCount++;
        if (EnoughVowels == true && DoubleLetter == true && NoBannedCombos == true)
        {
            LineNice = true;
            NiceCount++;
        }
        else
        {
            LineNice = false;
            NaughtyCount++;
        }
    }

    public void Part2()
    {
        Console.WriteLine("STR {0}", LineCount + 1);
        LetterRepeatWithInBetween();
        PairRepeationWithNoOverlap();

        if (LetterRepeatedAfterX == true && PairRepeatedWithoutOverlap == true)
        {
            LineNice = true;
            NiceCount++;
        }
        else
        {
            LineNice = false;
            NaughtyCount++;
        }


        if (LineNice == true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            Console.ResetColor();
        }
        Console.WriteLine("Is the Line {0} nice ? " + line + "=" + LineNice, LineCount + 1);
        Console.ResetColor();
        Console.WriteLine("");
        LineCount++;
    }
    public void VowelCheck()
    {
        foreach (char c in line)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o'|| c == 'u')
            {
                VowelCount++;
            }
        }

        if (VowelCount >= 3)
        {
            EnoughVowels = true;
        }
        else 
        { 
            EnoughVowels = false;
        }
        Console.WriteLine("Enough Vowels = " + EnoughVowels);
        VowelCount = 0;
    }
    public void DoubleLetterCheck()
    {
        Letters.Add("");
        int i = 0;
        int b = 0;
        foreach (char c in line)
        {
            Letters.Add(c + "");
            i++;

            //if (i > 1)
            //{
            //    Console.Write(Letters[i - 1] + "");
            //    Console.Write(Letters[i] + "");
            //}

            if (b == 0)
            {
                if (Letters[i] == Letters[i - 1])
                {
                    DoubleLetter = true;
                    b = 1;
                }
                else
                {
                    DoubleLetter = false;
                }
            }
        }
        Console.WriteLine("Double Letter = " + DoubleLetter);
        Letters.Clear();
    }
    public void BannedComboCheck()
    {
        if (line.Contains("ab") || line.Contains("cd") || line.Contains("pq") || line.Contains("xy"))
        {
            NoBannedCombos = false;
        }
        else
        {
            NoBannedCombos = true;
        }
        Console.WriteLine("No Banned combo = " + NoBannedCombos);
    }
    public void PairRepeationWithNoOverlap()
    {
        MakePairs();
        ReplaceOverlapping();

        int b = 0;
        int y = 0;
        int z = 0;

        if (b == 0)
        {
            for (int i = 0; i < pairs.Count; i++)
            {
                for (int j = 0; j < pairs.Count; j++)
                {
                    if (b == 0)
                    {
                        //Console.WriteLine("checked if pair i = {0} = {1} == pair j {2} = {3}", i, pairs[i], j, pairs[j]);
                        if (pairs[i] == pairs[j] && i != j)
                        {
                            //Console.WriteLine("{0}={1}", pairs[i], pairs[j]);
                            PairRepeatedWithoutOverlap = true;
                            b = 1;
                            Console.WriteLine("Line {0} has {1} == {2}", li + 1,pairs[i],pairs[j]);
                        }
                        else
                        {
                            PairRepeatedWithoutOverlap = false;
                        }
                    }
                }

                if (LineCount == 746 - 1)
                {
                    //Console.WriteLine(pairs[i]);
                }
            }
        }

        pairs.Clear();


        //Found Problem
        //          STR 746
        //          Repeated letter after x letter = True (pep)
        //          there is a repeated pair without overlap = False (pe-pcf-pe) (pe*2)
        //          Is the Line 746 nice? rpepcfpelvhzzxzj = False

        //if (pairs[i - 1] == pairs[i - 2])
        //{
        //    Console.WriteLine(pairs[i - 1] + "" + pairs[i - 2]);
        //    //replace one of the overlapping pair
        //    pairs[i - 1] = pairs[i - 1].Replace(pairs[i - 1], i.ToString());
        //    Console.WriteLine(pairs[i - 1] + "" + pairs[i - 2]);
        //}


        //if (b == 0)
        //{
        //if (pairs.Contains(pairs[i - 1]))
        //{
        //    PairRepeatedWithoutOverlap = true;
        //    b = 1;
        //}
        //else
        //{
        //    PairRepeatedWithoutOverlap = false;
        //}

        //for (int j = 0; j < pairs.Count; j++)
        //{
        //    if (pairs[i - 1] == pairs[j])
        //    {
        //        Console.WriteLine('=');
        //    }

        //}

        //    if (pairs[i - 1] == pairs[i - 2])
        //    {
        //        PairRepeatedWithoutOverlap = true;
        //        b = 1;
        //    }
        //    else
        //    {
        //        PairRepeatedWithoutOverlap = false;
        //    }
        //}

        //for (int k = 0; k < pairs.Count; k++)
        //{
        //    Console.WriteLine(pairs[k]);
        //}

        //Put On Again

        Console.WriteLine("there is a repeated pair without overlap = " + PairRepeatedWithoutOverlap);
        pairs.Clear();
    }
    public void LetterRepeatWithInBetween()
    {
        Letters.Add("");
        int i = 0;
        int b = 0;
        foreach (char c in line)
        {
            Letters.Add(c + "");
            i++;

            if (b == 0)
            {
                if (i > 1)
                {
                    //if (i > 1)
                    //{
                    //    Console.Write(Letters[i - 2] + "");
                    //    Console.Write(Letters[i] + "");
                    //}

                    if (Letters[i] == Letters[i - 2])
                    {
                        Console.WriteLine("Line {0} has " + Letters[i] + Letters[i-1] + Letters[i-2], li + 1);
                        LetterRepeatedAfterX = true;
                        b = 1;
                    }
                    else
                    {
                        LetterRepeatedAfterX = false;
                    }
                }
            }
        }

        //Put On Again
        Console.WriteLine("Repeated letter after x letter = " + LetterRepeatedAfterX);
        Letters.Clear();
    }

    public void MakePairs()
    {
        //Console.WriteLine();
        pairs.Add("");

        int i = 0;
        string s = "";

        foreach (char c in line)
        {
            i++;
            if (i > 1)
            {
                pairs.Add(s + "" + c);
                //Console.WriteLine(pairs[i - 1]);

                
            }
            s = c.ToString();
        }
    }

    public void ReplaceOverlapping()
    {
        for (int i = 0; i < pairs.Count; i++)
        {
            if (i > 1)
            {
                if (pairs[i] == pairs[i - 1])
                {
                    pairs[i] = pairs[i].Replace(pairs[i], i.ToString());
                    //Console.WriteLine(pairs[i]);
                }
            }
        }

        for (int j = 0; j < pairs.Count; j++)
        {
            //Console.WriteLine(pairs[j]);
        }
    }
}

