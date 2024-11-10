using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    // 프로그래머스 Lv.0 코딩테스트 입문 - 안전지대
    public class Programmers120866
    {
        public int solution(int[,] board)
        {
            int answer = 0;

            var boardWidth = board.GetLength(0);
            var boardHeight = board.GetLength(1);
            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardWidth; y++)
                {
                    if (board[x, y] == 1)
                    {
                        for (int w = -1; w < 2; w++)
                        {
                            var hCoo = w + x;
                            if (w + x >= boardWidth || w + x < 0)
                            {
                                continue;
                            }

                            for (int h = -1; h < 2; h++)
                            {
                                var vCoo = h + y;

                                if (h + y >= boardHeight || h + y < 0)
                                {
                                    continue;
                                }

                                if (board[hCoo, vCoo] != 1)
                                {
                                    board[hCoo, vCoo] = 2;
                                }
                            }
                        }
                    }
                }
            }

            answer = boardWidth * boardHeight;
            foreach (var n in board)
            {
                if (n >= 1)
                {
                    answer--;
                }
            }

            return answer;
        }
    }
}
