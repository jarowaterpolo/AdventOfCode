using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; // Encoding.ASCII
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Data; // MD5


internal class Advent4
{
    public int a;
    public int b;
    public int c;

    public string BText = "";
    public string CText = "";
    public void Start()
    {
        Console.WriteLine("Solving Day 4");

        MD5 md5 = MD5.Create();

        string inputTest = "abcdef609043";
        //0 0 1 219 191 163 165 200 58 45 80 100 41 199 176 14
        //00 00 01 db bf a3 a5 c8 3a 2d 50 64 29 c7 b0 0e

        //string inputTest = "bgvyzdsv";

        byte[] code = System.Text.Encoding.ASCII.GetBytes(inputTest);
        for (int i = 0; i < inputTest.Length; i++)
        {
            Console.WriteLine("{0} ASCII: {1} code: {2}", inputTest[i], (int)inputTest[i], code[i]);
        }

        byte[] output = md5.ComputeHash(code);
        for (int i = 0; i < output.Length; i++)
        {
            Console.Write(output[i] + " "); // TODO: convert to hex :-)  (You can do this yourself)
        }

        Console.WriteLine("");

        //Real Test

        for (int i = 0; i < output.Length; i++)
        {
            a = (int)output[i];
            ConvertDecimalToHexadecimal();
            b = 0;
            c = 0;
        }

        // byte values go from 0 to 255 (in decimal notation) // 0-9
        //  ...or from 00 to ff (in hexadecimal notation) // 0-f (0-16)
        // TODO: Find the first five "digits" when converting the whole output code to hex (two digits per byte!)

        // a==97 decimal || a==61 hexadecimal
        // 6 * 16 + 1

        // b==98 decimal || b==62 hexadecimal
        // 6 * 16 + 2

        //0==48 decimal || 0==30 hexadecimal
        // 3 * 16 + 0

        //decimal 0 == hexadecimal 00
        //decimal 1 == hexadecimal 01
        //decimal 2 == hexadecimal 02
        //decimal 3 == hexadecimal 03
        //decimal 4 == hexadecimal 04
        //decimal 5 == hexadecimal 05
        //decimal 6 == hexadecimal 06
        //decimal 7 == hexadecimal 07
        //decimal 8 == hexadecimal 08
        //decimal 9 == hexadecimal 09
        //decimal 10 == hexadecimal 0a
        //decimal 11 == hexadecimal 0b
        //decimal 12 == hexadecimal 0c
        //decimal 13 == hexadecimal 0d
        //decimal 14 == hexadecimal 0e
        //decimal 15 == hexadecimal 0f
        //decimal 16 == hexadecimal 10

        Console.WriteLine("");

        //int testinput = 16 * 15;
        //a = testinput;

        //ConvertDecimalToHexadecimal();
    }


    void ConvertDecimalToHexadecimal()
    {
        while (a > 0)
        {
            if (a >= 16)
            {
                a -= 16;
                c++;
            }
            else
            {
                a--;
                b++;
            }
        }



        if (b > 9 && c > 9)
        {
            CheckB();
            CheckC();
            Console.Write(CText + "" + BText + " ");
        }
        else if (b > 9)
        {
            CheckB();
            Console.Write(c + "" + BText + " ");
        }
        else if (c > 9)
        {
            CheckC();
            Console.Write(CText + "" + b + " ");
        }
        else
        {
            Console.Write(c + "" + b + " ");
        }
    }

    void CheckB()
    {
        if (b == 10)
        {
            BText = "a";
        }
        else if (b == 11)
        {
            BText = "b";
        }
        else if (b == 12)
        {
            BText = "c";
        }
        else if (b == 13)
        {
            BText = "d";
        }
        else if (b == 14)
        {
            BText = "e";
        }
        else if (b == 15)
        {
            BText = "f";
        }
    }

    void CheckC()
    {
        if (c == 10)
        {
            CText = "a";
        }
        else if (c == 11)
        {
            CText = "b";
        }
        else if (c == 12)
        {
            CText = "c";
        }
        else if (c == 13)
        {
            CText = "d";
        }
        else if (c == 14)
        {
            CText = "e";
        }
        else if (c == 15)
        {
            CText = "f";
        }
    }
}

