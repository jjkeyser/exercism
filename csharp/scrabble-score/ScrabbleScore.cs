using System;
using System.Collections.Generic;
using System.Linq;
public static class ScrabbleScore
{
    private static IDictionary<int, char[]> SCORES = new Dictionary<int, char[]>()
    {
        {1, new char[] {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'}},
        {2, new char[]{'D', 'G'}},
        {3, new char[]{'B', 'C', 'M', 'P'}},
        {4, new char[]{'F', 'H', 'V', 'W', 'Y'}},
        {5, new char[]{'K'}},
        {8, new char[]{'J', 'X'}},
        {10, new char[]{'Q', 'Z'}}
    };
    
    public static int Score(string input)
    {
        char[] letters = input.ToUpper().ToCharArray();
        int score = 0;
        foreach (var letter in letters)
        {
            foreach (var key in SCORES.Keys)
            {
                if (SCORES[key].Contains(letter))
                {
                    score += key;
                }
            }
        }
        return score;
    }
}