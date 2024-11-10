using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.2 스택/큐 - 올바른 괄호
    public class Programmers12909
    {
        public bool solution(string s)
        {
            bool answer = true;

            Queue<char> frontChars = new Queue<char>();

            foreach (char c in s)
            {
                if (c == '(')
                {
                    frontChars.Enqueue(c);
                }

                if (c == ')')
                {
                    if (frontChars.Count > 0)
                    {
                        frontChars.Dequeue();
                    }
                    else
                    {
                        answer = false;
                    }
                }
            }

            if (frontChars.Count > 0)
            {
                answer = false;
            }

            return answer;
        }
    }
}
