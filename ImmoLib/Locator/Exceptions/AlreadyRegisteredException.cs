using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ImmoLib.Locator.Exceptions
{
     public class AlreadyRegisteredException : Exception
    {
        public AlreadyRegisteredException() { }

        public AlreadyRegisteredException(string message)
            : base(message)
        {
        }

        public AlreadyRegisteredException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected AlreadyRegisteredException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {
        }
    }
}
