using System;
using System.Runtime.Serialization;

namespace Day3_Assignment_18_07_2018_02
{
    [Serializable]
    internal class NoMatchException : Exception
    {
        public NoMatchException()
        {
        }

        public NoMatchException(string message) : base(message)
        {
        }

        public NoMatchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoMatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}