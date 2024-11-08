using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 공원 산책
    public class Programmers172928
    {
        public int[] solution(string[] park, string[] routes)
        {
            int[] answer = new int[] { 0, 0 };

            int[,] pm = new int[park.Length, park[0].Length];

            // 공원 지도 데이터화, 0 = 시작, 1 = 이동가능, 2 = 장애물

            for (int i = 0; i < park.Length; i++)
            {
                for (int j = 0; j < park[i].Length; j++)
                {
                    switch (park[i][j])
                    {
                        case 'S':
                            {
                                pm[i, j] = 0;
                                answer = new int[] { i, j };
                                break;
                            }
                        case 'O':
                            {
                                pm[i, j] = 1;
                                break;
                            }
                        case 'X':
                            {
                                pm[i, j] = 2;
                                break;
                            }
                    }
                }
            }

            // 루트에 따른 이동
            foreach (var routeInfo in routes)
            {
                var direction = routeInfo.Split(' ')[0];
                var distance = int.Parse(routeInfo.Split(' ')[1]);
                var prevP = answer;

                for (int i = 0; i < distance; i++)
                {
                    var moveInfo = this.GetDirection(direction);
                    int[] np = new int[] { answer[0] + moveInfo[0], answer[1] + moveInfo[1] };

                    if (np[0] >= pm.GetLength(0) || np[1] >= pm.GetLength(1))
                    {
                        answer = prevP;
                        break;
                    }

                    if (np[0] < 0 || np[1] < 0 || pm[np[0], np[1]] == 2)
                    {
                        answer = prevP;
                        break;
                    }

                    answer = np;
                }
            }

            return answer;
        }

        public int[] GetDirection(string routeInfo)
        {
            switch (routeInfo)
            {
                case "W":
                    {
                        return new int[] { 0, -1 };
                    }
                case "E":
                    {
                        return new int[] { 0, 1 };
                    }
                case "S":
                    {
                        return new int[] { 1, 0 };
                    }
                case "N":
                    {
                        return new int[] { -1, 0 };
                    }
                default:
                    return new int[] { 0, 0 };
            }
        }

    }
}