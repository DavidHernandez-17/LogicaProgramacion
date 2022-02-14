using System.Runtime.Serialization;

namespace Ejercicio01_PAR_IMPAR
{
    [Serializable]
    internal class numexception : Exception
    {
        public numexception()
        {
        }

        public numexception(string? message) : base(message)
        {
        }

        public numexception(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected numexception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}