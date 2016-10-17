using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static Amf.PeladaFC.DomainModel.Core.Peladeiro;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel
{
    [Table("Peladeiro")]
    public class PeladeiroEntity
    {
        public Guid Id { get; set; }
        public byte[] Foto { get; set; }
        public string NomeCompleto { get; set; }
        public IQueryable<PosicaoEntity> Posicoes { get; set; }
        public EnderecoEntity Referencia { get; set; }
        public byte TipoProcura { get; set; }
    }
}
