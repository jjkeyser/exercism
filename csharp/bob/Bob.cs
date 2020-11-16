using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        bool hasLetters = statement.Any(char.IsLetter);
        bool hasLowerCaseLetters = statement.Any(char.IsLower);

        bool isQuestion = statement.TrimEnd().EndsWith('?');
        bool isEmpty = String.IsNullOrWhiteSpace(statement);

        bool isShouting = hasLetters && !hasLowerCaseLetters;

        string response = "Whatever.";

        if (isEmpty) 
        {
            response = "Fine. Be that way!";
        } 
        else if (isQuestion && isShouting)
        {
            response = "Calm down, I know what I'm doing!";
        }
        else if (isQuestion)
        {
            response = "Sure.";
        }
        else if (isShouting)
        {
            response = "Whoa, chill out!";
        }
        return response;
    }
}