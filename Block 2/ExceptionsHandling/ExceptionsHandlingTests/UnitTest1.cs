using NUnit.Framework;
using System;
using Lesson;

namespace ExceptionsHandlingTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void DivideByZeroExceptionSuccessTest()
        {
            var divide = new DivideByZero();
            Assert.AreEqual(5, divide.DivideByZero1(5, 1));
        }
    
        [Test]
        public void DivideByZeroExceptionFailTest()
        {
            var divide = new DivideByZero();
            Assert.AreEqual(0, divide.DivideByZero1(5, 0));
        }

        [Test]
        public void ArgumentOutOfRangeFailTest()
        {
            var argument = new ArgumentOutOfRange();
            Assert.AreEqual(0, argument.ArgumentOut(2));
        }

        [Test]
        public void OnlyAdultsSuccessTest()
        {
            var adult = new ExceptionsByMyself();
            Assert.AreEqual(1, adult.OnlyAdults(22, "Maria"));
        }
        
        [Test]
        public void OnlyAdultsFailTest()
        {
            var adult = new ExceptionsByMyself();
            Assert.AreEqual(0, adult.OnlyAdults(17, "Maria"));
        }

        [Test]
        public void OnlyNameStartWithMSuccessTest()
        {
            var adult = new ExceptionsByMyself();
            Assert.AreEqual(1, adult.OnlyNameStartWithM(22, "Maria"));
        }
        
        [Test]
        public void OnlyNameStartWithMFailTest()
        {
            var adult = new ExceptionsByMyself();
            Assert.AreEqual(0, adult.OnlyNameStartWithM(22, "John"));
        }
        
        [Test]
        public void FormatExceptionTest()
        {
            var format = new Format();
            Assert.AreEqual(0, format.FormatException("Hello"));
        }
        
        [Test]
        public void IndexOutOfRangeExceptionTest()
        {
            var index = new IndexOutOfRange();
            Assert.AreEqual(0, index.IndexOut(5));
        }

        [Test]
        public void InvalidCastTest()
        {
            var cast = new InvalidCast();
            Assert.AreEqual(0, cast.Cast());
        }

        [Test]
        public void NullExceptionTest()
        {
            var nullExc = new NullException();
            Assert.AreEqual(0, nullExc.Null());
        }

        [Test]
        public void OverflowExceptionTest()
        {
            var overflow = new Overflow();
            Assert.AreEqual(0, overflow.OverflowException());
        }
    }
}