using EF.DescriminatorImmobile.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Imovel = EF.DescriminatorImmobile.Models.Imovel;

namespace EF.DescriminatorImmobile.Map
{
    public class ImovelMap : IEntityTypeConfiguration<Imovel>
    {
        public void Configure(EntityTypeBuilder<Imovel> builder)
        {
            builder
               .HasDiscriminator<string>("imovel_descriminator_categoria")            
               .HasValue<Residencial>("residencial")
               .HasValue<Comercial>("comercial");
            builder.HasKey(x => x.Id);


        }
    }
}
