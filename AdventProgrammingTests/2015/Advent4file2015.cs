using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; // Encoding.ASCII
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Data; // MD5

internal class Advent4file2015
{
    public int a = 0;
    public int ColorChanger;

    public string OutputHexText = "";

    public byte[] output;

    public string Hash_String;
    public List<string> Hex_List = new List<string>();

    public void Start()
    {
        MD5 md5 = MD5.Create();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solving Day 4");
        Console.ResetColor();
        Console.WriteLine("");
        string[] lines = File.ReadLines("2015Day4file.txt").ToArray();

        //Part 1
        Console.WriteLine("Part 1:");

        for (int li = 0; li < lines.Length; li++)
        {
            string line = lines[li];
            //Console.WriteLine("");
            //Console.WriteLine(line);

            byte[] code = System.Text.Encoding.ASCII.GetBytes(line);
            for (int i = 0; i < line.Length; i++)
            {
                //Console.WriteLine("{0} ASCII: {1} code: {2}", line[ColorChanger], (int)line[ColorChanger], code[ColorChanger]);
            }

            byte[] output = md5.ComputeHash(code);

            //Console.WriteLine("");

            //Real Testing input

            //for (int i = 0; i < output.Length; i++)
            //{
            //    a = (int)output[i];
            //    ConvertDecimalToHexadecimal();
            //}
            //Console.Write("___ \n" + OutputHexText + "\n ___");
            //OutputHexText = "";

            //Console.ResetColor();

        }

        Hex_List.Clear ();
        //output = new byte[0];
        //Console.WriteLine("\n START CRUNCHING!");
        //TryFetchAnswerPart1();
        Console.WriteLine("bgvyzdsv254575 = 000004b30d481662b9cb0c105f6549b2 || First one with 5 zeros is 254575");


        Hex_List.Clear();
        OutputHexText = "";

        //4073186=000004
        //your answer is too high
        //this is because of my multiple call instead of calling the whole line as one code line i was counting it per byte

        //254575 = 000004b30d481662b9cb0c105f6549b2
        //Correct Answer 

        Console.WriteLine("");
        //Part 2
        Console.WriteLine("Part 2:");

        //TryFetchAnswerPart2();

        Console.WriteLine("bgvyzdsv1038736 = 000000b1b64bf5eb55aad89986126953 || First one with 6 zeros is 1038736");


        Console.WriteLine("");
        for (int li = 0; li < lines.Length; li++)
        {
            string line = lines[li];

        }

    }

    void ConvertDecimalToHexadecimal() // why not return type?
    {
        //new
        string HexText = "0123456789abcdef";
        char left = HexText[a / 16];
        char right = HexText[a % 16];
        //Console.Write(left + "" + right + " ");
        OutputHexText += (left + "" + right);
        //Hex_List.Add(left + "" + right + "");

        //Hex_List.Add(OutputHexText + "\n");

        //Hex_List.Add("X");
    }

    void TryFetchAnswerPart1()
    {    
        int z = 0;
        int i = 0;
        int y = 0;
        while (z == 0)
        {
            i++;
            y++;
            MD5 md5 = MD5.Create();
            byte[] code = System.Text.Encoding.ASCII.GetBytes("bgvyzdsv" + i);
            output = md5.ComputeHash(code);

            //HashToDecimal();

            for (int j = 0; j < output.Length; j++) // i again??!!
            {
                a = (int)output[j];
                ConvertDecimalToHexadecimal(); // what's the output?
            }

            Hex_List.Add(OutputHexText + "\n");

            OutputHexText = "";

            if (Hex_List[i-1].StartsWith("00000") || Hex_List[i-1].StartsWith("000000"))
            {
                if (z == 0)
                {
                    Console.WriteLine(y + " = " + Hex_List[i-1]);
                    Console.WriteLine("So the code to get atleast five 0's in a row = bgvyzdsv" + y);
                    z = 1;
                }
            }
            else
            {
                //Hex_List.Clear();
            }

            if (i > 1e7)
            {
                z = 1;
            }
        }
    }

    void TryFetchAnswerPart2()
    {
        int z = 0;
        int i = 0;
        int y = 0;
        while (z == 0)
        {
            i++;
            y++;
            MD5 md5 = MD5.Create();
            byte[] code = System.Text.Encoding.ASCII.GetBytes("bgvyzdsv" + i);
            output = md5.ComputeHash(code);

            //HashToDecimal();

            for (int j = 0; j < output.Length; j++) // i again??!!
            {
                a = (int)output[j];
                ConvertDecimalToHexadecimal(); // what's the output?
            }

            Hex_List.Add(OutputHexText + "\n");

            OutputHexText = "";

            if (Hex_List[i - 1].StartsWith("000000"))
            {
                if (z == 0)
                {
                    Console.WriteLine(y + " = " + Hex_List[i - 1]);
                    Console.WriteLine("So the code to get atleast six 0's in a row = bgvyzdsv" + y);
                    z = 1;
                }
            }
            else
            {
                //Hex_List.Clear();
            }

            if (i > 1e7)
            {
                z = 1;
            }
        }
    }
    void HexaDecimalCode()
    {
        //new
        string HexText = "0123456789abcdef";
        for (int i = 0; i < 256; i++)
        {
            char left = HexText[i / 16];
            char right = HexText[i % 16];
            Console.Write(left + "" + right + " ");
        }
    }
}

