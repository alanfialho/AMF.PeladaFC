using System.ComponentModel.DataAnnotations.Schema;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel
{
    [Table("Usuario")]
    public class UsuarioEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Email { get; set; }
        public string HashSenha { get; set; }
    }
}
