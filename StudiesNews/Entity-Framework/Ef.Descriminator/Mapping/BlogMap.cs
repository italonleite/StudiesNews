using Ef.Descriminator.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ef.Descriminator.Mapping
{
    public class BlogMap : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder                
               .HasDiscriminator<string>("blog_type")
               .HasValue<Blog>("blog_base")
               .HasValue<Blog>("blog_rss");
            builder.HasKey(x => x.BlogId);
            
        }
    }
}
