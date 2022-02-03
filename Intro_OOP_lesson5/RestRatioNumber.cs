using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson5
{
    class RestRatioNumber : RatioNumber
    {
        private readonly RatioNumber _A;
        private readonly RatioNumber _B;

        public RestRatioNumber(RatioNumber a, RatioNumber b)
        {
            _A = a;
            _B = b;
        }
        public override ValueRatioNumber Compute()
        {
            var a = _A.Compute();
            var b = _B.Compute();
            return new ValueRatioNumber(a.Numerator % b.Numerator, 1);
        }
        public override bool EqualsRatioNumber()
        {
            throw new NotImplementedException();
        }
    }
}
