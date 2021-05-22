using EF.DescriminatorImmobile.Map;
using EF.DescriminatorImmobile.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Imovel = EF.DescriminatorImmobile.Models.Imovel;

namespace EF.DescriminatorImmobile.Context
{
    public class ImovelContext : DbContext 
    {
        public DbSet<Imovel> Tipos { get; set; }
        public DbSet<Residencial> Residenciais { get; set; }
        public DbSet<Comercial> Comerciais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DEV_ITALOLEITE\SQLEXPRESS;Database=EFDiscriminatorImovelNew;Trusted_Connection=True;MultipleActiveResultSets=true");
            // optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ImovelMap());

        }
    }
}
