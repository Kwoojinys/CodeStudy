using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 옹알이 (2)
    public class Programmers133499
    {
        public int solution(string[] babbling)
        {
            int answer = 0;
            string[] ableSpeak = { "aya", "ye", "woo", "ma" };

            for (int i = 0; i < babbling.Length; i++)
            {
                bool canSpeak = true;
                var word = babbling[i];
                var curWord = "";
                while (word.Length > 0)
                {

                    int prevLength = word.Length;
                    foreach (var speak in ableSpeak)
                    {
                        var check = word.Substring(0, Math.Min(speak.Length, word.Length));
                        if (check.Equals(curWord))
                        {
                            canSpeak = false;
                            break;
                        }

                        if (check.Equals(speak))
                        {
                            word = word.Remove(0, speak.Length);
                            curWord = speak;

                            if (word.Length == 0) break;
                        }
                    }

                    if (prevLength == word.Length)
                    {
                        canSpeak = false;
                        word = "";
                    }
                }

                if (canSpeak == true)
                {
                    answer++;
                }
            }

            return answer;
        }
    }
}
