using System;

namespace Lesson;

public class Format
{
    public int FormatException(string word)
    {
        int number;
        int result = 1;
        try
        {
            number = int.Parse(word);
            return result;
        }
        catch (FormatException exception)
        {
            Console.WriteLine($"Warning: {exception.Message}");
            result = 0;
            return result;
        }
    }
}