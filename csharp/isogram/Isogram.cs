using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var letters = new List<char>();
        var uniqueLetters = new HashSet<char>();
        foreach (char w in word.ToLower())
        {
            if (Char.IsLetter(w))
            {
                letters.Add(w);
                uniqueLetters.Add(w);
            }
        }
        return letters.Count == uniqueLetters.Count;
    }
}
