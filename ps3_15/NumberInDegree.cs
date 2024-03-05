using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInDegreeClass
{
    internal class NubmerInDegree
    {
        private int num;
        private int degree;

        public NubmerInDegree(int n, int d)
        {
            num = n;
            degree = d;
        }

        public long Value
        {
            get
            {
                var value = 1;
                for (int i = 0; i < degree; i++) { value *= num; }
                return value;
            }
        }

        public static bool operator >(NubmerInDegree a, NubmerInDegree b)
        {
            return a.Value > b.Value;
        }

        public static bool operator <(NubmerInDegree a, NubmerInDegree b)
        {
            return a.Value < b.Value;
        }

        public static long operator -(NubmerInDegree a, NubmerInDegree b)
        {
            return a.Value - b.Value;
        }

        public static string[] MoreAndHowMuch(NubmerInDegree a, NubmerInDegree b)
        {
            string[] answer = new string[2];
            if (a > b)
            {
                answer[0] = "a > b";
                answer[1] = $"больше на {a - b}";
            }
            else if (a < b)
            {
                answer[0] = "a < b";
                answer[1] = $"больше на {b - a}";
            }
            else
            {
                answer[0] = "они равны";
            }

            return answer;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(this.Value);
            return sb.ToString();
        }
    }
}