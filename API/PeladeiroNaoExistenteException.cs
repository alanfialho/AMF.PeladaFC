using System;
using System.Runtime.Serialization;

namespace Amf.PeladaFC.API
{
    [Serializable]
    internal class PeladeiroNaoExistenteException : ApplicationException
    {
        public PeladeiroNaoExistenteException()
        {
        }

        public PeladeiroNaoExistenteException(string message) : base(message)
        {
        }

        public PeladeiroNaoExistenteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PeladeiroNaoExistenteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}