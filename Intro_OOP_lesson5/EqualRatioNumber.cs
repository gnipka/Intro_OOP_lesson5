using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson5
{
    public class EqualRatioNumber : RatioNumber
    {
        private readonly RatioNumber _A;
        private readonly RatioNumber _B;

        public EqualRatioNumber(RatioNumber a, RatioNumber b)
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
            return a.Numerator == b.Numerator && a.Denumerator == b.Denumerator;
            //if (a.Numerator != b.Numerator || a.Denumerator != b.Denumerator)
            //    return true;
            //else if (a.Numerator / b.Numerator == a.Denumerator / b.Denumerator)
            //    return true;
            //else if (b.Numerator / a.Numerator == b.Denumerator / a.Denumerator)
            //    return true;
            //else
            //    return false;
        }
    }
}
