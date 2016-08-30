using System;
using System.Runtime.Serialization;

namespace Amf.PeladaFC.DomainModel.Core
{
    [Serializable]
    internal class ConviteNaoAceitoException : Exception
    {
        public ConviteNaoAceitoException()
        {
        }

        public ConviteNaoAceitoException(string message) : base(message)
        {
        }

        public ConviteNaoAceitoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConviteNaoAceitoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}