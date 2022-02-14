using System.Runtime.Serialization;

namespace Ejercicio01_PAR_IMPAR
{
    [Serializable]
    internal class NumException : Exception
    {
        public NumException()
        {
        }

        public NumException(string? message) : base(message)
        {
        }

        public NumException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NumException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}