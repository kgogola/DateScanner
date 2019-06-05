using System;

namespace DateScanner.Exceptions
{
    public class BadDateFormatException : Exception
    {
        public BadDateFormatException(){}
        public BadDateFormatException(string message) : base(message) { }
    }
}
