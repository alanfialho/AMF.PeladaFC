using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using System;
using System.Collections.Generic;

namespace Amf.PeladaFC.Infraestrutura.Servicos
{
    public interface IServicoConta
    {
        Guid Criar(string nomeCompletoPeladeiro,
            string email,
            string senha,
            byte[] foto = null);
    }
}
