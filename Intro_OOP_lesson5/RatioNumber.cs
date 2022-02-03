using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson5
{
    public abstract class RatioNumber
    {
        public static RatioNumber operator ==(RatioNumber a, RatioNumber b) => new EqualRatioNumber(a, b);
        public static RatioNumber operator !=(RatioNumber a, RatioNumber b) => new InequalRatioNumber(a, b);
        public static RatioNumber operator <(RatioNumber a, RatioNumber b) => new InequalRatioNumber(a, b);
        public static RatioNumber operator >(RatioNumber a, RatioNumber b) => new OperatorMoreRatioNumber(a, b);
        public static RatioNumber operator >=(RatioNumber a, RatioNumber b) => new MoreOrEqualRatioNumber(a, b);
        public static RatioNumber operator <=(RatioNumber a, RatioNumber b) => new LessOrEqualRatioNumber(a, b);
        public static RatioNumber operator +(RatioNumber a, RatioNumber b) => new SumRatioNumber(a, b);
        public static RatioNumber operator -(RatioNumber a, RatioNumber b) => new DiffRatioNumber(a, b);
        public static RatioNumber operator ++(RatioNumber a) => new IncrementRatioNumber(a);
        public static RatioNumber operator --(RatioNumber a) => new DecrementRatioNumber(a);

        public abstract bool EqualsRatioNumber();
        public abstract ValueRatioNumber Compute();
    }
}