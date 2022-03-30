using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using Microsoft.VisualBasic;

namespace Lesson
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Divide by zero");
            try
            {
                int zero = 0;
                int a = 5 / zero;
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine($"Warning: {exception.Message}");
            }
            
            Console.WriteLine("\n2. Index out of range");
            try
            {
                int[] array = new int[3];
                array[4] = 4;   
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine($"Warning: {exception.Message}");
            }
            
            Console.WriteLine("\n3. Invalid cast");
            Person person = new Person();
            try
            {
                PersonWithId personId = (PersonWithId) person;
            }
            catch (InvalidCastException exception)
            {
                Console.WriteLine($"Warning: {exception.Message}");
            }
            
            Console.WriteLine("\n4. Argument out of range");
            var list = new List<int>();
            try
            {
                Console.WriteLine($"{list[2]}");
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine($"Warning: {exception.Message}");
            }

            Console.WriteLine("\n5. Overflow exception");
            var number = 2147483647;
            try
            {
                number = checked(number + 1);
            }
            catch (OverflowException exception)
            {
                Console.WriteLine($"Warning: {exception.Message}");
            }

            Console.WriteLine("\n6. Format exception");
            
            string word = "Good";
            int number1;

            int Square(int number)
            {
                return (number * number);
            }
            
            try
            {
                number1 = Square(int.Parse(word));
            }
            catch (FormatException exception)
            {
                Console.WriteLine($"Warning: {exception.Message}");
            }

            Console.WriteLine("\n7. Argument null exception");
            
            string[] _null = null;
            string empty = " ";
            try 
            {
                string join = string.Join(empty,_null);
            }
            catch (ArgumentNullException exception) 
            {
                Console.WriteLine($"Warning: {exception.Message}");
            }
            
            // Exceptions by myself
            Console.WriteLine("\n8. The age is small");
            try
            {
                MemberOfParty member = new MemberOfParty {Age = 17, name = "John"};
            }
            catch (PersonException exception)
            {
                Console.WriteLine($"Warning: {exception.Message}");
            }
            
            Console.WriteLine("\n9. The invalid name");
            try
            {
                MemberOfPartyNameM member = new MemberOfPartyNameM {Age = 17, name = "John"};
            }
            catch (PersonException exception)
            {
                Console.WriteLine($"Warning: {exception.Message}");
            }
        }
    }
    public class Person
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    public class PersonWithId : Person
    {
        string id;
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }

    public class MemberOfParty
    {
        public int age;
        public string name;

        public int Age
        {
            get
            {
                return age;
            }
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
    }

    public class MemberOfPartyNameM : MemberOfParty
    {
        public char firstLetter = 'M';
        public string Name
        {
            get
            {
                return name;
            }
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
}