﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto;

#nullable disable

namespace Poyecto.Migrations
{
    [DbContext(typeof(ConexionesDbContext))]
    [Migration("20250117134529_prueba1.0")]
    partial class prueba10
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proyecto.Clases.Personaje", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<string>("historia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("peso")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("tvid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("tvid");

                    b.ToTable("personajes");
                });

            modelBuilder.Entity("Proyecto.Clases.Tv", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("creacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("estrellas")
                        .HasColumnType("int");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tvs");
                });

            modelBuilder.Entity("Proyecto.Clases.Personaje", b =>
                {
                    b.HasOne("Proyecto.Clases.Tv", "tv")
                        .WithMany("socios")
                        .HasForeignKey("tvid");

                    b.Navigation("tv");
                });

            modelBuilder.Entity("Proyecto.Clases.Tv", b =>
                {
                    b.Navigation("socios");
                });
#pragma warning restore 612, 618
        }
    }
}
