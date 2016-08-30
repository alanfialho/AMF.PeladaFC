using System;
using System.Runtime.Serialization;

namespace Amf.PeladaFC.API
{
    [Serializable]
    internal class PeladaNaoExistenteException : ApplicationException
    {
        public PeladaNaoExistenteException()
        {
        }

        public PeladaNaoExistenteException(string message) : base(message)
        {
        }

        public PeladaNaoExistenteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PeladaNaoExistenteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}