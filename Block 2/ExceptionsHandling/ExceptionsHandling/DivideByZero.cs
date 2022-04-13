using System;

namespace Lesson;

public class DivideByZero
{
    public void FindAShareOfThePie()
    {
        Console.WriteLine("Enter the number of people who will eat pie:");
        int pie = 500;
        int numberOfPeople = Int32.Parse(Console.ReadLine());
        DivideByZero1(pie, numberOfPeople);
    }
        
    public int DivideByZero1(int dividend, int divisor)
    {
        int piece;
        try
        {
            piece = dividend / divisor;
            return piece;
        }
        catch (DivideByZeroException exception)
        {
            Console.WriteLine($"Warning: {exception.Message}");
            piece = 0;
            return piece;
        }
    }
}