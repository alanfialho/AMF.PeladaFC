using Amf.Framework.DDDConcepts;
using Amf.Framework.ObjetosComuns;
using System;
using System.Collections.Generic;

namespace Amf.PeladaFC.DomainModel.Core
{
    public class Pelada : Aggregate
    {
        private readonly HashSet<Peladeiro> _membros;
        private bool _ativa;  

        public string Titulo { get; private set; }
        public Endereco Local { get; private set; }
        public DateTime Inicio { get; private set; }
        public Administrador Administrador { get; private set; }
        public bool Ativa
        {
            get
            {
                return _ativa;
            }
            set
            {
                ChecaSefoiEncerrada();
                _ativa = value;
            }
        }
        public bool Encerrada { get; set; }
        public IEnumerable<Peladeiro> Membros
        {
            get
            {
                return _membros;
            }
        }

        public static Pelada Criar(Endereco local, 
            DateTime inicio, 
            Administrador administrador, 
            string titulo)
        {
            return new Pelada(Guid.NewGuid(), 
                administrador, 
                new HashSet<Peladeiro>(), 
                inicio)
            {
                Local = local,
                Titulo = titulo,
                Ativa = false,
                Encerrada = false
            };
        }

        protected Pelada(Guid id, 
            Administrador administrador, 
            HashSet<Peladeiro> membros, 
            DateTime inicio) : base(id)
        {
            ChecaInicio(inicio);
            _membros = membros;    
        }

        public void Ingressar(Convite convite)
        {
            ChecaSefoiEncerrada();

            if (!convite.Pelada.Equals(this))
                throw new ConviteNaoEncontradoException("O convite não pertence a esta pelada!");

            if (!convite.Status.Equals(ConviteStatus.Aceito))
                throw new ConviteNaoAceitoException("O convite não se encontra no status de aceito!");

            _membros.Add(convite.Peladeiro);

        }

        public void Remover(Peladeiro peladeiro)
        {
            ChecaSefoiEncerrada();
            _membros.Remove(peladeiro);        
        }

        public void AlterarAdministrador()
        {
            ChecaSefoiEncerrada();

            if (_membros.Count > 0)
            {
                Administrador = Administrador.TornarAdministrador(_membros.GetEnumerator().Current);
            }
        }

        private void ChecaSefoiEncerrada()
        {
            if (Encerrada)
                throw new PeladaEncerradaException("A pelada já foi encerrada");
        }

        private void ChecaInicio(DateTime inicio)
        {
            if (DateTime.Compare(inicio, DateTime.Now) < 0)
                throw new ArgumentException("a data inicial não pode ser menor que o dia de hoje");
        }

        public void AlterarInicio(DateTime novoInicio)
        {
            ChecaInicio(novoInicio);
            Inicio = novoInicio;
        }
    }
}
