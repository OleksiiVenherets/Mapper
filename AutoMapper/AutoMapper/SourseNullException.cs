using System;
using System.Runtime.Serialization;

namespace AutoMapper
{
    /// <summary>
    /// Custom Exception. Throws when objects is not instanced
    /// </summary>
    [Serializable]
    public  class ObjectNullException : Exception
    {
        public ObjectNullException()
        {
        }

        public ObjectNullException(string message) : base(message)
        {
        }

        public ObjectNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ObjectNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}