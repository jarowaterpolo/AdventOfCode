using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

struct IVec2 // integer vector
{
    //x y cords
    public int x, y;

    public IVec2(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public static IVec2 operator +(IVec2 left, IVec2 right)
    {
        return new IVec2(left.x + right.x, left.y + right.y);
    }
    // TODO: operator- ? :-)

    public static IVec2 operator - (IVec2 left, IVec2 right)
    {
        return new IVec2(left.x - right.x, left.y - right.y);
    }

    public static IVec2 operator * (IVec2 left, IVec2 right)
    {
        return new IVec2(left.x * right.x, left.y * right.y);
    }

    public static IVec2 operator /(IVec2 left, IVec2 right)
    {
        return new IVec2(left.x / right.x, left.y / right.y);
    }

    public static bool operator==(IVec2 left, IVec2 right)
    {
        return left.x==right.x && left.y==right.y;
    }
    public static bool operator !=(IVec2 left, IVec2 right)
    {
        return !(left.x == right.x && left.y == right.y);
    }
    public IVec2 ArrowMove(char c)
    {
        switch (c) 
        {
            case '^': return new IVec2 (x, y + 1);
            case 'v': return new IVec2(x, y - 1);
            case '>': return new IVec2(x + 1, y);
            case '<': return new IVec2(x - 1, y);
            default: return this;
        }
    }
    public IVec2 RotateNumberMove(int r, int m)
    {
        switch (r)
        {
            case 0 : return new IVec2(x, y + m);
            case 90: return new IVec2(x + m, y);
            case 180: return new IVec2(x, y - m);
            case 270: return new IVec2(x - m, y);
            default: return this;
        }
    }
    public override string ToString()
    {
        return $"[{x},{y}]";
    }

    // TODO: Equals? HashCode? :-)
}



