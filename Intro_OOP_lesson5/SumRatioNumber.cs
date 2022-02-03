using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson5
{
    class SumRatioNumber : RatioNumber
    {
        private readonly RatioNumber _A;
        private readonly RatioNumber _B;

        public SumRatioNumber(RatioNumber a, RatioNumber b)
        {
            _A = a;
            _B = b;
        }
        public override ValueRatioNumber Compute()
        {
            var a = _A.Compute();
            var b = _B.Compute();
            var coef = a.Denumerator * b.Denumerator;
            return new ValueRatioNumber(coef / a.Denumerator * a.Numerator + coef / b.Denumerator * b.Numerator, coef).Compute();
        }
        public override bool EqualsRatioNumber()
        {
            throw new NotImplementedException();
        }
    }
}
