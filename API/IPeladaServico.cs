using Amf.Framework.ObjetosComuns;
using System;

namespace Amf.PeladaFC.API
{
    public interface IPeladaServico
    {
        void Criar(Endereco local, 
            DateTime inicio, 
            string titulo,
            Guid peladeiroId);
    }
}
