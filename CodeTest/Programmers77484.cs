using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 2021 Dev-Matching : 웹 백엔드 개발자(상반기) - 로또의 최고 순위와 최저 순위
    public class Solution77484
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[] { };

            int unseenCount = 0;
            int correctCount = 0;
            foreach (int num in lottos)
            {
                if (num == 0)
                {
                    unseenCount++;
                }

                for (int i = 0; i < win_nums.Length; i++)
                {
                    if (win_nums[i] == num)
                    {
                        correctCount++;
                    }
                }
            }

            var rank = 7 - correctCount;

            answer = new int[] { Math.Min(6, 7 - correctCount - unseenCount), Math.Min(6, 7 - correctCount) };

            return answer;
        }
    }
}
