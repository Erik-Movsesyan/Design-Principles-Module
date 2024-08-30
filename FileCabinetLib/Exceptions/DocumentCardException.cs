using System;

namespace FileCabinetLib.Exceptions
{
    internal class DocumentCardException : Exception
    {
        internal DocumentCardException() { }

        internal DocumentCardException(string message) : base(message) { }

        internal DocumentCardException(string message, Exception innerException) : base(message, innerException) { }
    }
}
