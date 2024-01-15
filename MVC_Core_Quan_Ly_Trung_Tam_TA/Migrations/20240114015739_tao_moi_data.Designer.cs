﻿// <auto-generated />
using System;
using MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCCoreQuanLyTrungTamTA.Migrations
{
    [DbContext(typeof(GiangVienContext))]
    [Migration("20240114015739_tao_moi_data")]
    partial class taomoidata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC_Core_Quan_Ly_Trung_Tam_TA.Models.GiangVienModels", b =>
                {
                    b.Property<int>("MaGV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaGV"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diachi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gioitinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ngaysinh")
                        .HasColumnType("int");

                    b.Property<int>("Sdt")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TenGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trinhdo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("Updated_by")
                        .HasColumnType("int");

                    b.HasKey("MaGV");

                    b.ToTable("D_GiangVien");
                });
#pragma warning restore 612, 618
        }
    }
}
