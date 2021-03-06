﻿using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework
{
    public class PeladaFCContexto : DbContext
    {
        public DbSet<PeladeiroEntity> Peladeiros { internal get; set; }
        public DbSet<PeladaEntity> Peladas { internal get; set; }
        public DbSet<EnderecoEntity> Enderecos { internal get; set; }
        public DbSet<PosicaoEntity> Posicoes { internal get; set; }
        public DbSet<ContaEntity> Contas { internal get; set; }
        public DbSet<UsuarioEntity> Usuarios { internal get; set; }

        public PeladaFCContexto() : base("peladafc") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}