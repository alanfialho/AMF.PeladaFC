using Amf.Framework.DDDConcepts;
using System;

namespace Amf.PeladaFC.DomainModel.Core
{
    public interface IAdministradorRepository : IRepository<Administrador, Guid>
    {
        void SalvarConvite(Convite convite);
    }
}
