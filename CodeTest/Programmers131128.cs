using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 숫자 짝꿍
    public class Programmers131128
    {
        public string solution(string X, string Y)
        {
            StringBuilder sb = new StringBuilder();

            Dictionary<int, int> ynumbersCount = new Dictionary<int, int>();
            Dictionary<int, int> xnumbersCount = new Dictionary<int, int>();
            List<int> test = new List<int>(5);

            test.Select(x => x != 0).ToList().Count();
            for (int i = 0; i < X.Length; i++)
            {
                var num = int.Parse(X[i].ToString());
                if (xnumbersCount.ContainsKey(num) == false)
                {
                    xnumbersCount.Add(num, 1);
                }
                else
                {
                    xnumbersCount[num]++;
                }
            }

            for (int i = 0; i < Y.Length; i++)
            {
                var num = int.Parse(Y[i].ToString());
                if (ynumbersCount.ContainsKey(num) == false)
                {
                    ynumbersCount.Add(num, 1);
                }
                else
                {
                    ynumbersCount[num]++;
                }
            }

            for (int i = 9; i >= 0; i--)
            {
                if (ynumbersCount.ContainsKey(i) && xnumbersCount.ContainsKey(i))
                {
                    if (i == 0)
                    {
                        if (sb.Length == 0)
                        {
                            return "0";
                        }
                    }

                    var repeatCount = ynumbersCount[i];
                    if (ynumbersCount[i] > xnumbersCount[i])
                    {
                        repeatCount = xnumbersCount[i];
                    }

                    for (int j = 0; j < repeatCount; j++)
                    {
                        sb.Append(i);
                    }
                }
            }

            if (sb.Length == 0)
            {
                return "-1";
            }

            return sb.ToString();
        }
    }
}
