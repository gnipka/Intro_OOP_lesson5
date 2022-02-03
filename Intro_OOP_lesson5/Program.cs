using System;

namespace Intro_OOP_lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ValueRatioNumber(19, 20);
            var b = new ValueRatioNumber(3, 20);
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
            var i = a + b;
            i.Compute();
            var j = a - b;
            j.Compute();
            var k = new ValueRatioNumber(5, 20);
            var l = a - b + k;
            l.Compute();
        }
    }
}
