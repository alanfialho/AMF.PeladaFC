using System.Linq;
using Amf.Framework.DDDConcepts;
using System.Data.Entity;
using AutoMapper;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework
{
    public abstract class Repository<C, TDOMAIN, TENTITY, CP> : IRepository<TDOMAIN, CP> 
        where TDOMAIN : class 
        where TENTITY: class
        where C : DbContext, new()
    {
        protected readonly C _contexto = new C();

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
    }
}
