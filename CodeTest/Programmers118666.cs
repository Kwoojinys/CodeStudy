using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 2022 KAKAO TECH INTERNSHIP - 성격 유형 검사하기
    public class Solution118666
    {
        public string solution(string[] survey, int[] choices)
        {
            string answer = "";

            Dictionary<string, int> scores = new Dictionary<string, int>()
            {
                {"R",0},
                {"T",0},
                {"C",0},
                {"F",0},
                {"J",0},
                {"M",0},
                {"A",0},
                {"N",0}
            };

            for (int i = 0; i < survey.Length; i++)
            {
                var val = survey[i];

                var score = Math.Abs(choices[i] - 4);
                var targetScore = val[0];
                if (choices[i] - 4 > 0)
                {
                    targetScore = val[1];
                }

                scores[targetScore.ToString()] += score;
            }

            for (int i = 0; i < scores.Count; i += 2)
            {
                answer += scores.Values.ElementAt(i) >= scores.Values.ElementAt(i + 1) ? 
                    scores.Keys.ElementAt(i) : scores.Keys.ElementAt(i + 1);
            }


            return answer;
        }
    }
}
