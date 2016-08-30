using Amf.Framework.DDDConcepts;
using System;

namespace Amf.PeladaFC.DomainModel.Core
{
    public class Peladeiro : Aggregate
    {
        public string NomeCompleto { get; set; }
        public string Apelido { get; set; }
        public string Celular { get; set; }
        public string Email { get; private set; } 

        public Peladeiro(Guid id, string email): base(id) 
        {
            Email = email;
        }

        public virtual void Sair(Pelada deQual)
        {
            deQual.Remover(this);
        }
    }
}
