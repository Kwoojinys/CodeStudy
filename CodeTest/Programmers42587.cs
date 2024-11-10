using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.2 스택/큐 - 프로세스
    internal class Programmers42587
    {
        public int solution(int[] priorities, int location)
        {
            int answer = 0;

            Queue<int[]> process = new Queue<int[]>();
            Queue<int[]> wait = new Queue<int[]>();
            Queue<int[]> worked = new Queue<int[]>();
            Dictionary<int, int> processCount = new Dictionary<int, int>();

            int pri = 0;

            for (int i = 0; i < priorities.Length; i++)
            {
                process.Enqueue(new int[] { priorities[i], i });
                if (pri < priorities[i])
                {
                    pri = priorities[i];
                }

                if (processCount.ContainsKey(priorities[i]) == false)
                {
                    processCount.Add(priorities[i], 1);
                }
                else
                {
                    processCount[priorities[i]]++;
                }
            }

            while (process.Count > 0)
            {
                var pr = process.Dequeue();
                if (pr[0] == pri)
                {
                    worked.Enqueue(pr);

                    if (pr[1] == location)
                    {
                        answer = worked.Count;
                        break;
                    }

                    processCount[pr[0]]--;
                    if (processCount[pr[0]] == 0)
                    {
                        processCount.Remove(pr[0]);
                    }

                    for (int i = pri; i > 0; i--)
                    {
                        if (processCount.ContainsKey(i) == true)
                        {
                            pri = i;
                            break;
                        }
                    }
                }
                else
                {
                    wait.Enqueue(pr);
                }

                if (process.Count == 0)
                {
                    while (wait.Count > 0)
                    {
                        process.Enqueue(wait.Dequeue());
                    }
                }
            }

            return answer;
        }
    }
}
