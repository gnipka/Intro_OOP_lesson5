using System;

namespace Intro_OOP_lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ValueRatioNumber(3, 4);
            var b = new ValueRatioNumber(3, 5);
            var c = a == b;
            c.EqualsRatioNumber();
            var d = a != b;
            d.EqualsRatioNumber();
            var e = a > b;
            e.EqualsRatioNumber();
            var f = a < b;
            f.EqualsRatioNumber();
            var g = a >= b;
            g.EqualsRatioNumber();
            var h = a <= b;
            h.EqualsRatioNumber();
        }
    }
}
