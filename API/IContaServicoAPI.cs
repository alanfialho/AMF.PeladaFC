using Amf.Framework.ObjetosComuns;
using Amf.PeladaFC.DomainModel.Core;
using System;
using System.Collections.Generic;

namespace Amf.PeladaFC.API
{
    public interface IContaServicoAPI
    {
        Guid Criar(string nomeCompletoPeladeiro, 
            ICollection<Posicao> posicoesPeladeiro = null, 
            Endereco referencia = null, 
            byte[] foto = null);
    }
}