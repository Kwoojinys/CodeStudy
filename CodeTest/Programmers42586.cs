using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.2 연습문제 - 기능개발
    public class Programmers42586
    {
        public int[] solution(int[] progresses, int[] speeds)
        {
            int[] answer = new int[] { };

            List<int> workedCount = new List<int>();
            Queue<int> progress = new Queue<int>();

            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                int worked = 0;
                bool canDeploy = true;
                for (int x = 0; x < progresses.Length; x++)
                {
                    progress.Enqueue(progresses[x] + speeds[x] * i);
                }

                for (int y = 0; y < progresses.Length; y++)
                {
                    var p = progress.Dequeue();
                    if (p >= 100 && canDeploy == true)
                    {
                        worked++;
                    }
                    else
                    {
                        canDeploy = false;
                    }
                }

                if (worked > 0)
                {
                    if (worked > count)
                    {
                        workedCount.Add(worked - count);
                        count = worked;
                    }
                }

                if (worked >= progresses.Length)
                {
                    break;
                }
            }

            answer = workedCount.ToArray();

            return answer;
        }
    }
}
