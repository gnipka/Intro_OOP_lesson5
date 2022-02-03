using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson5
{
    class DivRatioNumber : RatioNumber
    {
        private readonly RatioNumber _A;
        private readonly RatioNumber _B;

        public DivRatioNumber(RatioNumber a, RatioNumber b)
        {
            _A = a;
            _B = b;
        }
        public override ValueRatioNumber Compute()
        {
            var a = _A.Compute();
            var b = _B.Compute();
            return new ValueRatioNumber(a.Numerator / b.Numerator, a.Denumerator / b.Denumerator);
        }
        public override bool EqualsRatioNumber()
        {
            throw new NotImplementedException();
        }
    }
}
