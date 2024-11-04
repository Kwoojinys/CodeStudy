using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 사과장수
    public class Programmers135808
    {
        public int solution(int k, int m, int[] score)
        {
            int answer = 0;

            List<int> scores = new List<int>();
            foreach (var s in score)
            {
                scores.Add(s);
            }

            Queue<int> apples = new Queue<int>();

            scores.Sort((a, b) => b.CompareTo(a));

            foreach (var a in scores)
            {
                apples.Enqueue(a);
            }

            var appleScore = k;
            var appleCount = 0;
            while (apples.Count > 0)
            {
                var appleInfo = apples.Dequeue();
                if (appleInfo < k)
                {
                    appleScore = appleInfo;
                }

                appleCount++;

                if (appleCount == m)
                {
                    answer += appleScore * appleCount;
                    appleScore = k;
                    appleCount = 0;
                }
            }

            return answer;
        }
    }
}
