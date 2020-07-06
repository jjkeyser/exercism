using System;
using System.Collections.Generic;

public static class Pangram
{
    static HashSet<char> alphabet = new HashSet<char>("abcdefghijklmnopqrstuvwxyz");

    public static bool IsPangram(string input)
    {
        return alphabet.IsSubsetOf(input.ToLower());
    }
}
