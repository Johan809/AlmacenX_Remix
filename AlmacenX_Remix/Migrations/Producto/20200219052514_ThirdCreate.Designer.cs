﻿// <auto-generated />
using AlmacenX_Remix.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlmacenX_Remix.Migrations.Producto
{
    [DbContext(typeof(ProductoContext))]
    [Migration("20200219052514_ThirdCreate")]
    partial class ThirdCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlmacenX_Remix.Models.Producto", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NombreProduct")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("PrecioProd")
                        .HasColumnType("int");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.ToTable("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
