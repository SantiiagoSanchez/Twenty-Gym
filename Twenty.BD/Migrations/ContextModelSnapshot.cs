﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Twenty.BD.Data;

#nullable disable

namespace Twenty.BD.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Twenty.BD.Data.Entity.Actividad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DificultadId")
                        .HasColumnType("int");

                    b.Property<string>("Duracion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<int>("TipoEntrenamientoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DificultadId");

                    b.HasIndex("TipoEntrenamientoId");

                    b.ToTable("Actividades");
                });

            modelBuilder.Entity("Twenty.BD.Data.Entity.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActividadId")
                        .HasColumnType("int");

                    b.Property<bool>("Alergias")
                        .HasColumnType("bit");

                    b.Property<int>("Cuota")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EntrenadorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaInscripcion")
                        .HasColumnType("datetime2");

                    b.Property<string>("FotoPerfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Membresia")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<int>("TelefonoEmergencia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActividadId");

                    b.HasIndex("EntrenadorId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Twenty.BD.Data.Entity.Dificultad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NivelDificultad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dificultades");
                });

            modelBuilder.Entity("Twenty.BD.Data.Entity.Entrenador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActividadId")
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActividadId");

                    b.ToTable("Entrenadores");
                });

            modelBuilder.Entity("Twenty.BD.Data.Entity.TipoEntrenamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoEntrenamientos");
                });

            modelBuilder.Entity("Twenty.BD.Data.Entity.Actividad", b =>
                {
                    b.HasOne("Twenty.BD.Data.Entity.Dificultad", "Dificultad")
                        .WithMany()
                        .HasForeignKey("DificultadId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Twenty.BD.Data.Entity.TipoEntrenamiento", "TipoDeEntrenamiento")
                        .WithMany()
                        .HasForeignKey("TipoEntrenamientoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Dificultad");

                    b.Navigation("TipoDeEntrenamiento");
                });

            modelBuilder.Entity("Twenty.BD.Data.Entity.Cliente", b =>
                {
                    b.HasOne("Twenty.BD.Data.Entity.Actividad", "Actividad")
                        .WithMany()
                        .HasForeignKey("ActividadId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Twenty.BD.Data.Entity.Entrenador", "Entrenador")
                        .WithMany()
                        .HasForeignKey("EntrenadorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Actividad");

                    b.Navigation("Entrenador");
                });

            modelBuilder.Entity("Twenty.BD.Data.Entity.Entrenador", b =>
                {
                    b.HasOne("Twenty.BD.Data.Entity.Actividad", "Actividad")
                        .WithMany()
                        .HasForeignKey("ActividadId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Actividad");
                });
#pragma warning restore 612, 618
        }
    }
}
