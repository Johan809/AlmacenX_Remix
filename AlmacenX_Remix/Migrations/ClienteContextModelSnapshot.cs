﻿// <auto-generated />
using AlmacenX_Remix.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlmacenX_Remix.Migrations
{
    [DbContext(typeof(ClienteContext))]
    partial class ClienteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlmacenX_Remix.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Correo")
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Direccion")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Genero")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(25)");

                    b.HasKey("ClienteID");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
