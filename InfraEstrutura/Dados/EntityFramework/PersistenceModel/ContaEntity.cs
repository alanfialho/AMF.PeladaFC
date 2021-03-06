﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel
{
    [Table("Conta")]
    public class ContaEntity
    {
        public Guid Id { get; set; }
        public byte[] Foto { get; set; }
        public PeladeiroEntity Peladeiro { get; set; }
        public UsuarioEntity Usuario { get; set;}
    }
}
