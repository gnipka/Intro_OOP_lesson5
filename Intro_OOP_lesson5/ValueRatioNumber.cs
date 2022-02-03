using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson5
{
    public class ValueRatioNumber : RatioNumber
    {
        private int _Numerator;
        private int _Denumerator;

        public int Numerator { get => _Numerator; set => _Numerator = value; }
        public int Denumerator { get => _Denumerator; set => _Denumerator = value; }

        public ValueRatioNumber(int numerator, int denumerator)
        {
            _Numerator = numerator;
            _Denumerator = denumerator;
        }
        /// <summary>
        /// Вычисление НОД для сокращения дроби
        /// </summary>
        /// <param name="n"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        private int Nod(int n, int d)
        {
            n = Math.Abs(n);
            d = Math.Abs(d);
            while (d != 0 && n != 0)
            {
                if (n % d > 0)
                {
                    var temp = n;
                    n = d;
                    d = temp % d;
                }
                else break;
            }
            if (d != 0 && n != 0) return d;
            return 1;
        }

        public override ValueRatioNumber Compute()
        {
            int nod = Nod(_Numerator, _Denumerator);
            return new ValueRatioNumber(_Numerator / nod, _Denumerator / nod);
        }

        public override bool EqualsRatioNumber()
        {
            throw new NotImplementedException();
        }
    }
}
