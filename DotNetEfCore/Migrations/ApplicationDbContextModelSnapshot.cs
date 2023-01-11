﻿// <auto-generated />
using DotnetEfCore.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotNetEfCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DotnetEfCore.DataContext.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CategoryCode")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_code");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.HasKey("Id");

                    b.ToTable("tbl_category");
                });

            modelBuilder.Entity("DotnetEfCore.DataContext.DataPerusahaanEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Divisi")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("divisi");

                    b.Property<string>("Leader")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("leader");

                    b.Property<string>("PkrPri")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("pkrpri");

                    b.Property<string>("PkrWnt")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("pkrwnt");

                    b.HasKey("Id");

                    b.ToTable("tbl_dataperusahaan");
                });

            modelBuilder.Entity("DotnetEfCore.DataContext.DataTamuEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Kota")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("kota");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nama");

                    b.Property<int>("NoTlp")
                        .HasColumnType("int")
                        .HasColumnName("notlp");

                    b.Property<int>("NoWa")
                        .HasColumnType("int")
                        .HasColumnName("nowa");

                    b.HasKey("Id");

                    b.ToTable("tbl_datatamu");
                });

            modelBuilder.Entity("DotnetEfCore.DataContext.SendEmailEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("from");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("message");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("subject");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("to");

                    b.HasKey("Id");

                    b.ToTable("tbl_sendemail");
                });

            modelBuilder.Entity("DotnetEfCore.DataContext.TokoGameEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("genre");

                    b.Property<int>("Harga")
                        .HasColumnType("int")
                        .HasColumnName("harga");

                    b.Property<int>("Jumlah")
                        .HasColumnType("int")
                        .HasColumnName("jumlah");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nama");

                    b.Property<int>("Tahun")
                        .HasColumnType("int")
                        .HasColumnName("tahun");

                    b.HasKey("Id");

                    b.ToTable("tbl_game");
                });

            modelBuilder.Entity("DotnetEfCore.DataContext.TokoKomputerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Harga")
                        .HasColumnType("int")
                        .HasColumnName("harga");

                    b.Property<int>("Jumlah")
                        .HasColumnType("int")
                        .HasColumnName("jumlah");

                    b.Property<string>("Kategori")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("kategori");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nama");

                    b.HasKey("Id");

                    b.ToTable("tbl_tokokomputer");
                });
#pragma warning restore 612, 618
        }
    }
}
