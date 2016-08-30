using Amf.Framework.DDDConcepts;
using System;
using System.Collections.Generic;

namespace Amf.PeladaFC.DomainModel.Core
{
    public interface IPeladeiroRepository : IRepository<Peladeiro, Guid>
    {
        List<Peladeiro> ObterPorCriterios(string nomeCompleto = "", string apelido = "", string email = "");
        Peladeiro ObterPorEmail(string email);
    }
}
