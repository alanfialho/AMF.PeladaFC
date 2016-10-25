using System;
using Amf.Framework.DDDConcepts;
using Amf.Framework.ObjetosComuns;

namespace Amf.PeladaFC.DomainModel.Core
{
    public class Conta : Aggregate
    {
        private Endereco _referencia;
        private Procura _tipoProcura;
        private Peladeiro _peladeiro;

        public Endereco Referencia
        {
            get { return _referencia; }
            set
            {
                ValidarReferencia(value);
                _referencia = value;
            }
        }

        public Procura TipoProcura { get { return _tipoProcura; } }

        public Peladeiro Peladeiro { get { return _peladeiro; } }

        public Conta(Guid id, Peladeiro peladeiro) : base(id)
        {
            _tipoProcura = Procura.Raio;
            _peladeiro = peladeiro;
        }

        public Conta(Guid id, Endereco referencia, Peladeiro peladeiro) : base(id)
        {
            ValidarReferencia(referencia);
            _tipoProcura = Procura.EnderecoReferencia;
            _peladeiro = peladeiro;
            _referencia = referencia;
        }

        private void ValidarReferencia(Endereco referencia) {

            if (referencia.Estado == null)
                throw new ArgumentException("Ao menos estado precisa ser preenchido no endereço");
        }

        public void AlterarTipoProcuraParaRaio() {
            _tipoProcura = Procura.Raio;
        }

        public void AlterarTipoProcuraParaReferencia()
        {
            _tipoProcura = Procura.EnderecoReferencia;
        }

        public void AlterarTipoProcura(Endereco referencia)
        {
            ValidarReferencia(referencia);
            AlterarTipoProcuraParaReferencia();
        }
    }
}
