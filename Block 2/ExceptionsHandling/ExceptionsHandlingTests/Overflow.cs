using System;

namespace Lesson;

public class Overflow
{
    public int OverflowException()
    {
        var number = 2147483647;
        int result = 1;
        try
        {
            number = checked(number + 1);
        }
        catch (OverflowException exception)
        {
            Console.WriteLine($"Warning: {exception.Message}");
            result = 0;
            return result;
        }
        return result;
    }
}