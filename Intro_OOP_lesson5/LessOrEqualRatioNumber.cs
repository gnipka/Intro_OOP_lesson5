using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson5
{
    class LessOrEqualRatioNumber : RatioNumber
    {
        private readonly RatioNumber _A;
        private readonly RatioNumber _B;

        public LessOrEqualRatioNumber(RatioNumber a, RatioNumber b)
        {
            _A = a;
            _B = b;
        }

        public override ValueRatioNumber Compute()
        {
            throw new NotImplementedException();
        }

        public override bool EqualsRatioNumber()
        {

            var a = _A.Compute();
            var b = _B.Compute();
            var coef = a.Denumerator * b.Denumerator;
            return coef / a.Denumerator * a.Numerator <= coef / b.Denumerator * b.Numerator;
        }
    }
}
