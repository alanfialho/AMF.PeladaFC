using Amf.Framework.DDDConcepts;
using System.Data.Entity;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Repositorios
{
    public interface IRepositoryEF<TDOMAIN, TENTITY, CP> : IRepository<TDOMAIN, CP>
        where TDOMAIN : class
        where TENTITY : class
    {
        void SetContexto(DbContext contexto);
    }
}

