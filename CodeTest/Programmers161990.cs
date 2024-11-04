using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 바탕화면 정리
    public class Solution161990
    {
        public int[] solution(string[] wallpaper)
        {
            int[] answer = new int[] { -1, -1, 0, 0 };

            for (int i = 0; i < wallpaper.Length; i++)
            {
                for (int j = 0; j < wallpaper[0].Length; j++)
                {
                    if (wallpaper[i][j] == '#')
                    {
                        if (answer[0] == -1 || answer[0] > i)
                        {
                            answer[0] = i;
                        }

                        if (answer[1] == -1 || answer[1] > j)
                        {
                            answer[1] = j;
                        }

                        if (answer[2] <= i + 1)
                        {
                            answer[2] = i + 1;
                        }

                        if (answer[3] <= j + 1)
                        {
                            answer[3] = j + 1;
                        }
                    }
                }
            }

            return answer;
        }
    }
}
