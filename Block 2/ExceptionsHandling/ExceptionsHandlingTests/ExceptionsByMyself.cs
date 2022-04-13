using System;

namespace Lesson;

public class ExceptionsByMyself
{
    public int OnlyAdults(int age, string name)
    {
        int result = 1;
        try
        {
            MemberOfParty member = new MemberOfParty {Age = age, Name = name};
            return result;
        }
        catch (PersonException exception)
        {
            Console.WriteLine($"Warning: {exception.Message}");
            result = 0;
            return result;
        }
    }

    public int OnlyNameStartWithM(int age, string name)
    {
        int result = 1;
        try
        {
            MemberOfPartyNameM member = new MemberOfPartyNameM {Age = age, Name = name};
            return result;
        }
        catch (PersonException exception)
        {
            Console.WriteLine($"Warning: {exception.Message}");
            result = 0;
            return result;
        }
    }
}



public class MemberOfParty
{
    private int age;
    public int Age
    {
        get => age;
        set
        {
            if (value < 18)
            {
                throw new PersonException("The age of the member is still too young");
            }
            else
            {
                age = value;
            }
        }
    }
    public string Name { get; set; }
}

public class MemberOfPartyNameM : MemberOfParty
{
    public char firstLetter = 'M';
    private string name;

    public string Name
    {
        get => name;
        set
        {
            if (value[0].ToString() != Char.ToString(firstLetter))
            {
                throw new PersonException("This is a private party, " +
                                          "the first letter of your name prevents you from attending");
            }
            else
            {
                name = value;
            }
        }
    }
}
class PersonException : ArgumentException
{
    public PersonException(string message) : base(message)
    {
    }
}