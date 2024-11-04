
using System.Collections;
using System.Collections.Generic;

namespace CodeTest
{
    // 프로그래머스 Lv.1 연습문제 - 달리기 경주
    public class Solution178871
    {
        public string[] solution(string[] players, string[] callings)
        {
            Dictionary<string, int> lastPlayersRank = new Dictionary<string, int>();
            
            foreach (string player in players)
            {
                lastPlayersRank.Add(player, lastPlayersRank.Count);   
            }

            for (int i = 0; i < callings.Length; i++)
            {
                int calledRank = lastPlayersRank[callings[i]];
                var passedPlayer = players[calledRank - 1];
                players[calledRank - 1] = callings[i];
                players[calledRank] = passedPlayer;

                lastPlayersRank[callings[i]] = calledRank - 1;
                lastPlayersRank[passedPlayer] = calledRank;
            }

            return players;
        }
    }
}
