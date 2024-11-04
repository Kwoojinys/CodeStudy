using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 월간 코드 챌린지 시즌1 - 두 개 뽑아서 더하기
    public class Solution68644
    {
        void BubbleSortFunc(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public int[] solution(int[] numbers)
        {
            int[] answer = new int[] { };

            for (int i = 0; i < numbers.Length; i++)
            {

                var firstNumber = numbers[i];
                var secondNumber = -1;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (j == i) continue;

                    secondNumber = numbers[j];

                    if (secondNumber >= 0)
                    {
                        var resultNumber = firstNumber + secondNumber;

                        if (Array.IndexOf(answer, resultNumber) == -1)
                        {
                            answer = answer.Append(resultNumber).ToArray();
                        }
                    }
                }

                this.BubbleSortFunc(answer);
            }

            return answer;
        }
    }
}
