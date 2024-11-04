using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 문자열 나누기
    public class Solution140108
    {
        public void solve(string s, ref int answer)
        {
            if (s.Length == 0) return;

            char firstChar = s[0];
            int splitLength = 0;
            int readLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == firstChar)
                {
                    splitLength++;

                    if (splitLength >= s.Length)
                    {
                        answer++;
                        break;
                    }
                }
                else
                {
                    readLength++;
                }

                if (splitLength == readLength || (splitLength + readLength) == s.Length)
                {
                    answer++;
                    s = s.Remove(0, (readLength + splitLength));
                    this.solve(s, ref answer);
                    return;
                }
            }
        }

        public int solution(string s)
        {
            int answer = 0;

            this.solve(s, ref answer);

            return answer;
        }
    }
}
