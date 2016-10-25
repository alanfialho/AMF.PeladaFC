using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel
{
    [Table("Conta")]
    public class ContaEntity
    {
        public Guid Id { get; set; }
        public EnderecoEntity Referencia { get; set; }
        public byte TipoProcura { get; set; }
        public PeladeiroEntity Peladeiro { get; set; }
    }
}
