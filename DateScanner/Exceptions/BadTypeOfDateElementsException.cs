using System;

namespace DateScanner.Exceptions
{
    public class BadTypeOfDateElementsException: Exception
    {
        public BadTypeOfDateElementsException() { }
        public BadTypeOfDateElementsException(string message) : base(message) { }
    }
}
