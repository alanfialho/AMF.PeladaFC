using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel
{
    [Table("Posicao")]
    public class PosicaoEntity
    {
        [Key, Column(Order = 0)]
        public string Codigo { get; set; }
        [Key, Column(Order = 1)]
        public string TipoPosicao { get; set; }
        public string Nome { get; set; }
        [Key, Column(Order = 2)]
        public int PeladeiroId { get; set; }
        [ForeignKey("PeladeiroId")]
        public virtual PeladeiroEntity Peladeiro { get; set; }
    }
}