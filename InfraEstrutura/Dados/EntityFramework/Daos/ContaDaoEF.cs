using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using System;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Daos
{
    public class ContaDaoEF : DaoEF<ContaEntity, Guid>, IContaDaoEF
    {
    }
}
