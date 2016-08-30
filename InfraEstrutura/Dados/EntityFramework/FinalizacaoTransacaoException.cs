using System;
using System.Runtime.Serialization;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework
{
    [Serializable]
    public class FinalizacaoTransacaoException : ApplicationException
    {
        
        private readonly int _mySqlErro;

        public int MySqlErro
        {
            get
            {
                return _mySqlErro;
            }
        }

        public FinalizacaoTransacaoException()
        {
        }

        public FinalizacaoTransacaoException(string message) : base(message)
        {
        }

        public FinalizacaoTransacaoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public FinalizacaoTransacaoException(string message, Exception innerException, int mySqlErro) : this(message, innerException)
        {
            _mySqlErro = mySqlErro;
        }

        protected FinalizacaoTransacaoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}