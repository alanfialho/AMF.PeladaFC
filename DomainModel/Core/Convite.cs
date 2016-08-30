using Amf.Framework.DDDConcepts;
using System;

namespace Amf.PeladaFC.DomainModel.Core
{
    public class Convite : Entity<long>
    {
        
        private readonly DateTime _quando;
        private readonly Pelada _pelada;
        private readonly Peladeiro _peladeiro;

        public ConviteStatus Status { get; private set; }

        public DateTime Quando
        {
            get
            {
                return _quando;
            }
        }

        public Pelada Pelada
        {
            get
            {
                return _pelada;
            }
        }

        public Peladeiro Peladeiro
        {
            get
            {
                return _peladeiro;
            }
        }

        internal Convite(Pelada pelada, Peladeiro peladeiro)
        {
            Status = ConviteStatus.Pendente;
            _quando = DateTime.Now;
            _pelada = pelada;
            _peladeiro = peladeiro;
        }

        internal void Aceitar()
        {
            Status = ConviteStatus.Aceito;
        }

        internal void Recusar()
        {
            Status = ConviteStatus.Recusado;
        }
    }
}
