using System;
using System.Runtime.Serialization;

namespace Amf.PeladaFC.DomainModel.Core
{
    [Serializable]
    internal class ConviteRedundanteException : ApplicationException
    {
        public ConviteRedundanteException()
        {
        }

        public ConviteRedundanteException(string message) : base(message)
        {
        }

        public ConviteRedundanteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConviteRedundanteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}