using System;
using System.Linq;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string lowerInput = input.ToLower();
        var alphabet = "abcdefghijklmnopqrstuvwxyz";
        List<string> charList = new List<string>();

        foreach (var letter in alphabet)
        {
            if (lowerInput.Contains(letter) && charList.Contains(letter.ToString()) == false)
            {
                charList.Add(letter.ToString());
            }
        }

        return (charList.Count == alphabet.Length) ? true : false;
    }
}
