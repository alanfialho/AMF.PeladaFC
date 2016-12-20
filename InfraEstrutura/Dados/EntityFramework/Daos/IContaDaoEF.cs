using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using System;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Daos
{
    public interface IContaDaoEF : IDaoEF<ContaEntity, Guid>
    {
    }
}
