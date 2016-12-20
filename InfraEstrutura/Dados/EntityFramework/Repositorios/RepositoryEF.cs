using System.Linq;
using System.Data.Entity;
using AutoMapper;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Repositorios
{
    public abstract class RepositoryEF<TDOMAIN, TENTITY, CP> : IRepositoryEF<TDOMAIN, TENTITY,CP> 
        where TDOMAIN : class 
        where TENTITY: class
    {
        protected DbContext _contexto;

        public RepositoryEF(DbContext contexto)
        {
            _contexto = contexto;
        }

        public virtual void Atualizar(TDOMAIN entity)
        {
            TENTITY persistenceEntity = Mapper.Map<TDOMAIN, TENTITY>(entity);
            _contexto.Entry(persistenceEntity).State = EntityState.Modified;
        }

        public virtual void Deletar(TDOMAIN entity)
        {
            TENTITY persistenceEntity = Mapper.Map<TDOMAIN, TENTITY>(entity);
            _contexto.Set<TENTITY>().Remove(persistenceEntity);
        }

        public virtual TDOMAIN ObterPorId(CP id)
        {
            TENTITY persistenceEntity = _contexto.Set<TENTITY>().Find(id);
            return Mapper.Map<TENTITY, TDOMAIN>(persistenceEntity);
        }

        public virtual IQueryable<TDOMAIN> ObterTodos()
        {
            IQueryable<TENTITY> persistenceEntity = _contexto.Set<TENTITY>();
            return Mapper.Map<IQueryable<TENTITY>, IQueryable<TDOMAIN>>(persistenceEntity);
        }

        public virtual void Salvar(TDOMAIN entity)
        {
            TENTITY persistenceEntity = Mapper.Map<TDOMAIN, TENTITY>(entity);
            _contexto.Set<TENTITY>().Add(persistenceEntity);
        }

        public void SetContexto(DbContext contexto) {

            _contexto = contexto;
        }
    }
}
