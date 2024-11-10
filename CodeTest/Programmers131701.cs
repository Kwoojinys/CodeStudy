using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.2 연습문제 - 연속 부분 수열 합의 개수
    public class Programmers131701
    {
        public int Calculate(int[] elements, int start, int range)
        {
            int sum = 0;
            for (int i = 0; i < range; i++)
            {
                var index = (i + start + elements.Length) % elements.Length;

                sum += elements[index];
            }

            return sum;
        }

        public int solution(int[] elements)
        {
            int answer = 0;

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < elements.Length; i++)
            {
                int range = i + 1;
                for (int y = 0; y < elements.Length; y++)
                {
                    var number = this.Calculate(elements, y, range);
                    if (numbers.ContainsKey(number) == false)
                    {
                        numbers.Add(number, 1);
                    }
                }
            }

            return numbers.Keys.Count;
        }
    }
}
