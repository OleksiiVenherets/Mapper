using System;
using System.Runtime.Serialization;

namespace AutoMapper
{
    /// <summary>
    /// Custom Exception. Throws when sourse object have empty properties
    /// </summary>
    [Serializable]
    public class EmptyObjectException : Exception
    {
        public EmptyObjectException()
        {
        }

        public EmptyObjectException(string message) : base(message)
        {
        }

        public EmptyObjectException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyObjectException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}