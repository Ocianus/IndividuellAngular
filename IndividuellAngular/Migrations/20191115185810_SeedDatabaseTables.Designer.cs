﻿// <auto-generated />
using IndividuellAngular.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IndividuellAngular.Migrations
{
    [DbContext(typeof(KundeServiceContext))]
    [Migration("20191115185810_SeedDatabaseTables")]
    partial class SeedDatabaseTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IndividuellAngular.Models.FAQ", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("downvote")
                        .HasColumnType("int");

                    b.Property<int>("kategoriId")
                        .HasColumnType("int");

                    b.Property<string>("sporsmal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("svar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("upvote")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("kategoriId");

                    b.ToTable("AlleFaq");

                    b.HasData(
                        new
                        {
                            id = 1,
                            downvote = 0,
                            kategoriId = 1,
                            sporsmal = "TestSpørsmål",
                            svar = "Testsvar",
                            upvote = 0
                        },
                        new
                        {
                            id = 2,
                            downvote = 0,
                            kategoriId = 2,
                            sporsmal = "TestSpørsmål",
                            svar = "Testsvar",
                            upvote = 0
                        });
                });

            modelBuilder.Entity("IndividuellAngular.Models.InnSporsmal", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("navn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sporsmal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("AlleInnSporsmal");

                    b.HasData(
                        new
                        {
                            id = 1,
                            email = "fredrik1998@hotmail.com",
                            navn = "Fredrik Riise",
                            sporsmal = "Dersom toget blir innstilt, dekkes taxi av dere?"
                        },
                        new
                        {
                            id = 2,
                            email = "per.persen@gmail.com",
                            navn = "Per Persen",
                            sporsmal = "Hvem kontakter jeg dersom jeg har mistet noe på toget deres?"
                        });
                });

            modelBuilder.Entity("IndividuellAngular.Models.Kategori", b =>
                {
                    b.Property<int>("kategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("kategoriNavn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("kategoriId");

                    b.ToTable("AlleKategorier");

                    b.HasData(
                        new
                        {
                            kategoriId = 1,
                            kategoriNavn = "Bestilling"
                        },
                        new
                        {
                            kategoriId = 2,
                            kategoriNavn = "Betaling"
                        });
                });

            modelBuilder.Entity("IndividuellAngular.Models.FAQ", b =>
                {
                    b.HasOne("IndividuellAngular.Models.Kategori", "kategoriNavn")
                        .WithMany()
                        .HasForeignKey("kategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
