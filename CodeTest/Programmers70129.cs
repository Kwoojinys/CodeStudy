using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 월간 코드 챌린지 시즌1 - 이진 변환 반복하기
    public class Solution70129
    {
        public int[] solution(string s)
        {
            int[] answer = new int[] { 0, 0 };

            string converted = s;
            while (converted.Equals("1") == false)
            {
                answer[0] += 1;
                foreach (char c in converted)
                {
                    if (c == '0')
                    {
                        answer[1]++;
                    }
                }

                converted = converted.Replace("0", "");
                converted = Convert.ToString(converted.Length, 2);
            }

            return answer;
        }
    }
}
