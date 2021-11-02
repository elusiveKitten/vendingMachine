using System;
using System.Runtime.Serialization;

namespace Capstone.Classes
{
    [Serializable]
    internal class InvalidSelectionException : Exception
    {
        public InvalidSelectionException()
        {
        }

        public InvalidSelectionException(string message) : base(message)
        {
        }

        public InvalidSelectionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidSelectionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}