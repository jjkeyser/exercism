using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string number = Regex.Replace(phoneNumber, "[^0-9]", "");

        if (number.Length > 11 
            || number.Length < 10
            || number[number.Length - 10] < '2'
            || number[number.Length - 7] < '2'
            || (number.Length == 11 && number[0] != '1')
           )
        {
            throw new ArgumentException("Invalid phone number length");
        }

        return number.Length == 11 ? number.Substring(1) : number;
    }
}
