using System;
using System.Collections.Generic;
using System.Text;
public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string number = CleanNumber(phoneNumber);

        if (number.Length > 11 || number.Length < 10)
        {
            throw new ArgumentException("Invalid phone number length");
        }

        if (number.Length == 11)
        {
            if (!CountryCodeIsOne(number))
            {
                throw new ArgumentException("The country code must be 1");
            }
            number = number.Substring(1);
        }
        
        if (!AreaCodeIsValid(number) || !ExchangeCodeIsValid(number))
        {
            throw new ArgumentException("Invalid phone number.");
        }

        return number;
    }

    private static string CleanNumber(string phoneNumber)
    {
        var number = new StringBuilder();
        foreach (char c in phoneNumber)
        {
            if (!char.IsPunctuation(c) && char.IsDigit(c))
            {
                number.Append(c);
            }
        }

        return number.ToString();
    }

    public static bool CountryCodeIsOne(string cleanNumber)
    {
        return char.GetNumericValue(cleanNumber[0]) == 1;
    }

    public static bool AreaCodeIsValid(string cleanNumber)
    {
        var number = (int)char.GetNumericValue(cleanNumber[0]);
        return number > 1 && number < 10;
    }

    public static bool ExchangeCodeIsValid(string cleanNumber)
    {
        var number = (int)char.GetNumericValue(cleanNumber[3]);
        return number > 1 && number < 10;
    }
}