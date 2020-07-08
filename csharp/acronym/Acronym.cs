using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] splitChars = {' ', '-', '_'};
        string[] phrase_list = phrase.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
        string acronym = "";
        
        foreach (string word in phrase_list)
        {
            acronym += word.Substring(0,1);
        }
        
        return acronym.ToUpper();
    }
}