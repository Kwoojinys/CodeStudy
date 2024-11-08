using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 푸드 파이트 대회
    public class Programmers134240
    {
        public string solution(int[] food)
        {
            string answer = "";

            for (int i = food.Length - 1; i >= 0; --i)
            {
                var foodCount = food[i] / 2;


                for (int j = 0; j < foodCount; j++)
                {
                    answer = answer.Insert(answer.Length, $"{i}");
                    answer = answer.Insert(0, $"{i}");
                }

                if (i == 0)
                {
                    answer = answer.Insert(answer.Length / 2, $"{i}");
                }
            }



            return answer;
        }
    }
}
