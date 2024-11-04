using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 둘만의 암호
    public class Programmers155652
    {
        public string solution(string s, string skip, int index)
        {
            string answer = "";

            for (int i = 0; i < s.Length; i++)
            {
                int targetChar = (int)s[i];
                for (int j = 0; j < index; j++)
                {
                    if (skip.Contains((char)(targetChar + 1)) == true)
                    {
                        j--;
                    }

                    targetChar++;

                    if (targetChar > (int)'z')
                    {
                        int replaceChar = (int)'a';
                        if (skip.Contains((char)replaceChar))
                        {
                            while (skip.Contains((char)replaceChar) == true)
                            {
                                replaceChar++;
                            }
                        }

                        targetChar = replaceChar;
                    }

                }

                answer += (char)targetChar;
            }

            return answer;
        }
    }
}
