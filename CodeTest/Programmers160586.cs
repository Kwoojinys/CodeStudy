using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 대충 만든 자판
    public class Solution160586
    {
        public int[] solution(string[] keymap, string[] targets)
        {
            List<int> answers = new List<int>();

            for (int i = 0; i < targets.Length; i++)
            {
                var targetString = targets[i];
                var totalInputCount = 0;
                for (int j = 0; j < targetString.Length; j++)
                {
                    var inputCount      = 100;
                    var impossibleCount = 0;

                    foreach (string map in keymap)
                    {
                        var ic = this.CalculateInputCount(map, targetString[j]);
                        if (ic > 0 && ic < inputCount)
                        {
                            inputCount = ic;
                        }

                        if (ic == -1) impossibleCount++;
                    }

                    if (impossibleCount == keymap.Length)
                    {
                        totalInputCount = -1;
                        break;
                    }

                    totalInputCount += inputCount;
                }

                answers.Add(totalInputCount);
            }

            return answers.ToArray();
        }

        public int CalculateInputCount(string keymap, char s)
        {
            for (int i = 0; i < keymap.Length; i++)
            {
                if (s == keymap[i])
                    return i + 1;
            }

            return -1;
        }
    }
}
