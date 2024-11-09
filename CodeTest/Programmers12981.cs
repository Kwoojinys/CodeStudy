using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.2 Summer/Winter Coding(~2018) - 영어 끝말잇기

    public class Programmers12981
    {
        public int[] solution(int n, string[] words)
        {
            int[] answer = { };

            List<string> impossibleWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                var round = i / n + 1;
                var man = i % n + 1;
                var curWord = words[i];

                if (impossibleWords.Contains(curWord) == true)
                {
                    answer = new int[] { man, round };
                    break;
                }

                impossibleWords.Add(curWord);

                if (i == 0) continue;

                var lastWord = words[i - 1];
                if (curWord[0] != lastWord[lastWord.Length - 1])
                {
                    answer = new int[] { man, round };
                    break;
                }

                if (i == words.Length - 1)
                {
                    answer = new int[] { 0, 0 };
                }
            }

            return answer;
        }
    }
}
