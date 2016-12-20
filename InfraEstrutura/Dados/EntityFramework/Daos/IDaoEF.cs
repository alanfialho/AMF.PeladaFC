using System;
using System.Data.Entity;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Daos
{
    public interface IDaoEF<TENTITY, CP> : IDao<TENTITY, CP>, IDisposable
        where TENTITY : class
    {
        void SetContexto(DbContext contexto);
    }
}
