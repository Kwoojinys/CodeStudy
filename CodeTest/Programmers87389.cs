using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 월간 코드 챌린지 시즌3 - 나머지가 1이 되는 수 찾기
    internal class Programmers87389
    {
        public int solution(int n)
        {
            int answer = 0;

            answer = n;
            for (int i = n; i > 0; i--)
            {
                if (n % i == 1)
                {
                    if (answer > i)
                    {
                        answer = i;
                    }
                }
            }

            return answer;
        }
    }
}
