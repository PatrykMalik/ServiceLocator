using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceLocator.Exceptions
{
    public class ServiceLocatorException : Exception
    {
        public ServiceLocatorException()
        {
        }

        public ServiceLocatorException(string message) : base(message)
        {
        }

        public ServiceLocatorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ServiceLocatorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
