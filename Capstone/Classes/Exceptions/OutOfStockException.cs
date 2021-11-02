﻿using System;
using System.Runtime.Serialization;

namespace Capstone.Classes
{
    [Serializable]
    internal class OutOfStockException : Exception
    {
        public OutOfStockException()
        {
        }

        public OutOfStockException(string message) : base(message)
        {
        }

        public OutOfStockException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OutOfStockException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}