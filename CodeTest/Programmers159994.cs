using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 카드 뭉치
    public class Programmers159994
    {
        public string solution(string[] cards1, string[] cards2, string[] goal)
        {
            string answer = "Yes";

            for (int i = 0; i < goal.Length; i++)
            {
                var goalWord = goal[i];

                for (int y = 0; y < cards1.Length; y++)
                {
                    if (cards1[y].Equals(goalWord))
                    {
                        if (y > 1)
                        {
                            if (cards1[y - 1].Equals("") == false)
                            {
                                answer = "No";
                                break;
                            }
                        }

                        cards1[y] = "";
                    }
                }

                for (int y = 0; y < cards2.Length; y++)
                {
                    if (cards2[y].Equals(goalWord))
                    {
                        if (y > 1)
                        {
                            if (cards2[y - 1].Equals("") == false)
                            {
                                answer = "No";
                                break;
                            }
                        }

                        cards2[y] = "";
                    }
                }
            }

            return answer;
        }
    }
}
