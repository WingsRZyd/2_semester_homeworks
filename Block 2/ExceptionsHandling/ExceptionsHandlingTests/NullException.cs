using System;

namespace Lesson;

public class NullException
{
    public int Null()
    {
        string[] _null = null;
        string empty = " ";
        int result = 1;
        try 
        {
            string join = string.Join(empty,_null);
        }
        catch (ArgumentNullException exception) 
        {
            Console.WriteLine($"Warning: {exception.Message}");
            result = 0;
            return result;
        }
        return result;
    }
}