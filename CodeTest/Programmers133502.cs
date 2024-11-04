using System;
using System.Collections.Generic;

public class Programmers133502
{
    // 프로그래머스 Lv.1 연습문제 - 햄버거 만들기
    public int solution(int[] ingredient)
    {
        int answer = 0;

        List<int> ingredients = new List<int>();
        for (int i = 0; i < ingredient.Length; i++)
        {
            ingredients.Add(ingredient[i]);

            if (ingredients.Count >= 4)
            {
                if (string.Concat(ingredients.GetRange(ingredients.Count - 4, 4)) == "1231")
                {
                    answer++;
                    ingredients.RemoveRange(ingredients.Count - 4, 4);
                }
            }
        }

        return answer;
    }
}