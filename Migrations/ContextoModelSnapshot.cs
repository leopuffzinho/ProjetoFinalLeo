﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoFinalLeo.Models;

#nullable disable

namespace ProjetoFinalLeo.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjetoFinalLeo.Models.Cidade", b =>
                {
                    b.Property<int>("CidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CidadeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CidadeId"), 1L, 1);

                    b.Property<string>("CidadeNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CidadeNome");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.HasKey("CidadeId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClienteId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"), 1L, 1);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteCpf")
                        .HasColumnType("int")
                        .HasColumnName("ClienteCpf");

                    b.Property<string>("ClienteEndereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteEndereco");

                    b.Property<string>("ClienteNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteNome");

                    b.Property<string>("ClienteNumero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteNumero");

                    b.Property<string>("ClienteSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteSexo");

                    b.Property<int>("ClienteTelefone")
                        .HasColumnType("int")
                        .HasColumnName("ClienteTelefone");

                    b.HasKey("ClienteId");

                    b.HasIndex("CidadeId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.Colaborador", b =>
                {
                    b.Property<int>("ColaboradorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ColaboradorId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColaboradorId"), 1L, 1);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("ColaboradorCpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorCpf");

                    b.Property<string>("ColaboradorNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorNome");

                    b.Property<string>("ColaboradorSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorSexo");

                    b.Property<string>("ColaboradorTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorTelefone");

                    b.Property<int>("TipoColaboradorId")
                        .HasColumnType("int");

                    b.HasKey("ColaboradorId");

                    b.HasIndex("CidadeId");

                    b.HasIndex("TipoColaboradorId");

                    b.ToTable("Colaborador");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.Estado", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EstadoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoId"), 1L, 1);

                    b.Property<string>("EstadoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EstadoNome");

                    b.HasKey("EstadoId");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.LocalRealizacao", b =>
                {
                    b.Property<int>("LocalRealizacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LocalRealizacaoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocalRealizacaoId"), 1L, 1);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("LocalRealizacaoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LocalRealizacaoNome");

                    b.HasKey("LocalRealizacaoId");

                    b.HasIndex("CidadeId");

                    b.ToTable("LocalRealizacao");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.Procedimento", b =>
                {
                    b.Property<int>("ProcedimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProcedimentoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProcedimentoId"), 1L, 1);

                    b.Property<string>("ProcedimentoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ProcedimentoNome");

                    b.Property<string>("ProcedimentoObservacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ProcedimentoObservacao");

                    b.Property<int>("TipoProcedimentoId")
                        .HasColumnType("int");

                    b.HasKey("ProcedimentoId");

                    b.HasIndex("TipoProcedimentoId");

                    b.ToTable("Procedimento");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.ProcedimentoRealizado", b =>
                {
                    b.Property<int>("ProcedimentoRealizadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProcedimentoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProcedimentoRealizadoId"), 1L, 1);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("ColaboradorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataRealizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataRealizacao");

                    b.Property<int?>("LocalRealizacaoId")
                        .HasColumnType("int");

                    b.Property<string>("ObservacaoRealizacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacaoRealizacao");

                    b.Property<int?>("ProcedimentoId")
                        .HasColumnType("int")
                        .HasColumnName("ProcedimentoId1");

                    b.HasKey("ProcedimentoRealizadoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ColaboradorId");

                    b.HasIndex("LocalRealizacaoId");

                    b.HasIndex("ProcedimentoId");

                    b.ToTable("ProcedimentoRealizado");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.TipoColaborador", b =>
                {
                    b.Property<int>("TipoColaboradorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TipoColaboradorId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoColaboradorId"), 1L, 1);

                    b.Property<string>("TipoColaboradorNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoColaboradorNome");

                    b.HasKey("TipoColaboradorId");

                    b.ToTable("TipoColaborador");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.TipoProcedimento", b =>
                {
                    b.Property<int>("TipoProcedimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TipoProcedimentoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoProcedimentoId"), 1L, 1);

                    b.Property<string>("TipoProcedimentoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoProcedimentoNome");

                    b.HasKey("TipoProcedimentoId");

                    b.ToTable("TipoProcedimento");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.Usuario", b =>
                {
                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("UsuarioId");

                    b.Property<string>("UsuarioEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioEmail");

                    b.Property<string>("UsuarioNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioNome");

                    b.Property<string>("UsuarioSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioSenha");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.Cidade", b =>
                {
                    b.HasOne("ProjetoFinalLeo.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.Cliente", b =>
                {
                    b.HasOne("ProjetoFinalLeo.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.Colaborador", b =>
                {
                    b.HasOne("ProjetoFinalLeo.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoFinalLeo.Models.TipoColaborador", "TipoColaborador")
                        .WithMany()
                        .HasForeignKey("TipoColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("TipoColaborador");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.LocalRealizacao", b =>
                {
                    b.HasOne("ProjetoFinalLeo.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.Procedimento", b =>
                {
                    b.HasOne("ProjetoFinalLeo.Models.TipoProcedimento", "TipoProcedimento")
                        .WithMany()
                        .HasForeignKey("TipoProcedimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoProcedimento");
                });

            modelBuilder.Entity("ProjetoFinalLeo.Models.ProcedimentoRealizado", b =>
                {
                    b.HasOne("ProjetoFinalLeo.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("ProjetoFinalLeo.Models.Colaborador", "Colaborador")
                        .WithMany()
                        .HasForeignKey("ColaboradorId");

                    b.HasOne("ProjetoFinalLeo.Models.LocalRealizacao", "LocalRealizacao")
                        .WithMany()
                        .HasForeignKey("LocalRealizacaoId");

                    b.HasOne("ProjetoFinalLeo.Models.Procedimento", "Procedimento")
                        .WithMany()
                        .HasForeignKey("ProcedimentoId");

                    b.Navigation("Cliente");

                    b.Navigation("Colaborador");

                    b.Navigation("LocalRealizacao");

                    b.Navigation("Procedimento");
                });
#pragma warning restore 612, 618
        }
    }
}
