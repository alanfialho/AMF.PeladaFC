using System;
using System.Runtime.Serialization;

namespace Amf.PeladaFC.DomainModel.Core
{
    [Serializable]
    internal class ConviteJaAceitoException : ApplicationException
    {
        public ConviteJaAceitoException()
        {
        }

        public ConviteJaAceitoException(string message) : base(message)
        {
        }

        public ConviteJaAceitoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConviteJaAceitoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}