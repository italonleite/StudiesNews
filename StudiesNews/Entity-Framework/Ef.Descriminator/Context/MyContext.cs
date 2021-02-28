using Ef.Descriminator.Mapping;
using Ef.Descriminator.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ef.Descriminator.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<RssBlog> RssBlogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DEV_ITALOLEITE\SQLEXPRESS;Database=EFDiscriminator;Trusted_Connection=True;MultipleActiveResultSets=true");
            // optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BlogMap());
            
        }
    }

    
}
