using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel
{
    [Table("Peladeiro")]
    public class PeladeiroEntity
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public virtual ICollection<PosicaoEntity> Posicoes { get; set; }
    }
}
