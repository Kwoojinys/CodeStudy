using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 Summer/Winter Coding(~2018) - 예산
    public class Programmers12982
    {
        public int solution(int[] d, int budget)
        {
            int answer = 0;

            Array.Sort(d, (a, b) => a >= b ? 1 : -1);

            int remainBudget = budget;
            for (int i = 0; i < d.Length; i++)
            {
                var req = d[i];
                if (d[i] <= remainBudget)
                {
                    remainBudget -= d[i];
                    answer++;
                }
            }

            return answer;
        }
    }
}
