using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.2 연습문제 - N개의 최소공배수

    public class Solution12953
    {
        public int solution(int[] arr)
        {
            int answer = 0;

            Array.Sort(arr, (a, b) => a >= b ? 1 : -1);

            int startNum = arr[arr.Length - 1];
            int correctCount = 0;
            for (int i = startNum; i < int.MaxValue; i += startNum)
            {
                correctCount = 0;
                for (int y = 0; y < arr.Length - 1; y++)
                {
                    var targetNum = arr[y];

                    if (i % targetNum == 0)
                    {
                        correctCount++;
                    }
                }

                if (correctCount == (arr.Length - 1))
                {
                    answer = i;
                    break;
                }
            }

            return answer;
        }
    }
}
