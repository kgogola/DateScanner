using System;

namespace DateScanner.Exceptions
{
    public class BadAmountOfArgException: Exception
    {
        public BadAmountOfArgException() { }
        public BadAmountOfArgException(string message) : base(message) { }
    }
}
