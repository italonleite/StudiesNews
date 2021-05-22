using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Map
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

            builder.Property(x => x.Id);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome);
            builder.ToTable("Clientes");
        }
    }
}
