﻿// <auto-generated />
using System;
using ApiRestDevs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiRestDevs.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210122011951_Corrigindo_FKs")]
    partial class Corrigindo_FKs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiRestDevs.Models.Desenvolvedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Desenvolvedores");
                });

            modelBuilder.Entity("ApiRestDevs.Models.LancamentoDeHora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DesenvolvedorId")
                        .HasColumnType("int");

                    b.Property<int?>("ProjetoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DesenvolvedorId");

                    b.HasIndex("ProjetoId");

                    b.ToTable("LancamentoDeHoras");
                });

            modelBuilder.Entity("ApiRestDevs.Models.Projeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Projetos");
                });

            modelBuilder.Entity("ApiRestDevs.Models.LancamentoDeHora", b =>
                {
                    b.HasOne("ApiRestDevs.Models.Desenvolvedor", "Desenvolvedor")
                        .WithMany("LancamentoDeHoras")
                        .HasForeignKey("DesenvolvedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiRestDevs.Models.Projeto", null)
                        .WithMany("LancamentoDeHoras")
                        .HasForeignKey("ProjetoId");
                });
#pragma warning restore 612, 618
        }
    }
}
