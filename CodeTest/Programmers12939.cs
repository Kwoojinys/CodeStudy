using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // ���α׷��ӽ� Lv.2 ��������  - �ִ񰪰� �ּڰ�
    public class Solution12939
    {
        public string solution(string s)
        {
            string answer = "";

            string[] numberStrings = s.Split(' ');

            int maxValue = int.MinValue;
            int minValue = int.MaxValue;

            foreach (var numString in numberStrings)
            {
                int number = int.Parse(numString);

                if (number > maxValue)
                {
                    maxValue = number;
                }

                if (number < minValue)
                {
                    minValue = number;
                }
            }

            return $"{minValue} {maxValue}";
        }
    }
}
