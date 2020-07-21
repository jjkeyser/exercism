using System;
using System.Collections.Generic;

public class Robot
{
    private static Random _rand = new Random();
    private string _name;
    private static HashSet<string> _usedNames = new HashSet<string>();

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public Robot() => _name = GetName();
    
    private string GenerateNameLetters()
    {
        var randLetters = "";
        for (int i = 0; i < 2; i++)
        {
            randLetters += (char)_rand.Next('A', 'Z');
        }

        return randLetters;
    }

    private string GenerateNameDigits() => _rand.Next(100,1000).ToString();

    public string GetName()
    {
        var robotName = "";
        while (true)
        {
            robotName = GenerateNameLetters() + GenerateNameDigits();
            if (IsNameUnique(robotName) == true)
            {
                break;
            }
        }
        _usedNames.Add(robotName);
        return robotName;
    }

    private bool IsNameUnique(string name) => _usedNames.Contains(name) ? false : true;

    public void Reset()
    {
        _name = GetName();
    }
}