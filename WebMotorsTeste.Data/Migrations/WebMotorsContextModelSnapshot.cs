﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebMotorsTeste.Data.Context;

namespace WebMotorsTeste.Data.Migrations
{
    [DbContext(typeof(WebMotorsContext))]
    partial class WebMotorsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebMotorsTeste.Data.Entities.Anuncio", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ano")
                        .HasColumnName("ano")
                        .HasColumnType("int");

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasColumnName("marca")
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("modelo")
                        .IsRequired()
                        .HasColumnName("modelo")
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("observacao")
                        .IsRequired()
                        .HasColumnName("observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quilometragem")
                        .HasColumnName("quilometragem")
                        .HasColumnType("int");

                    b.Property<string>("versao")
                        .IsRequired()
                        .HasColumnName("versao")
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.HasKey("ID")
                        .HasName("pk_anuncio");

                    b.ToTable("tb_AnuncioWebmotors");
                });
#pragma warning restore 612, 618
        }
    }
}