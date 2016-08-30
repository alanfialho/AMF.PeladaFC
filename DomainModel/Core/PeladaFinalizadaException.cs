using System;
using System.Runtime.Serialization;

namespace Amf.PeladaFC.DomainModel.Core
{
    [Serializable]
    internal class PeladaEncerradaException : ApplicationException
    {
        public PeladaEncerradaException()
        {
        }

        public PeladaEncerradaException(string message) : base(message)
        {
        }

        public PeladaEncerradaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PeladaEncerradaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}