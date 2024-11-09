using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.2 연습문제 - 롤케이크 자르기
    public class Programmers132265
    {
        public int solution(int[] topping)
        {
            int answer = 0;

            Dictionary<int, int> firstPiece = new Dictionary<int, int>();
            Dictionary<int, int> secondPiece = new Dictionary<int, int>();

            foreach (var top in topping)
            {
                if (firstPiece.ContainsKey(top) == false)
                {
                    firstPiece.Add(top, 1);
                }
                else
                {
                    firstPiece[top]++;
                }
            }

            for (int i = topping.Length - 1; i > 0; i--)
            {
                var top = topping[i];
                if (firstPiece.ContainsKey(top) == true)
                {
                    firstPiece[top]--;

                    if (firstPiece[top] == 0)
                    {
                        firstPiece.Remove(top);
                    }

                    if (secondPiece.ContainsKey(top) == false)
                    {
                        secondPiece.Add(top, 1);
                    }
                    else
                    {
                        secondPiece[top]++;
                    }
                }

                if (firstPiece.Keys.Count == secondPiece.Keys.Count)
                {
                    answer++;
                }
            }

            return answer;
        }
    }
}
