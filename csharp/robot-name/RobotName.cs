using System;
using System.Collections.Generic;

public class Robot
{
    private Random _rand = new Random();
    private string _name;
    private HashSet<string> _usedNames = new HashSet<string>();

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public Robot() => _name = GetName();
    
    private string GenerateNameChars()
    {
        var randChars = "";
        for (int i = 0; i < 2; i++)
        {
            randChars += (char)_rand.Next('A', 'Z');
        }

        return randChars;
    }

    private string GenerateNameDigits() => _rand.Next(100,1000).ToString();

    public string GetName() => GenerateNameChars() + GenerateNameDigits();

    public void Reset()
    {
        if (_usedNames.Contains(_name))
        {
            _usedNames.Remove(_name);
        }
        _name = GetName();
    }
}