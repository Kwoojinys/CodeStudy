using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 탐욕법 - 체육복
    public class Programmers42862
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            int answer = 0;

            List<int> students = new List<int>();
            answer = n - lost.Length;
            Array.Sort(reserve, (x, y) => x > y ? 1 : -1);
            Array.Sort(lost, (x, y) => x > y ? 1 : -1);
            for (int i = 0; i < reserve.Length; i++)
            {
                var lostIndex0 = Array.IndexOf(lost, reserve[i]);
                if (Array.IndexOf(lost, reserve[i]) >= 0)
                {
                    lost[lostIndex0] = -1;
                    reserve[i] = -1;
                    answer++;
                    continue;
                }

                var lostIndex2 = Array.IndexOf(lost, reserve[i] - 1);
                if (lostIndex2 >= 0 && Array.IndexOf(reserve, reserve[i] - 1) < 0)
                {
                    lost[lostIndex2] = -1;
                    reserve[i] = -1;
                    answer++;
                    continue;
                }

                var lostIndex = Array.IndexOf(lost, reserve[i] + 1);
                if (lostIndex >= 0 && Array.IndexOf(reserve, reserve[i] + 1) < 0)
                {
                    lost[lostIndex] = -1;
                    reserve[i] = -1;
                    answer++;
                }

            }

            return answer;
        }
    }
}
