using System;
using System.Runtime.Serialization;

namespace FinalCodingChallenge.DataAccess.Services
{
    [Serializable]
    internal class FlightsNotFoundException : Exception
    {
        public FlightsNotFoundException()
        {
        }

        public FlightsNotFoundException(string message) : base(message)
        {
        }

        public FlightsNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FlightsNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}