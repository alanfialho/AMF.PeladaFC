using System;
using Amf.Framework.DDDConcepts;
using Amf.Framework.ObjetosComuns;

namespace Amf.PeladaFC.DomainModel.Core
{
    public class Conta : Aggregate
    {
        private Endereco _referencia;
        private Descoberta _descoberta;
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

        public Descoberta Descoberta { get { return _descoberta; } }

        public Peladeiro Peladeiro { get { return _peladeiro; } }

        public byte[] Foto { get; set; }

        public Conta(Guid id, Peladeiro peladeiro) : base(id)
        {
            _descoberta = Descoberta.LocalizacaoAtual;
            _peladeiro = peladeiro;
        }

        public Conta(Guid id, Endereco referencia, Peladeiro peladeiro) : base(id)
        {
            ValidarReferencia(referencia);
            _descoberta = Descoberta.EnderecoReferencia;
            _peladeiro = peladeiro;
            _referencia = referencia;
        }

        private void ValidarReferencia(Endereco referencia) {

            if (referencia.Estado == null)
                throw new ArgumentException("Ao menos estado precisa ser preenchido no endereço");
        }

        public void AlterarDescobertaParaLocalizacaoAtual() {
            _descoberta = Descoberta.LocalizacaoAtual;
            _referencia = null;
        }

        public void AlterarDescobertaParaReferencia(Endereco referencia)
        {
            ValidarReferencia(referencia);
            _descoberta = Descoberta.EnderecoReferencia;
        }
    }
}
