using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson5
{
    class IncrementRatioNumber : RatioNumber
    {
        private readonly RatioNumber _A;
        private readonly RatioNumber _B;

        public IncrementRatioNumber(RatioNumber a)
        {
            _A = a;
        }
        public override ValueRatioNumber Compute()
        {
            var a = _A.Compute();
            return new ValueRatioNumber(a.Numerator + a.Denumerator, a.Denumerator).Compute();
        }
        public override bool EqualsRatioNumber()
        {
            throw new NotImplementedException();
        }
    }
}
