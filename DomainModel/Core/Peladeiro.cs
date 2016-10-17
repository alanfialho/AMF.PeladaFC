using Amf.Framework.DDDConcepts;
using Amf.Framework.ObjetosComuns;
using System;
using System.Collections.Generic;

namespace Amf.PeladaFC.DomainModel.Core
{
    public class Peladeiro : Aggregate
    {
        private Endereco _referencia;
        private HashSet<Posicao> _posicoes;


        public enum Procura
        {
            Raio,
            Referencia
        }

        public string NomeCompleto { get; set; }

        public Endereco Referencia {
            get { return _referencia; }
            set
            {
                if (value.Estado == null)
                    throw new ArgumentException("Ao menos estado precisa ser preenchido no endereço");

                _referencia = value;
            }
        }

        public Procura TipoProcura { get; set; }
        
        public IEnumerable<Posicao> Posicoes
        {
            get { return _posicoes; }
        }


        public Peladeiro(Guid id, string nomeCompleto, Procura tipoProcura, IEnumerable<Posicao> posicoes): base(id) 
        {
            NomeCompleto = nomeCompleto;
            TipoProcura = tipoProcura;
            _posicoes = new HashSet<Posicao>(posicoes);
        }

        public virtual void Sair(Pelada deQual)
        {
            deQual.Remover(this);
        }
    }
}
