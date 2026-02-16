using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Globalization;


internal class Advent1file2017
{
    //p1
    //public string[] TestInput = { "1122", "1111", "1234", "91212129" };
    //p2
    public string[] TestInput = { "1212", "1221", "123425", "123123", "12131415" };

    public int CodeSum;

    public int i = 0;
    public int j = 0;
    public int Number = 0;
    public int Number2 = 0;
    public int firstNum = 0;
    public int lastNum = 0;
    public string[] words;

    public List<int> Nums = new List<int>();

    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day 1");
        Console.ResetColor();
        Console.WriteLine("");
        string[] lines = File.ReadLines("2017Day1file.txt").ToArray();

        for (int li=0; li<lines.Length; li++)
        {
            string line = lines[li];
            //string line = TestInput[li];

            // Here's some helper code that you might need or not:
            words = line.Split(' ');
            // words is an IEnumerable (like any array or List)
            //  Select loops over the IEnumerable and applies the given function
            //  We give the function int.Parse
            //  Result is an IEnumerable again
            //  ToArray makes this IEnumerable into an array
            // (Linq allows you to write a lot of short code)
            //int[] vals = words.Select(int.Parse).ToArray(); // Linq
        }

        //Test1();
        //Test2();

        firstNum = 0;
        lastNum = 0;
        CodeSum = 0;

        //Part1();
        //Part2();

        Console.WriteLine("Part 1:");
        Console.WriteLine("out the captcha comes 1203");
        Console.WriteLine();

        Console.WriteLine("Part 2:");
        Console.WriteLine("out the captcha with the new rules comes 1146");
        Console.WriteLine("");
    }

    //p1
    void Test1()
    {
        for (int k = 0; k < TestInput.Length; k++)
        {
            foreach (char c in TestInput[k])
            {
                lastNum = c - 48;
            }

            foreach (char c in TestInput[k])
            {

                Number = c - 48;

                if (i >= 1)
                {
                    if (Number == Number2)
                    {
                        CodeSum += Number;
                    }
                }
                else
                {
                    firstNum = Number;
                }

                Console.WriteLine(Number2 + " " + Number);
                Number2 = Number;
                i += 1;
                //Console.WriteLine("second num = "+ Number2 + " first num =" + Number);
            }

            if (firstNum == lastNum)
            {
                CodeSum += firstNum;
                Console.WriteLine("added {0} because firstNum {1} == lastNum {2}", firstNum, firstNum, lastNum);
            }

            Console.WriteLine(CodeSum);
            Console.WriteLine();
            CodeSum = 0;
            i = 0;
            Number = 0;
            Number2 = 0;
        }
    }
    //p2
    void Test2()
    {
        for (int k = 0; k < TestInput.Length; k++)
        {
            foreach (char c in TestInput[k])
            {

                Nums.Add(c - 48);

                //if (i > TestInput.Length / 2)
                //{
                //    if (Nums[i - TestInput.Length / 2] == Nums[i])
                //    {
                //        CodeSum += Nums[i];
                //    }
                //}


                //if (Nums.Count > TestInput.Length / 2)
                //{
                //    Console.WriteLine(Nums[i] + " " + Nums[i - TestInput.Length / 2]);
                //}
                //i += 1;
                //Console.WriteLine("second num = "+ Number2 + " first num =" + Number);
            }

            for (i = 0; i < Nums.Count; i++)
            {
                //nums == 6
                //1 + 3 = 4 -- 3 + 3 == 6 -- 4 + 3 = 7 == 1 (123123)
                if ((i + Nums.Count / 2) >= Nums.Count)
                {
                    Console.WriteLine("Nums count = " + Nums.Count + " & your at " + i);
                    Console.WriteLine("trying to get number " + (i - Nums.Count / 2) + "");
                    if (Nums[i] == Nums[i - Nums.Count / 2])
                    {
                        CodeSum += Nums[i];
                    }
                }
                else
                {
                    Console.WriteLine("Nums count = " + Nums.Count + " & your at " + i);
                    Console.WriteLine("trying to get number " + (i + Nums.Count / 2) + "");
                    if (Nums[i] == Nums[i + Nums.Count / 2])
                    {
                        CodeSum += Nums[i];
                    }
                }
            }
            Console.WriteLine(CodeSum);
            Console.WriteLine();
            Nums.Clear();
            CodeSum = 0;
            i = 0;
        }
    }

    void Part1()
    {
        for (int k = 0; k < words.Length; k++)
        {
            foreach (char c in words[k])
            {
                lastNum = c - 48;
            }

            foreach (char c in words[k])
            {

                Number = c - 48;

                if (i >= 1)
                {
                    if (Number == Number2)
                    {
                        CodeSum += Number;
                    }
                }
                else
                {
                    firstNum = Number;
                }

                Console.WriteLine(Number2 + " " + Number);
                Number2 = Number;
                i += 1;
                //Console.WriteLine("second num = "+ Number2 + " first num =" + Number);
            }

            if (firstNum == lastNum)
            {
                CodeSum += firstNum;
                Console.WriteLine("added {0} because firstNum {1} == lastNum {2}", firstNum, firstNum, lastNum);
            }

            Console.WriteLine(CodeSum);
            Console.WriteLine();
            CodeSum = 0;
            i = 0;
            Number = 0;
            Number2 = 0;
        }
    }

    void Part2() 
    {
        for (int k = 0; k < words.Length; k++)
        {
            foreach (char c in words[k])
            {

                Nums.Add(c - 48);

                //if (i > TestInput.Length / 2)
                //{
                //    if (Nums[i - TestInput.Length / 2] == Nums[i])
                //    {
                //        CodeSum += Nums[i];
                //    }
                //}


                //if (Nums.Count > TestInput.Length / 2)
                //{
                //    Console.WriteLine(Nums[i] + " " + Nums[i - TestInput.Length / 2]);
                //}
                //i += 1;
                //Console.WriteLine("second num = "+ Number2 + " first num =" + Number);
            }

            for (i = 0; i < Nums.Count; i++)
            {
                //nums == 6
                //1 + 3 = 4 -- 3 + 3 == 6 -- 4 + 3 = 7 == 1 (123123)
                if ((i + Nums.Count / 2) >= Nums.Count)
                {
                    Console.WriteLine("Nums count = " + Nums.Count + " & your at " + i);
                    Console.WriteLine("trying to get number " + (i - Nums.Count / 2) + "");
                    if (Nums[i] == Nums[i - Nums.Count / 2])
                    {
                        CodeSum += Nums[i];
                    }
                }
                else
                {
                    Console.WriteLine("Nums count = " + Nums.Count + " & your at " + i);
                    Console.WriteLine("trying to get number " + (i + Nums.Count / 2) + "");
                    if (Nums[i] == Nums[i + Nums.Count / 2])
                    {
                        CodeSum += Nums[i];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(CodeSum);
            Console.WriteLine();
            Nums.Clear();
            CodeSum = 0;
            i = 0;
        }
    }
}

