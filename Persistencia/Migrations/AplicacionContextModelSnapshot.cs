﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(AplicacionContext))]
    partial class AplicacionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominio.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NIT")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroDocumento")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Dominio.Cliente", b =>
                {
                    b.HasBaseType("Dominio.Persona");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("Dominio.Directivo", b =>
                {
                    b.HasBaseType("Dominio.Persona");

                    b.Property<int>("CantidadEmpleados")
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDirectivo")
                        .HasColumnType("int");

                    b.Property<int>("Salario")
                        .HasColumnType("int")
                        .HasColumnName("Directivo_Salario");

                    b.HasDiscriminator().HasValue("Directivo");
                });

            modelBuilder.Entity("Dominio.Empleado", b =>
                {
                    b.HasBaseType("Dominio.Persona");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("Salario")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Empleado");
                });
#pragma warning restore 612, 618
        }
    }
}
