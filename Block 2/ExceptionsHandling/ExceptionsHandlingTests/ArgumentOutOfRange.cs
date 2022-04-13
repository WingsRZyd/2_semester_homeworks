using System;
using System.Collections.Generic;

namespace Lesson;

public class ArgumentOutOfRange
{
    public int ArgumentOut(int count)
    {
        var list = new List<int>();
        int result = 1;
        for (int i = 0; i < count; i++)
        {
            list.Add(i + 1);
        }

        for (int i = 0; i <= count; i++)
        {
            try
            {
                Console.WriteLine(list[i + count]);
                result = 1;
                return result;
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine($"Warning: {exception.Message}");
                result = 0;
                return result;
            }
        }
        return result;
    }
}