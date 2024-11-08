using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 소수 찾기

    public class Programmers12921
    {
        public int solution(int n)
        {
            List<int> primeList = new List<int>(n + 1);

            for (int i = 0; i <= n; i++)
            {
                primeList.Add(i);
            }

            for (int i = 2; i <= n; i++)
            {
                if (primeList[i] == 0) continue;
                for (int j = i + i; j <= n; j += i)
                {
                    primeList[j] = 0;
                }
            }

            return primeList.Where(x => x > 1).ToList().Count();
        }
    }
}
