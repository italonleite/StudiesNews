﻿// <auto-generated />
using System;
using Ef.Descriminator.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ef.Descriminator.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210417211848_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ef.Descriminator.Models.Blog", b =>
                {
                    b.Property<Guid>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blog_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogId");

                    b.ToTable("Blogs");

                    b.HasDiscriminator<string>("blog_type").HasValue("blog_base");
                });

            modelBuilder.Entity("Ef.Descriminator.Models.RssBlog", b =>
                {
                    b.HasBaseType("Ef.Descriminator.Models.Blog");

                    b.Property<string>("RssUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("blog_rss");
                });
#pragma warning restore 612, 618
        }
    }
}