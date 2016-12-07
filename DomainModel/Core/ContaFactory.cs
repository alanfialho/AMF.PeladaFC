using Amf.Framework.ObjetosComuns;
using System;

namespace Amf.PeladaFC.DomainModel.Core
{
    public static class ContaFactory
    {
        public static Conta CriarContaComFoto(Peladeiro peladeiro, byte[] foto)
        {
            return new Conta(Guid.NewGuid(), peladeiro) { Foto = foto };
        }

        public static Conta CriarContaComReferencia(Peladeiro peladeiro, Endereco referencia)
        {
            return new Conta(Guid.NewGuid(), referencia, peladeiro);
        }

        public static Conta CriarConta(Peladeiro peladeiro)
        {
            return new Conta(Guid.NewGuid(), peladeiro);
        }
    }
}
