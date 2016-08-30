using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel
{
    [Table("Peladeiro")]
    public class PeladeiroEntity
    {
        public Guid Id { get; set; }
        public byte[] Foto { get; set; }
        public string NomeCompleto { get; set; }
        public string Apelido { get; set; }
        public string Celular { get; set; }        
    }
}
