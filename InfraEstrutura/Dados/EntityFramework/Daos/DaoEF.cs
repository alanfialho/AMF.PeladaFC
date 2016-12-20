using System;
using System.Data.Entity;
using System.Linq;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Daos
{
    public abstract class DaoEF<TENTITY, CP> : IDaoEF<TENTITY, CP>, IDisposable
        where TENTITY : class
    {
        protected DbContext _contexto;

        public virtual void Atualizar(TENTITY entity)
        {
            _contexto.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Deletar(TENTITY entity)
        {
            _contexto.Set<TENTITY>().Remove(entity);
        }

        public virtual TENTITY ObterPorId(CP id)
        {
            return _contexto.Set<TENTITY>().Find(id);
        }

        public virtual IQueryable<TENTITY> ObterTodos()
        {
            return _contexto.Set<TENTITY>();
        }

        public virtual void Salvar(TENTITY entity)
        {
            _contexto.Set<TENTITY>().Add(entity);
        }

        public void SetContexto(DbContext contexto)
        {
            _contexto = contexto;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
         
        ~DaoEF()
        {
            Dispose(false);
        }
         
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {  
                if (_contexto != null)
                {
                    _contexto.Dispose();
                    _contexto = null;
                }
            }
        }
    }
}
