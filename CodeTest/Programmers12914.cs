using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.2 연습 문제 - 멀리 뛰기
    // https://programmer-may.tistory.com/215 참조, 피보나치 수열
    public class Solution12914
    {
        public long solution(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;

            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                dp[i] = (dp[i - 1] + dp[i - 2]) % 1234567;
            }

            return dp[n];
        }
    }
}
