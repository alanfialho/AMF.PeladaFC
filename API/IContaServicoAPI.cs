using Amf.Framework.ObjetosComuns;
using Amf.PeladaFC.DomainModel.Core;
using System;
using System.Collections.Generic;

namespace Amf.PeladaFC.API
{
    public interface IContaServicoAPI
    {
        Guid Criar(Peladeiro peladeiro, Endereco referencia);
        Guid Criar(Peladeiro peladeiro);
    }
}