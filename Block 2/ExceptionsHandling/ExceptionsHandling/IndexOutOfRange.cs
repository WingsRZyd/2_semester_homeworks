using System;

namespace Lesson;

public class IndexOutOfRange
{
    public int IndexOut(int count)
    {
        var array = new int[count];
        int result = 1;
        for (int i = 0; i <= array.Length; i++)
        {
            try
            {
                array[i] = i + 1;
                Console.WriteLine(array[i]);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine($"Warning: {exception.Message}");
                result = 0;
                return result;
            }
        }
        return result;
    }
}