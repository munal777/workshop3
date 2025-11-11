using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Operator
{
    public static int AddNum(int x, int y)
    {
        return x + y;

    }
    public static int SubtractNum(int x, int y)
    {
        return x - y;
    }
    public static int MultiplyNum(int x, int y)
    {
        return x * y;
    }
    public static int DivideNum(int x, int y)
    {
        if (y == 0)
        {
            throw new DivideByZeroException("Denominator cannot be zero.");
        }
        return x / y;
    }

    public static String OddEvenFinder(int x)
    {
        return x % 2 == 0 ? "Even" : "Odd";
    }
}