﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyStartup.Data;

#nullable disable

namespace QuanLyStartup.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanLyStartup.Models.DanhGiaStartup", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("DiemDanhGia")
                        .HasColumnType("int");

                    b.Property<int>("IDNguoiDung")
                        .HasColumnType("int");

                    b.Property<int>("IDStartup")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayDanhGia")
                        .HasColumnType("datetime2");

                    b.Property<string>("NhanXet")
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IDNguoiDung");

                    b.HasIndex("IDStartup");

                    b.ToTable("DanhGiaStartup");
                });

            modelBuilder.Entity("QuanLyStartup.Models.GiayTo", b =>
                {
                    b.Property<int>("IDGiayTo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDGiayTo"));

                    b.Property<string>("FileGiayTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDStartup")
                        .HasColumnType("int");

                    b.Property<string>("LoaiFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenGiayTo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDGiayTo");

                    b.HasIndex("IDStartup");

                    b.ToTable("GiayTo");
                });

            modelBuilder.Entity("QuanLyStartup.Models.Hashtag", b =>
                {
                    b.Property<int>("IDHashtag")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDHashtag"));

                    b.Property<string>("TenHashtag")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IDHashtag");

                    b.ToTable("Hashtag");
                });

            modelBuilder.Entity("QuanLyStartup.Models.HopDongDauTu", b =>
                {
                    b.Property<int>("IDHopDong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDHopDong"));

                    b.Property<string>("AnhXacNhan")
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDNguoiDung")
                        .HasColumnType("int");

                    b.Property<int>("IDStartup")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayKyKet")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDungHopDong")
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("PhanTramLoiNhuan")
                        .HasColumnType("float");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDHopDong");

                    b.HasIndex("IDNguoiDung");

                    b.HasIndex("IDStartup");

                    b.ToTable("HopDongDauTu");
                });

            modelBuilder.Entity("QuanLyStartup.Models.LinhVuc", b =>
                {
                    b.Property<int>("IDLinhVuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDLinhVuc"));

                    b.Property<string>("TenLinhVuc")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IDLinhVuc");

                    b.ToTable("LinhVuc");
                });

            modelBuilder.Entity("QuanLyStartup.Models.NguoiDung", b =>
                {
                    b.Property<int>("IDNguoiDung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDNguoiDung"));

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("VaiTro")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IDNguoiDung");

                    b.ToTable("NguoiDung");
                });

            modelBuilder.Entity("QuanLyStartup.Models.Startup", b =>
                {
                    b.Property<int>("IDStartup")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDStartup"));

                    b.Property<int?>("IDLinhVuc")
                        .HasColumnType("int");

                    b.Property<int>("IDNguoiDung")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("MucTieu")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<double?>("PhanTramCoPhan")
                        .HasColumnType("float");

                    b.Property<string>("TenStartup")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThaiXetDuyet")
                        .HasColumnType("int");

                    b.HasKey("IDStartup");

                    b.HasIndex("IDLinhVuc");

                    b.HasIndex("IDNguoiDung");

                    b.ToTable("Startup");
                });

            modelBuilder.Entity("QuanLyStartup.Models.ThongBao", b =>
                {
                    b.Property<int>("IDNoti")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDNoti"));

                    b.Property<int>("IDNguoiDung")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayGui")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IDNoti");

                    b.HasIndex("IDNguoiDung");

                    b.ToTable("ThongBao");
                });

            modelBuilder.Entity("QuanLyStartup.Models.TinNhan", b =>
                {
                    b.Property<int>("IDTinNhan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDTinNhan"));

                    b.Property<int?>("IDNguoiGui")
                        .HasColumnType("int");

                    b.Property<int?>("IDNguoiNhan")
                        .HasColumnType("int");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IDTinNhan");

                    b.HasIndex("IDNguoiGui");

                    b.HasIndex("IDNguoiNhan");

                    b.ToTable("TinNhan");
                });

            modelBuilder.Entity("QuanLyStartup.Models.TinTuc", b =>
                {
                    b.Property<int>("IDTinTuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDTinTuc"));

                    b.Property<int>("IDNguoiDung")
                        .HasColumnType("int");

                    b.Property<string>("ImgTinTuc")
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDang")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDTinTuc");

                    b.HasIndex("IDNguoiDung");

                    b.ToTable("TinTuc");
                });

            modelBuilder.Entity("QuanLyStartup.Models.TinTucHashtag", b =>
                {
                    b.Property<int>("IDTinTuc")
                        .HasColumnType("int");

                    b.Property<int>("IDHashtag")
                        .HasColumnType("int");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.HasKey("IDTinTuc", "IDHashtag");

                    b.HasIndex("IDHashtag");

                    b.ToTable("TinTucHashtag");
                });

            modelBuilder.Entity("QuanLyStartup.Models.DanhGiaStartup", b =>
                {
                    b.HasOne("QuanLyStartup.Models.NguoiDung", null)
                        .WithMany()
                        .HasForeignKey("IDNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyStartup.Models.Startup", null)
                        .WithMany()
                        .HasForeignKey("IDStartup")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("QuanLyStartup.Models.GiayTo", b =>
                {
                    b.HasOne("QuanLyStartup.Models.Startup", "Startup")
                        .WithMany("GiayTos")
                        .HasForeignKey("IDStartup")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Startup");
                });

            modelBuilder.Entity("QuanLyStartup.Models.HopDongDauTu", b =>
                {
                    b.HasOne("QuanLyStartup.Models.NguoiDung", "NguoiDung")
                        .WithMany("HopDongDauTus")
                        .HasForeignKey("IDNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyStartup.Models.Startup", "Startup")
                        .WithMany("HopDongDauTus")
                        .HasForeignKey("IDStartup")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("NguoiDung");

                    b.Navigation("Startup");
                });

            modelBuilder.Entity("QuanLyStartup.Models.Startup", b =>
                {
                    b.HasOne("QuanLyStartup.Models.LinhVuc", "LinhVuc")
                        .WithMany("Startups")
                        .HasForeignKey("IDLinhVuc")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("QuanLyStartup.Models.NguoiDung", "NguoiDung")
                        .WithMany("Startups")
                        .HasForeignKey("IDNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LinhVuc");

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("QuanLyStartup.Models.ThongBao", b =>
                {
                    b.HasOne("QuanLyStartup.Models.NguoiDung", "NguoiDung")
                        .WithMany()
                        .HasForeignKey("IDNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("QuanLyStartup.Models.TinNhan", b =>
                {
                    b.HasOne("QuanLyStartup.Models.NguoiDung", "NguoiGui")
                        .WithMany()
                        .HasForeignKey("IDNguoiGui");

                    b.HasOne("QuanLyStartup.Models.NguoiDung", "NguoiNhan")
                        .WithMany()
                        .HasForeignKey("IDNguoiNhan");

                    b.Navigation("NguoiGui");

                    b.Navigation("NguoiNhan");
                });

            modelBuilder.Entity("QuanLyStartup.Models.TinTuc", b =>
                {
                    b.HasOne("QuanLyStartup.Models.NguoiDung", "NguoiDung")
                        .WithMany()
                        .HasForeignKey("IDNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("QuanLyStartup.Models.TinTucHashtag", b =>
                {
                    b.HasOne("QuanLyStartup.Models.Hashtag", "Hashtag")
                        .WithMany("TinTucHashtags")
                        .HasForeignKey("IDHashtag")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyStartup.Models.TinTuc", "TinTuc")
                        .WithMany("TinTucHashtags")
                        .HasForeignKey("IDTinTuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hashtag");

                    b.Navigation("TinTuc");
                });

            modelBuilder.Entity("QuanLyStartup.Models.Hashtag", b =>
                {
                    b.Navigation("TinTucHashtags");
                });

            modelBuilder.Entity("QuanLyStartup.Models.LinhVuc", b =>
                {
                    b.Navigation("Startups");
                });

            modelBuilder.Entity("QuanLyStartup.Models.NguoiDung", b =>
                {
                    b.Navigation("HopDongDauTus");

                    b.Navigation("Startups");
                });

            modelBuilder.Entity("QuanLyStartup.Models.Startup", b =>
                {
                    b.Navigation("GiayTos");

                    b.Navigation("HopDongDauTus");
                });

            modelBuilder.Entity("QuanLyStartup.Models.TinTuc", b =>
                {
                    b.Navigation("TinTucHashtags");
                });
#pragma warning restore 612, 618
        }
    }
}
