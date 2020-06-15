using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        string[] colorMap = Colors();
        for (int i = 0; i < colorMap.Length; i++)
        {
            if (colorMap[i] == color)
            {
                return i;
            }
        }
        return 100;
    }

    public static string[] Colors()
    {
        return new[] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
    }
}