using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.2 연습문제 - 귤 고르기
    public class Programmers138476
    {
        public int solution(int k, int[] tangerine)
        {
            int answer = 0;

            Dictionary<int, int> geul = new Dictionary<int, int>();

            foreach (var tan in tangerine)
            {
                if (geul.ContainsKey(tan) == false)
                {
                    geul.Add(tan, 1);
                }
                else
                {
                    geul[tan] += 1;
                }
            }

            int sizeType = 0;
            geul.OrderByDescending(val => val.Value).ToList().ForEach(size =>
            {
                if (k > 0)
                {
                    sizeType++;
                    k -= size.Value;
                }
            });

            answer = sizeType;

            return answer;
        }
    }
}
