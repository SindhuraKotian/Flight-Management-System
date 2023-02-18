using System;
using System.Runtime.Serialization;

namespace FinalCodingChallenge.DataAccess.Services
{
    [Serializable]
    internal class NoPassengersException : Exception
    {
        public NoPassengersException()
        {
        }

        public NoPassengersException(string message) : base(message)
        {
        }

        public NoPassengersException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoPassengersException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}