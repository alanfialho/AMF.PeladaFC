using Amf.Framework.DDDConcepts;
using System.Collections.Generic;

namespace Amf.PeladaFC.DomainModel.Core
{
    public class Peladeiro : Entity<int>
    {
        private HashSet<Posicao> _posicoes;
        private ICollection<Posicao> posicoes;

        public string NomeCompleto { get; set; } 
        public ICollection<Posicao> Posicoes
        {
            get { return _posicoes; }
        }

        public Peladeiro(string nomeCompleto, ICollection<Posicao> posicoes): base() 
        {
            NomeCompleto = nomeCompleto;
            _posicoes = new HashSet<Posicao>(posicoes);
        }

        public void Adicionar(Posicao posicao)
        {
            _posicoes.Add(posicao);
        }

        public void Remover(Posicao posicao)
        {
            _posicoes.Remove(posicao);
        }

        public virtual void Sair(Pelada deQual)
        {
            deQual.Remover(this);
        }
    }
}
