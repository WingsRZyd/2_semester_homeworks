using System;

namespace Lesson;

public class InvalidCast
{
    public int Cast()
    {
        Person person = new Person();
        int result = 1;
        try
        {
            PersonWithId personId = (PersonWithId) person;
        }
        catch (InvalidCastException exception)
        {
            Console.WriteLine($"Warning: {exception.Message}");
            result = 0;
            return result;
        }
        return result;
    }
}

public class Person
{
    string name;
    public string Name { get; set; }
}

public class PersonWithId : Person
{
    string id;
    public string Id { get; set; }
}