using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 기사단원의 무기
    public class Programmers136798
    {
        public int solution(int number, int limit, int power)
        {
            int answer = 0;

            for (int y = 1; y <= number; y++)
            {
                var divisorList = new List<int>();

                for (int i = 1; i <= y / 2; i++)
                {
                    if (y % i == 0)
                    {
                        divisorList.Add(i);
                    }
                }

                divisorList.Add(y);

                if (divisorList.Count > limit)
                {
                    answer += power;
                }
                else
                {
                    answer += divisorList.Count;
                }
            }


            return answer;
        }
    }
}
