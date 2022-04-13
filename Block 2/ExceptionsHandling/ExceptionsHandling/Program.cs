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
            var divide = new DivideByZero();
            divide.FindAShareOfThePie();
            
            Console.WriteLine("\n2. Index out of range");
            var index = new IndexOutOfRange();
            index.IndexOut(5);

            Console.WriteLine("\n3. Invalid cast");
            var cast = new InvalidCast();
            cast.Cast();
            
            Console.WriteLine("\n4. Argument out of range");
            var argument = new ArgumentOutOfRange();
            argument.ArgumentOut(5);

            Console.WriteLine("\n5. Overflow exception");
            var overflow = new Overflow();
            overflow.OverflowException();

            Console.WriteLine("\n6. Format exception");
            var format = new Format();
            string word = Console.ReadLine();
            format.FormatException(word);
            
            Console.WriteLine("\n7. Argument null exception");
            var nullException = new NullException();
            nullException.Null();
            
            // Exceptions by myself
            Console.WriteLine("\n8. The age is small");
            var party = new ExceptionsByMyself();
            party.OnlyAdults(17, "John");

            Console.WriteLine("\n9. The invalid name");
            party.OnlyNameStartWithM(20, "John");
        }
    }
}