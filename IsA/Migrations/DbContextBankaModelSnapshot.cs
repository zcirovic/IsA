﻿// <auto-generated />
using IsA.Models.Banka;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IsA.Migrations
{
    [DbContext(typeof(DbContextBanka))]
    partial class DbContextBankaModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IsA.Models.Banka.Banka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adresa")
                        .HasColumnName("adresa")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("mesto")
                        .IsRequired()
                        .HasColumnName("mesto")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("naziv")
                        .IsRequired()
                        .HasColumnName("naziv")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Banka");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "ALPHA Bank"
                        },
                        new
                        {
                            Id = 2,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Banca INTESA"
                        },
                        new
                        {
                            Id = 3,
                            adresa = "",
                            mesto = "Крагујевац",
                            naziv = "CREDI Bank"
                        },
                        new
                        {
                            Id = 4,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "EFG  Eurobank"
                        },
                        new
                        {
                            Id = 5,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Addiko bank"
                        },
                        new
                        {
                            Id = 6,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "HVB Bank"
                        },
                        new
                        {
                            Id = 7,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "LHB bank"
                        },
                        new
                        {
                            Id = 8,
                            adresa = "",
                            mesto = "Нови Сад",
                            naziv = "Metals bank"
                        },
                        new
                        {
                            Id = 9,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Mikro finance bank"
                        },
                        new
                        {
                            Id = 10,
                            adresa = "",
                            mesto = "Нови сад",
                            naziv = "OTP banka"
                        },
                        new
                        {
                            Id = 11,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Pro Credi Bank"
                        },
                        new
                        {
                            Id = 12,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Raiffeisen banka a.d."
                        },
                        new
                        {
                            Id = 13,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Societe Generale Bank"
                        },
                        new
                        {
                            Id = 14,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Sber bank"
                        },
                        new
                        {
                            Id = 15,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "ZEPTER bank"
                        },
                        new
                        {
                            Id = 16,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Агробанка"
                        },
                        new
                        {
                            Id = 17,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Атлас банка"
                        },
                        new
                        {
                            Id = 18,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Војвођанска банка"
                        },
                        new
                        {
                            Id = 19,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Комерцијална банка а.д."
                        },
                        new
                        {
                            Id = 20,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Меридијан банка"
                        },
                        new
                        {
                            Id = 21,
                            adresa = "",
                            mesto = "Параћин",
                            naziv = "Национална штедионица"
                        },
                        new
                        {
                            Id = 22,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "НБС"
                        },
                        new
                        {
                            Id = 23,
                            adresa = "",
                            mesto = "Ниш",
                            naziv = "Нишка банка"
                        },
                        new
                        {
                            Id = 24,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Поштанска штедионица а.д."
                        },
                        new
                        {
                            Id = 25,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Привредна банка"
                        },
                        new
                        {
                            Id = 26,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "СИМ банка"
                        },
                        new
                        {
                            Id = 27,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Српска банка"
                        },
                        new
                        {
                            Id = 28,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Универзал банка"
                        },
                        new
                        {
                            Id = 29,
                            adresa = "",
                            mesto = "Чачак",
                            naziv = "Чачанска банка"
                        },
                        new
                        {
                            Id = 30,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Марфин банка"
                        },
                        new
                        {
                            Id = 31,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Уникредит банка"
                        },
                        new
                        {
                            Id = 32,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Аик банка"
                        },
                        new
                        {
                            Id = 33,
                            adresa = "",
                            mesto = "Beograd",
                            naziv = "Piraeus banka"
                        },
                        new
                        {
                            Id = 34,
                            adresa = "",
                            mesto = "Novi Sad",
                            naziv = "Erste bank a.d."
                        },
                        new
                        {
                            Id = 35,
                            adresa = "",
                            mesto = "Београд",
                            naziv = "Теленор банка"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
