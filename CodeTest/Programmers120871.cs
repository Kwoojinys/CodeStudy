using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.0 코딩테스트 입문 - 저주의 숫자 3
    public class Programmers120871
    {
        public int solution(int n)
        {
            int answer = 0;

            var num = 1;
            for (int i = 1; i < n; i++)
            {
                var check = 1;

                while ((num + check) % 3 == 0 || (num + check).ToString().Contains("3") == true)
                {
                    check++;
                }

                num += check;
            }

            return num;
        }
    }
}
