using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.2 연습 문제 - 할인 행사
    public class Programmers131127
    {
        public int solution(string[] want, int[] number, string[] discount)
        {
            int answer = 0;

            Dictionary<string, int> wantGoods = new Dictionary<string, int>();
            Dictionary<string, int> discountGoods = new Dictionary<string, int>();
            for (int i = 0; i < want.Length; i++)
            {
                wantGoods.Add(want[i], number[i]);
            }


            for (int i = 0; i <= discount.Length - 10; i++)
            {
                var goods = new string[10];
                Array.Copy(discount, i, goods, 0, 10);

                discountGoods.Clear();

                foreach (var good in goods)
                {
                    if (discountGoods.ContainsKey(good) == false)
                    {
                        discountGoods.Add(good, 1);
                    }
                    else
                    {
                        discountGoods[good]++;
                    }
                }

                var count = 0;
                foreach (var good in discountGoods)
                {
                    if (wantGoods.ContainsKey(good.Key) == true)
                    {
                        if (wantGoods[good.Key] == good.Value)
                        {
                            count += good.Value;
                        }
                    }
                }

                if (count >= 10)
                {
                    answer++;
                }
            }

            return answer;
        }
    }
}
