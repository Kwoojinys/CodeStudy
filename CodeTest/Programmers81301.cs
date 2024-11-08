using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 2021 카카오 채용연계형 인턴십 - 숫자 문자열과 영단어
    public class Programmers81301
    {
        public int solution(string s)
        {
            int answer = 0;

            string[] replaceArray = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            for (int i = 0; i < replaceArray.Length; i++)
            {
                s = s.Replace(replaceArray[i], i.ToString());
            }

            answer = int.Parse(s);

            return answer;
        }
    }
}
