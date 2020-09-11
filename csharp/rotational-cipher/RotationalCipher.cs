using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            char letter = chars[i];
            if (!Char.IsLetter(letter))
            {
                chars[i] = letter;
                continue;
            }
            char d = char.IsUpper(letter) ? 'A' : 'a';
            chars[i] = (char)((((letter + shiftKey) - d) % 26) + d);
        }
        return new string(chars);
    }
}