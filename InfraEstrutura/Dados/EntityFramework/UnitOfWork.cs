using System;
using Amf.Framework.Infraestrutura;
using System.Data.Entity.Infrastructure;
using MySql.Data.MySqlClient;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly PeladaFCContexto _contexto;

        public UnitOfWork(PeladaFCContexto contexto)
        {
            _contexto = contexto;        
        }

        public virtual void FinalizarTransacao()
        {
            try
            {
                _contexto.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                int erro = (ex.InnerException.InnerException as MySqlException).Number;
                throw new FinalizacaoTransacaoException("Houve um erro ao finalizar a transação", ex, erro);
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _contexto.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
