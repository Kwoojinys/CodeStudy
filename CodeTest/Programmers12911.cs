using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.2 연습 문제 - 다음 큰 숫자
    public class Programmers12911
    {
        public int solution(int n)
        {
            int answer = 0;

            var originCount = 0;
            var originString = Convert.ToString(n, 2);
            foreach (var c in originString)
            {
                if (c == '1')
                {
                    originCount++;
                }
            }

            for (int i = n + 1; i <= 1000000; i++)
            {
                var twoNumberString = Convert.ToString(i, 2);
                int count = 0;
                foreach (var c in twoNumberString)
                {
                    if (c == '1')
                        count++;
                }

                if (count != originCount)
                {
                    continue;
                }

                answer = i;
                break;
            }


            return answer;
        }
    }
}
