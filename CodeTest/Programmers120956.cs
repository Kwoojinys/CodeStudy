using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.0 코딩테스트 입문 - 옹알이(1)
    public class Programmers120956
    {
        public int solution(string[] babbling)
        {
            int answer = 0;

            string[] ableSpeak = { "aya", "ye", "woo", "ma" };
            for (int i = 0; i < babbling.Length; i++)
            {
                var speaking = babbling[i];
                var canSpeak = true;
                while (speaking.Length > 0)
                {
                    int prevLength = speaking.Length;
                    foreach (var speak in ableSpeak)
                    {
                        var check = speaking.Substring(0, Math.Min(speak.Length, speaking.Length));
                        if (check.Equals(speak))
                        {
                            speaking = speaking.Remove(0, speak.Length);
                        }
                    }

                    if (prevLength == speaking.Length)
                    {
                        canSpeak = false;
                        speaking = "";
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
