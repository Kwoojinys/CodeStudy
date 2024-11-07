using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 명예의 전당 (1)
    public class Solution138477
    {
        public int[] solution(int k, int[] score)
        {
            int[] answer        = new int[] { };
            int[] hallOfFame    = new int[] { };

            Array.Resize<int>(ref answer, score.Length);
            Array.Resize<int>(ref hallOfFame, k);

            for (int i = 0; i < hallOfFame.Length; i++)
            {
                hallOfFame[i] = -1;
            }

            for (int y = 0; y < score.Length; y++)
            {
                var s = score[y];

                for (int i = 0; i < hallOfFame.Length; i++)
                {
                    if (hallOfFame[i] < s)
                    {
                        hallOfFame[i] = s;
                        break;
                    }
                }

                Array.Sort(hallOfFame, (a, b) => a >= b ? 1 : -1);

                answer[y] = int.MaxValue;
                foreach (var hall in hallOfFame)
                {
                    if (hall >= 0)
                    {
                        if (answer[y] > hall)
                        {
                            answer[y] = hall;
                        }
                    }
                }
            }

            return answer;
        }
    }
}
