using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int hamming = 0;
        
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException("The two strings must be the same length");
        }
        
        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (firstStrand[i] != secondStrand[i])
            {
                hamming ++;
            }
        }
        return hamming;
    }
}