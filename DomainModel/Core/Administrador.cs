using Amf.Framework.ObjetosComuns;
using System;
using System.Collections.Generic;

namespace Amf.PeladaFC.DomainModel.Core
{
    public class Administrador : Peladeiro
    {
        public static Administrador TornarAdministrador(Peladeiro peladeiro)
        {
            throw new NotImplementedException();
        }

        private Administrador(string nomeCompleto, ICollection<Posicao> posicoes) : base(nomeCompleto, posicoes)
        {
            
        }

        public Convite ConvidarPara(Pelada pelada, Peladeiro peladeiro)
        {
            if (peladeiro.Equals(this))
                throw new ConviteRedundanteException("O administrador não pode se convidar");

            return new Convite(pelada, peladeiro);            
        }

        public override void Sair(Pelada deQual)
        {
            if (!deQual.Administrador.Equals(this))
                throw new UnauthorizedAccessException("voce não é o administrador desta pelada para sair como administradror");

            deQual.AlterarAdministrador();
        }
    }
}
