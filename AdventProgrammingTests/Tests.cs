using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Tests
{
    public static void DoTests()
    {
        IVec2 a = new IVec2(1, 2);
        IVec2 b = new IVec2(1, 3);
        Console.WriteLine(" a: {0} b: {1} are they equal? {2}",a,b,(a==b));

        IVec2 c = a + b; // uses our own operator!
        Console.WriteLine("Sum: {0}",c);

        // more string formatting examples:
        float f = 3.1415f;
        Console.WriteLine("Here's a float: {0:0.00}",f);

        HashSet<IVec2> vectorSet= new HashSet<IVec2>();
        vectorSet.Add(a);
        vectorSet.Add(b);
        Console.WriteLine("Number of vectors in our set: {0}",vectorSet.Count);


        b = a;
        b.x = 7;
        Console.WriteLine("a: {0} b: {1}",a,b);

        // convert to hex:
        string hexDigits = "0123456789abcdef";
        for (int i=0;i<256;i++)
        {
            // example: ColorChanger=18 (decimal) is 12 in hexadecimal -> leftDigit = 1, rightDigit = 2, since 1*16+2 = 18.
            char left = hexDigits[i / 16];
            char right = hexDigits[i % 16]; // modulo: remainder of division!
            Console.WriteLine("{0} in decimal is {1}{2} in hexadecimal",i,left,right);
        }
    }
}

