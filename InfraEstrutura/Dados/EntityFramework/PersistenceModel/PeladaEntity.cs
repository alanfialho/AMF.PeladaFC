using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel
{
    [Table("Pelada")]
    public class PeladaEntity
    {
        public Guid Id { get; set; }
        public byte[] Foto { get; set; }
        public string Titulo { get; set; }
        public EnderecoEntity Local { get; set; }
        public DateTime Inicio { get; set; }
        public HashSet<PeladeiroEntity> Membros { get; set; }
        public PeladeiroEntity Administrador { get; set; }
        public bool Ativa { get; set; }
        public bool Encerrada { get; set; }
    }
}
