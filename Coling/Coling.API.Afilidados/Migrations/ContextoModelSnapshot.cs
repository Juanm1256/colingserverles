﻿// <auto-generated />
using System;
using Coling.API.Afilidados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Coling.API.Afilidados.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Coling.Shared.Afiliado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodigoAfiliado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idpersona")
                        .HasColumnType("int")
                        .HasColumnName("IDPERSONA");

                    b.Property<string>("Nrotituloprovisional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaafiliacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Idpersona");

                    b.ToTable("Afiliados");
                });

            modelBuilder.Entity("Coling.Shared.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idpersona")
                        .HasColumnType("int")
                        .HasColumnName("IDPERSONA");

                    b.HasKey("Id");

                    b.HasIndex("Idpersona");

                    b.ToTable("Direccions");
                });

            modelBuilder.Entity("Coling.Shared.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Coling.Shared.PersonaTipoSocial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idpersona")
                        .HasColumnType("int")
                        .HasColumnName("IDPERSONA");

                    b.Property<int>("Idtiposocial")
                        .HasColumnType("int")
                        .HasColumnName("IDTIPOSOCIAL");

                    b.HasKey("Id");

                    b.HasIndex("Idpersona");

                    b.HasIndex("Idtiposocial");

                    b.ToTable("PersonaTipoSocials");
                });

            modelBuilder.Entity("Coling.Shared.ProfesionAfiliado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idafiliado")
                        .HasColumnType("int")
                        .HasColumnName("IDAFILIADO");

                    b.Property<int>("Idprofesion")
                        .HasColumnType("int");

                    b.Property<string>("Nrosellosib")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaasignacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Idafiliado");

                    b.ToTable("ProfesionAfiliados");
                });

            modelBuilder.Entity("Coling.Shared.Telefono", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idpersona")
                        .HasColumnType("int")
                        .HasColumnName("IDPERSONA");

                    b.Property<string>("nrotelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Idpersona");

                    b.ToTable("Telefonos");
                });

            modelBuilder.Entity("Coling.Shared.TipoSocial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreSocial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoSocials");
                });

            modelBuilder.Entity("Coling.Shared.Afiliado", b =>
                {
                    b.HasOne("Coling.Shared.Persona", "IdPersonanav")
                        .WithMany()
                        .HasForeignKey("Idpersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdPersonanav");
                });

            modelBuilder.Entity("Coling.Shared.Direccion", b =>
                {
                    b.HasOne("Coling.Shared.Persona", "IdPersonanav")
                        .WithMany()
                        .HasForeignKey("Idpersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdPersonanav");
                });

            modelBuilder.Entity("Coling.Shared.PersonaTipoSocial", b =>
                {
                    b.HasOne("Coling.Shared.Persona", "IdPersonanav")
                        .WithMany()
                        .HasForeignKey("Idpersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Coling.Shared.TipoSocial", "Idtiposocialnav")
                        .WithMany()
                        .HasForeignKey("Idtiposocial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdPersonanav");

                    b.Navigation("Idtiposocialnav");
                });

            modelBuilder.Entity("Coling.Shared.ProfesionAfiliado", b =>
                {
                    b.HasOne("Coling.Shared.Afiliado", "IdAfiliadonav")
                        .WithMany()
                        .HasForeignKey("Idafiliado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdAfiliadonav");
                });

            modelBuilder.Entity("Coling.Shared.Telefono", b =>
                {
                    b.HasOne("Coling.Shared.Persona", "IdPersonanav")
                        .WithMany()
                        .HasForeignKey("Idpersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdPersonanav");
                });
#pragma warning restore 612, 618
        }
    }
}
