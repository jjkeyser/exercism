using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> count = 
            new Dictionary<char, int>()
            {
                {'A', 0},
                {'C', 0},
                {'G', 0},
                {'T', 0},            
            };

        foreach (var letter in sequence.ToUpper())
        {
            if (!count.ContainsKey(letter))
                throw new ArgumentException("Letter not a valid Nucleotide.");                
            count[letter]++;
        }
        return count;
    }
}