﻿// <auto-generated />
using MegaFilmes.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MegaFilmes.Infra.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230215045943_adicionar relacionamento FilmeAtor")]
    partial class adicionarrelacionamentoFilmeAtor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MegaFilmes.Domain.Entities.Ator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("atores", (string)null);
                });

            modelBuilder.Entity("MegaFilmes.Domain.Entities.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("comentario");

                    b.Property<int>("Criterio")
                        .HasColumnType("int")
                        .HasColumnName("criterio");

                    b.Property<int>("FilmeId")
                        .HasColumnType("int")
                        .HasColumnName("filme_id");

                    b.HasKey("Id");

                    b.HasIndex("FilmeId");

                    b.ToTable("avaliacoes", (string)null);
                });

            modelBuilder.Entity("MegaFilmes.Domain.Entities.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Ano")
                        .HasColumnType("int")
                        .HasColumnName("ano");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descricao");

                    b.Property<string>("Diretor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("diretor");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("genero");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("filmes", (string)null);
                });

            modelBuilder.Entity("MegaFilmes.Domain.Entities.FilmeAtor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AtorId")
                        .HasColumnType("int")
                        .HasColumnName("ator_id");

                    b.Property<int>("FilmeId")
                        .HasColumnType("int")
                        .HasColumnName("filme_id");

                    b.Property<string>("Papel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("papel");

                    b.HasKey("Id");

                    b.HasIndex("AtorId");

                    b.HasIndex("FilmeId");

                    b.ToTable("filmes_atores", (string)null);
                });

            modelBuilder.Entity("MegaFilmes.Domain.Entities.Avaliacao", b =>
                {
                    b.HasOne("MegaFilmes.Domain.Entities.Filme", "Filme")
                        .WithMany("Avaliacao")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filme");
                });

            modelBuilder.Entity("MegaFilmes.Domain.Entities.FilmeAtor", b =>
                {
                    b.HasOne("MegaFilmes.Domain.Entities.Ator", "Ator")
                        .WithMany("FilmesAtores")
                        .HasForeignKey("AtorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MegaFilmes.Domain.Entities.Filme", "Filme")
                        .WithMany("FilmesAtores")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ator");

                    b.Navigation("Filme");
                });

            modelBuilder.Entity("MegaFilmes.Domain.Entities.Ator", b =>
                {
                    b.Navigation("FilmesAtores");
                });

            modelBuilder.Entity("MegaFilmes.Domain.Entities.Filme", b =>
                {
                    b.Navigation("Avaliacao");

                    b.Navigation("FilmesAtores");
                });
#pragma warning restore 612, 618
        }
    }
}
