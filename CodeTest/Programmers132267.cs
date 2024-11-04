using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 콜라 문제
    public class Programmers132267
    {
        public int solution(int a, int b, int n)
        {
            int answer = 0;

            while (n >= 2 && n >= a)
            {
                answer += (n / a) * b;
                n = n % a + (n / a) * b;
            }

            return answer;
        }
    }
}
