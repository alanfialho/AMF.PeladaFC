using System;
using System.Runtime.Serialization;

namespace Amf.PeladaFC.DomainModel.Core
{
    [Serializable]
    internal class ConviteNaoEncontradoException : ApplicationException
    {
        public ConviteNaoEncontradoException()
        {
        }

        public ConviteNaoEncontradoException(string message) : base(message)
        {
        }

        public ConviteNaoEncontradoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConviteNaoEncontradoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}