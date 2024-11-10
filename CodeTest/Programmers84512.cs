using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.2 완전탐색 - 모음사전

    public class Programmers84512
    {
        public int IndexOf(string[] arr, string s)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == s)
                    return i;
            }

            return 0;
        }

        public int GetWordCount(int idx)
        {
            int sum = 0;

            for (int i = 0; i < 5 - idx; i++)
            {
                sum += (int)Math.Pow(5, i);
            }

            return sum;
        }


        public int solution(string word)
        {
            int answer = 0;

            string[] indexs = new string[] { "A", "E", "I", "O", "U" };

            for (int i = 0; i < 5; i++)
            {
                if (word.Length <= i)
                {
                    continue;
                }
                var index = IndexOf(indexs, word[i].ToString());
                answer += (index) * GetWordCount(i) + 1;
            }

            return answer;
        }
    }
}
